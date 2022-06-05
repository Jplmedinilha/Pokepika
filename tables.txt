-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pokemon
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pokemon
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pokemon` DEFAULT CHARACTER SET utf8mb3 ;
USE `pokemon` ;

-- -----------------------------------------------------
-- Table `pokemon`.`types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pokemon`.`types` (
  `idType` INT NOT NULL AUTO_INCREMENT,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idType`, `type`),
  UNIQUE INDEX `type_UNIQUE` (`type` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `pokemon`.`pokemons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pokemon`.`pokemons` (
  `numPokemon` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `type` VARCHAR(45) NOT NULL,
  `attack` VARCHAR(45) NOT NULL,
  `hp` INT NOT NULL,
  `price` INT NOT NULL,
  `hasEvolution` VARCHAR(1) NOT NULL DEFAULT 'Y',
  `gym` INT NOT NULL,
  PRIMARY KEY (`numPokemon`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC) VISIBLE,
  INDEX `fk_pokemons_types1_idx` (`type` ASC) VISIBLE,
  CONSTRAINT `fk_pokemons_types1`
    FOREIGN KEY (`type`)
    REFERENCES `pokemon`.`types` (`type`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `pokemon`.`user`
-- -----------------------------------------------------
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
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `pokemon`.`hist_trade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pokemon`.`hist_trade` (
  `idUser` INT NOT NULL,
  `numPokemon` INT NOT NULL,
  `date` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idUser`, `numPokemon`),
  INDEX `fk_User_has_Pokemon_Pokemon2_idx` (`numPokemon` ASC) VISIBLE,
  INDEX `fk_User_has_Pokemon_User1_idx` (`idUser` ASC) VISIBLE,
  CONSTRAINT `fk_User_has_Pokemon_Pokemon2`
    FOREIGN KEY (`numPokemon`)
    REFERENCES `pokemon`.`pokemons` (`numPokemon`),
  CONSTRAINT `fk_User_has_Pokemon_User1`
    FOREIGN KEY (`idUser`)
    REFERENCES `pokemon`.`user` (`idUser`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `pokemon`.`userpokemon`
-- -----------------------------------------------------
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


DELIMITER $$ 
CREATE TRIGGER update_hist
BEFORE INSERT 
ON userpokemon FOR EACH ROW
BEGIN
    INSERT INTO hist_trade VALUES (new.idUser, new.numPokemon, DATE_FORMAT(NOW(), '%d/%m/%y %T'));
END $$


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
