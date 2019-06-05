DELIMITER //
CREATE FUNCTION cantidadDeReproducciones( unIdCancion INTEGER )
RETURNS INT
BEGIN 
        DECLARE TOTAL INT;
        SELECT COUNT(idReproduccion)
        INTO TOTAL
        FROM Reproduccion
        where idCancion = unIdCancion;

        RETURN TOTAL;
END//

DELIMITER //
CREATE FUNCTION cantidadDeReproduccionesPorBanda ( unIdBanda SMALLINT)
RETURNS INT
BEGIN 
        DECLARE TOTAL INT ;
        SELECT SUM(cantidadDeReproducciones(idCancion))
        INTO TOTAL
        FROM Album A 
        INNER JOIN Cancion C
        ON A.idAlbum = C.idAlbum
        where A.idBanda = unIdBanda;

        RETURN TOTAL;
END//
