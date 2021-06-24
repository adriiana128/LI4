SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema PhoTravel
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema PhoTravel
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `PhoTravel` ;
USE `PhoTravel` ;

-- -----------------------------------------------------
-- Table `PhoTravel`.`Utilizador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PhoTravel`.`Utilizador` (
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `isAdmin` TINYINT NOT NULL,
  `nome` VARCHAR(100) NULL,
  `scoreTotal` INT NULL,
  PRIMARY KEY (`username`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PhoTravel`.`Local`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PhoTravel`.`Local` (
  `id` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PhoTravel`.`Foto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PhoTravel`.`Foto` (
  `id` INT NOT NULL,
  `score` INT NULL,
  `Utilizador_username` VARCHAR(45) NOT NULL,
  `Local_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Foto_Utilizador_idx` (`Utilizador_username` ASC),
  INDEX `fk_Foto_Local1_idx` (`Local_id` ASC),
  CONSTRAINT `fk_Foto_Utilizador`
    FOREIGN KEY (`Utilizador_username`)
    REFERENCES `PhoTravel`.`Utilizador` (`username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Foto_Local1`
    FOREIGN KEY (`Local_id`)
    REFERENCES `PhoTravel`.`Local` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PhoTravel`.`Comentario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PhoTravel`.`Comentario` (
  `id` INT NOT NULL,
  `texto` VARCHAR(250) NULL,
  `score` INT NULL,
  `Foto_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Comentario_Foto1_idx` (`Foto_id` ASC),
  CONSTRAINT `fk_Comentario_Foto1`
    FOREIGN KEY (`Foto_id`)
    REFERENCES `PhoTravel`.`Foto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

