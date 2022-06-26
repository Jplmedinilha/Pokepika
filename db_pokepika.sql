CREATE SCHEMA IF NOT EXISTS `pokemon` DEFAULT CHARACTER SET utf8 ;
USE `pokemon` ;

CREATE TABLE IF NOT EXISTS `pokemon`.`hist_trade` (
  `idUser` INT NOT NULL,
  `numPokemon` INT NOT NULL,
  `date` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idUser`, `numPokemon`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


CREATE TABLE IF NOT EXISTS `pokemon`.`types` (
  `idType` INT NOT NULL AUTO_INCREMENT,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idType`, `type`),
  UNIQUE INDEX `type_UNIQUE` (`type` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb3;


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
    REFERENCES `pokemon`.`types` (`type`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


CREATE TABLE IF NOT EXISTS `pokemon`.`user` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `isAdm` VARCHAR(1) NOT NULL DEFAULT 'N',
  `balance` INT NOT NULL DEFAULT '1000',
  PRIMARY KEY (`idUser`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8mb3;


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
    REFERENCES `pokemon`.`user` (`idUser`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;

USE `pokemon` ;
SET SQL_SAFE_UPDATES = 0;
DELIMITER $$
CREATE PROCEDURE `deletePokemon`(IN idPokemon INT)
   BEGIN
		
        DELETE FROM userpokemon where numPokemon = idPokemon;
        
        DELETE FROM pokemon.pokemons WHERE numPokemon = idPokemon;
        
    END $$

DELIMITER $$
CREATE PROCEDURE `deleteUser`(IN idUser INT)
BEGIN
		
        DELETE FROM userpokemon where idUser = idUser;
        
        DELETE FROM pokemon.`user` WHERE idUser = idUser;
        
    END $$


DELIMITER $$
USE `pokemon`$$
CREATE
TRIGGER `pokemon`.`update_hist`
BEFORE INSERT ON `pokemon`.`userpokemon`
FOR EACH ROW
BEGIN
    INSERT INTO hist_trade VALUES (new.idUser, new.numPokemon, DATE_SUB(NOW(), INTERVAL 3 HOUR));
END$$



