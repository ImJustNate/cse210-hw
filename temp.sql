-- MySQL Script generated by MySQL Workbench
-- Wed Oct 23 10:28:26 2024
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema film
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema film
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `film` DEFAULT CHARACTER SET utf8 ;
SHOW WARNINGS;
USE `film` ;

-- -----------------------------------------------------
-- Table `film`.`studio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`studio` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`studio` (
  `studio_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `studio_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`studio_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`rating`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`rating` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`rating` (
  `rating_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `rating_type` ENUM("G", "PG", "PG-13", "R") NOT NULL,
  PRIMARY KEY (`rating_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`movie`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`movie` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`movie` (
  `movie_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NOT NULL,
  `year_released` INT NOT NULL,
  `studio_id` INT UNSIGNED NOT NULL,
  `rating_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`movie_id`),
  CONSTRAINT `fk_film_studio`
    FOREIGN KEY (`studio_id`)
    REFERENCES `film`.`studio` (`studio_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_rating1`
    FOREIGN KEY (`rating_id`)
    REFERENCES `film`.`rating` (`rating_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_film_studio_idx` ON `film`.`movie` (`studio_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_rating1_idx` ON `film`.`movie` (`rating_id` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`genra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`genra` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`genra` (
  `genra_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `genra_type` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`genra_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`media_type`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`media_type` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`media_type` (
  `media_type_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `media_type` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`media_type_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`feture`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`feture` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`feture` (
  `feture_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `feture_type` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`feture_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`actor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`actor` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`actor` (
  `actor_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `fname` VARCHAR(15) NOT NULL,
  `lname` VARCHAR(15) NULL,
  PRIMARY KEY (`actor_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`price`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`price` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`price` (
  `price_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `price_type` DECIMAL NOT NULL,
  PRIMARY KEY (`price_id`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`movie_genra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`movie_genra` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`movie_genra` (
  `movie_genra_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `movie_id` INT UNSIGNED NOT NULL,
  `genra_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`movie_genra_id`),
  CONSTRAINT `fk_film_has_genra_film1`
    FOREIGN KEY (`movie_id`)
    REFERENCES `film`.`movie` (`movie_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_has_genra_genra1`
    FOREIGN KEY (`genra_id`)
    REFERENCES `film`.`genra` (`genra_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_genra_genra1_idx` ON `film`.`movie_genra` (`genra_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_genra_film1_idx` ON `film`.`movie_genra` (`movie_id` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`movie_media`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`movie_media` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`movie_media` (
  `movie_media_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `movie_id` INT UNSIGNED NOT NULL,
  `price_id` INT UNSIGNED NULL,
  `media_type_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`movie_media_id`),
  CONSTRAINT `fk_film_has_price_film1`
    FOREIGN KEY (`movie_id`)
    REFERENCES `film`.`movie` (`movie_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_has_price_price1`
    FOREIGN KEY (`price_id`)
    REFERENCES `film`.`price` (`price_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_has_price_media_type1`
    FOREIGN KEY (`media_type_id`)
    REFERENCES `film`.`media_type` (`media_type_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_price_price1_idx` ON `film`.`movie_media` (`price_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_price_film1_idx` ON `film`.`movie_media` (`movie_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_price_media_type1_idx` ON `film`.`movie_media` (`media_type_id` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`movie_feture`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`movie_feture` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`movie_feture` (
  `movie_feture_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `movie_id` INT UNSIGNED NOT NULL,
  `feture_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`movie_feture_id`),
  CONSTRAINT `fk_film_has_feture_film1`
    FOREIGN KEY (`movie_id`)
    REFERENCES `film`.`movie` (`movie_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_has_feture_feture1`
    FOREIGN KEY (`feture_id`)
    REFERENCES `film`.`feture` (`feture_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_feture_film1_idx` ON `film`.`movie_feture` (`movie_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_has_feture_feture1_idx` ON `film`.`movie_feture` (`feture_id` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `film`.`movie_actor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `film`.`movie_actor` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `film`.`movie_actor` (
  `movie_actor_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `movie_id` INT UNSIGNED NOT NULL,
  `actor_id` INT NOT NULL,
  PRIMARY KEY (`movie_actor_id`),
  CONSTRAINT `fk_film_actor_film1`
    FOREIGN KEY (`movie_id`)
    REFERENCES `film`.`movie` (`movie_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_film_actor_actors1`
    FOREIGN KEY (`actor_id`)
    REFERENCES `film`.`actor` (`actor_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE INDEX `fk_film_actor_film1_idx` ON `film`.`movie_actor` (`movie_id` ASC) VISIBLE;

SHOW WARNINGS;
CREATE INDEX `fk_film_actor_actors1_idx` ON `film`.`movie_actor` (`actor_id` ASC) VISIBLE;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- ACTOR TABLE
INSERT INTO actor (actor_id, fname, lname) VALUES
,	(NULL, 'Tom', 'Hanks') -- 1
,	(NULL, 'Tim', 'Allen') -- 2
,	(NULL, 'Annie', 'Potts') -- 3
,	(NULL, 'John', 'Ratzenberger') -- 4
,	(NULL, 'Gene', 'Kelly') -- 5
,	(NULL, 'Cyd', 'Charisse') -- 6
,	(NULL, 'Van', 'Johnson') -- 7
,	(NULL, 'Harrison', 'Ford') -- 8
,	(NULL, 'Carrie', 'Fisher') -- 9
,	(NULL, 'Mark', 'Hamill') -- 10
,	(NULL, 'Emilia', 'Jones') -- 11
,	(NULL, 'Marlee', 'Matlin') -- 12
,	(NULL, 'Troy ', 'Kotsur') -- 13
,	(NULL, 'Timothee', 'Chalamet') -- 14
,	(NULL, 'Rebecca', 'Ferguson') -- 15
,	(NULL, 'Zendaya', NULL) -- 16
,	(NULL, 'Oscar', 'Isaac') -- 17
,	(NULL, 'Jason', 'Momoa'); -- 18
    
    SELECT * FROM actor;
    
    -- RATING TABLE
    INSERT INTO rating (rating_id, rating_type) VALUES
	(NULL, "G"), -- 1
	(NULL, "PG"), -- 2
	(NULL, "PG-13"), -- 3
	(NULL, "R"); -- 4
    
    SELECT * FROM rating;
    
    -- STUDIO TABLE
    INSERT INTO studio (studio_id, studio_name) VALUES
	(NULL, "Pixar"), -- 1
	(NULL, "MGM"), -- 2
	(NULL, "20th Century Fox"), -- 3
	(NULL, "Apple TV+"), -- 4
	(NULL, "Warner Bros"); -- 5
    
    SELECT * FROM studio;
    
        -- GENRA TABLE
    INSERT INTO genra (genra_id, genra_type) VALUES
	(NULL, "Family"), -- 1
	(NULL, "Animated"), -- 2
	(NULL, "Musical"), -- 3
	(NULL, "Romance"), -- 4
	(NULL, "Sci Fi"), -- 5
	(NULL, "Comedy"), -- 6
	(NULL, "Drama"), -- 7
	(NULL, "Music"), -- 8
	(NULL, "Action"), -- 9
	(NULL, "Adventure"); -- 10    
    
    SELECT * FROM genra;
    
        -- media_type TABLE
    INSERT INTO media_type (media_type_id, media_type) VALUES
	(NULL, "DVD"), -- 1
	(NULL, "Blue-Ray"), -- 2
	(NULL, "Streaming"), -- 3
	(NULL, "4K"); -- 4    
    
    SELECT * FROM media_type;
    
		-- price TABLE
     INSERT INTO price (price_type) VALUES
 	("DVD"), -- 1
 	("Blue-Ray"), -- 2
 	("Streaming"), -- 3
 	("4K"); -- 4
    
    SELECT * FROM price;
    
    
    
    