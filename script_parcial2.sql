CREATE DATABASE Parcial2JJRP;
CREATE LOGIN usrparcial2 WITH PASSWORD='12345678',
  DEFAULT_DATABASE = Parcial2JJRP,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE Parcial2JJRP
CREATE user usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE db_owner ADD MEMBER usrparcial2
GO

DROP TABLE Serie;

CREATE TABLE Serie (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  titulo VARCHAR(250) NOT NULL,
  sinopsis VARCHAR(5000) NOT NULL,
  director VARCHAR(100) NOT NULL,
  duracion INT NOT NULL,
  fechaEstreno DATE NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  estado SMALLINT NOT NULL DEFAULT 1
);

CREATE PROC paSerieListar @parametro VARCHAR(50)
AS
  SELECT id,titulo,sinopsis,director,duracion,fechaEstreno,usuarioRegistro,estado
  FROM Serie
  WHERE estado<>-1 AND titulo LIKE '%'+REPLACE(@parametro,' ','%')+'%';