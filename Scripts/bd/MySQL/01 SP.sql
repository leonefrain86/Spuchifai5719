delimiter $$
create procedure altaBanda (unidBanda SMALLINT,
                            unnombre VARCHAR(45),
                            unanioFundacion SMALLINT)
BEGIN
    INSERT INTO Banda (idBanda, nombre, anioFundacion)
                VALUES (unidBanda, unnombre, unaniofundacion);
END 
 $$

create procedure altaAlbum (unidAlbum INT,
                            unidBanda SMALLINT,
                            unnombre VARCHAR(45),
                            unfechaLanzamiento DATE)
BEGIN
    INSERT INTO Album (idAlbum, idBanda, nombre, fechaLanzamiento)
                VALUES (unidAlbum, unidBanda, unnombre, unfechaLanzamiento);
END
$$

create procedure altaCancion (unidcancion INT,
                            unidAlbum INT,
                            unnumeroOrden TINYINT,
                            unnombre VARCHAR(45))
BEGIN
    INSERT INTO Cancion (idCancion, idAlbum, numeroOrden, nombre)
                VALUES (unidCancion, unidAlbum, unnumeroOrden, unnombre);
END
$$

create procedure altaReproduccion (unidReproduccion INT,
                            unidCliente INT,
                            unidCancion INT,
                            unfechaHora DATETIME)
BEGIN
    INSERT INTO Reproduccion (idreproduccion, idCliente, idCancion, fechaHora)
                VALUES (unidReproduccion, unidCliente, unidCancion, unfechaHora);
END
$$

create procedure altaCliente (unidCliente INT,                            
                            unnombre VARCHAR(45),
                            unapellido VARCHAR(45),
                            unmail VARCHAR(45),
                            uncontrasenia VARCHAR(45))
BEGIN
    INSERT INTO Cliente (idCliente, nombre, apellido, mail, contrasenia)
                VALUES (unidCliente, unnombre, unapellido, unmail, SHA(uncontrasenia));
END
$$