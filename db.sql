CREATE SCHEMA IF NOT EXISTS `pokemon`;
USE `pokemon` ;

CREATE TABLE IF NOT EXISTS `pokemon`.`hist_trade` (
  `idUser` INT NOT NULL,
  `numPokemon` INT NOT NULL,
  `date` VARCHAR(45) NOT NULL,
  `tradeType` enum('SALE', 'PURCHASE') NOT NULL
);


CREATE TABLE IF NOT EXISTS `pokemon`.`types` (
  `idType` INT NOT NULL AUTO_INCREMENT,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idType`, `type`),
  UNIQUE INDEX `type_UNIQUE` (`type` ASC) VISIBLE);


CREATE TABLE IF NOT EXISTS `pokemon`.`pokemons` (
  `numPokemon` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `type` VARCHAR(45) NOT NULL,
  `attack` VARCHAR(45) NOT NULL,
  `hp` INT NOT NULL,
  `price` INT NOT NULL,
  `hasEvolution` VARCHAR(1) NOT NULL DEFAULT 'Y',
  `gym` INT NOT NULL,
  `picture` LONGBLOB NULL DEFAULT NULL,
  PRIMARY KEY (`numPokemon`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE,
  INDEX `fk_pokemons_types1_idx` (`type` ASC) VISIBLE,
  CONSTRAINT `fk_pokemons_types1`
    FOREIGN KEY (`type`)
    REFERENCES `pokemon`.`types` (`type`)
    ON UPDATE CASCADE);


CREATE TABLE IF NOT EXISTS `pokemon`.`user` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `isAdm` VARCHAR(1) NOT NULL DEFAULT 'N',
  `balance` INT NOT NULL DEFAULT '1000',
  PRIMARY KEY (`idUser`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE);


CREATE TABLE IF NOT EXISTS `pokemon`.`userpokemon` (
  `idUser` INT NOT NULL,
  `numPokemon` INT NOT NULL,
  PRIMARY KEY (`idUser`, `numPokemon`),
  INDEX `fk_User_has_Pokemon_Pokemon1_idx` (`numPokemon` ASC) VISIBLE,
  INDEX `fk_User_has_Pokemon_User_idx` (`idUser` ASC) VISIBLE,
  CONSTRAINT `fk_User_has_Pokemon_Pokemon1`
    FOREIGN KEY (`numPokemon`)
    REFERENCES `pokemon`.`pokemons` (`numPokemon`),
  CONSTRAINT `fk_User_has_Pokemon_User`
    FOREIGN KEY (`idUser`)
    REFERENCES `pokemon`.`user` (`idUser`));

SET SQL_SAFE_UPDATES = 0; -- NECESSARIO

-- PROCEDURES
use pokemon;
DELIMITER $$
CREATE PROCEDURE `deletePokemon`(IN idPokemon INT)
   BEGIN
		
        DELETE FROM userpokemon where numPokemon = idPokemon;
        
        DELETE FROM pokemon.pokemons WHERE numPokemon = idPokemon;
        
    END $$

DELIMITER $$
CREATE PROCEDURE `deleteUser`(IN id_user INT)
BEGIN
		
        DELETE FROM userpokemon where idUser = id_user;
        
        DELETE FROM pokemon.`user` WHERE idUser = id_user;
        
END $$


DELIMITER $$
CREATE PROCEDURE `updateBalance`(IN price INT, IN user_name varchar(45))
BEGIN
	UPDATE `user`
    SET balance = balance - price
    WHERE username = user_name;
END $$

DELIMITER $$
CREATE  PROCEDURE `sellPokemon`(IN user_name varchar(45), IN n_pokemon INT)
BEGIN
	DECLARE pokePrice INT;
	SELECT price INTO pokePrice from pokemons WHERE numPokemon = n_pokemon;
    
	DELETE FROM `userpokemon` WHERE idUser = (SELECT idUser from  `user` WHERE username = user_name) AND numPokemon = n_pokemon;
	
	UPDATE `user`
    SET balance = balance + pokePrice
    WHERE username = user_name;
END$$


-- TRIGGER
DELIMITER $$
CREATE
TRIGGER `pokemon`.`sell_hist`
BEFORE INSERT ON `pokemon`.`userpokemon`
FOR EACH ROW
BEGIN
    INSERT INTO hist_trade VALUES (new.idUser, new.numPokemon, NOW(),  1);
END$$

DELIMITER $$
CREATE
TRIGGER `pokemon`.`buy_hist`
AFTER DELETE ON `pokemon`.`userpokemon`
FOR EACH ROW
BEGIN
    INSERT INTO hist_trade VALUES (old.idUser, old.numPokemon, NOW(),  2);
END$$


-- exs inserts 
-- cricao tipos do pokemon
INSERT INTO `pokemon`.`types` (`idType`, `type`) VALUES ('4', 'Raio');

-- criacao pokemon
INSERT INTO `pokemon`.`pokemons` (`numPokemon`, `name`, `type`, `attack`, `hp`, `price`, `hasEvolution`, `gym`) VALUES ('8', 'Pikachu', 'Raio', '12', '200', '223', 'Y', '2');

-- exemplos detalhados de comandos SQL que são executados por seu Software
INSERT INTO `pokemon`.`user` (`idUser`, `username`, `name`, `password`, `isAdm`, `balance`) VALUES ('3', 'teste', 'teste', md5('eduardolegal'), 'N', '2000'); -- insert user com senha criptrografada (o mecanisco de hash é feito no software)

INSERT INTO `pokemon`.`userpokemon` (`idUser`, `numPokemon`) VALUES 
                ((SELECT idUser FROM pokemon.user WHERE username = 'teste'), 8); -- inventario, quando é feita uma compra é salvo nesta tabela o usuario e o pokemon comprado

SELECT * FROM pokemon.userpokemon WHERE numPokemon = 8 
                AND idUser = (SELECT idUser FROM pokemon.user WHERE username = 'teste'); -- usado para verificar se o usuario possui determinado pokemons, se retornar vazio, é assumido falso

SELECT `name`, `type`, `picture` from pokemon.pokemons as p 
INNER JOIN `userpokemon` as up ON p.numPokemon = up.numPokemon 
WHERE up.idUser = (SELECT idUser from `user` where username = 'teste'); -- retorna informações de todos os pokemons de um determinad usuario, usado para compor o painel de perfil

SELECT * FROM pokemon.user WHERE username = 'teste' AND isAdm = 'Y'  -- verifica se o usuario é admistrador ou não, se retornar vazio, é assumido falso

SELECT * FROM pokemons WHERE numPokemon NOT IN (
	SELECT up.numPokemon FROM pokemon.pokemons AS p 
    INNER JOIN `userpokemon` AS up ON p.numPokemon = up.numPokemon 
    WHERE up.idUser = (SELECT idUser FROM `user` WHERE username = 'teste')
); -- retorna todos os pokemons que o usuario nao possui, ou seja, disponivel para compra


CALL updateBalance(20, 'teste'); -- quando é feita uma compra. o saldo do usuario é descontado
CALL deleteUser(3); -- antes de deletar um usuario, ele é deletado da tabela `userpokemon`
CALL deletePokemon(8); -- antes de deletar um pokemon, ele é deletado da tabela `userpokemon`
CALL sellPokemon('teste', 8); -- vende o pokemon, retira de seu inventario e atualiza seu saldo





