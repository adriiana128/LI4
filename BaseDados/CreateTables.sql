-- -----------------------------------------------------
-- Table Utilizador
-- -----------------------------------------------------
CREATE TABLE Utilizador (
  username VARCHAR(45)  NOT NULL PRIMARY KEY,
  password VARCHAR(45) NOT NULL,
  isAdmin TINYINT NOT NULL,
  nome VARCHAR(100) NULL,
  scoreTotal INT NULL
  )

-- -----------------------------------------------------
-- Table Local
-- -----------------------------------------------------
CREATE TABLE Local (
  id INT NOT NULL PRIMARY KEY,
  nome VARCHAR(45) NULL
)



-- -----------------------------------------------------
-- Table PhoTravel.Foto
-- -----------------------------------------------------
CREATE TABLE Foto (
  id INT NOT NULL PRIMARY KEY,
  score INT NULL,
  Utilizador_username VARCHAR(45) FOREIGN KEY REFERENCES Utilizador (username),
  Local_id INT FOREIGN KEY REFERENCES Local (id)
)
