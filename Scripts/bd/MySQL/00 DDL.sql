
create schema spuchifai;
use spuchifai;
SET FOREIGN_KEY_CHECKS=0;





CREATE TABLE Album
(
	idAlbum INT NOT NULL,
	idBanda SMALLINT NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	fechaLanzamiento DATE NOT NULL,
	PRIMARY KEY (idAlbum)
) 
;


CREATE TABLE Banda
(
	idBanda SMALLINT NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	anioFundacion SMALLINT NOT NULL,
	PRIMARY KEY (idBanda)
) 
;


CREATE TABLE Cancion
(
	idCancion INTEGER NOT NULL,
	idAlbum INT NOT NULL,
	numeroOrden TINYINT NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	PRIMARY KEY (idCancion),
	KEY (idAlbum)
) 
;


CREATE TABLE Cliente
(
	idCliente INTEGER NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	apellido VARCHAR(45) NOT NULL,
	mail VARCHAR(45) NOT NULL,
	contrasenia VARCHAR(45) NOT NULL,
	PRIMARY KEY (idCliente)
) 
;


CREATE TABLE Reproduccion
(
	idReproduccion INTEGER NOT NULL,
	idCliente INTEGER NOT NULL,
	idCancion INTEGER NOT NULL,
	fechaHora DATETIME NOT NULL,
	PRIMARY KEY (idReproduccion),
	KEY (idCancion),
	KEY (idCliente)
) 
;



SET FOREIGN_KEY_CHECKS=1;


ALTER TABLE Cancion ADD CONSTRAINT FK_Cancion_Album 
	FOREIGN KEY (idAlbum) REFERENCES Album (idAlbum)
	ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE Reproduccion ADD CONSTRAINT FK_Reproducido_Cancion 
	FOREIGN KEY (idCancion) REFERENCES Cancion (idCancion)
	ON DELETE NO ACTION ON UPDATE NO ACTION
;

ALTER TABLE Reproduccion ADD CONSTRAINT FK_Reproducido_Cliente 
	FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente)
	ON DELETE NO ACTION ON UPDATE NO ACTION
;
