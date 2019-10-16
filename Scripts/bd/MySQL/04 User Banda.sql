CREATE USER 'Banda'@'10.120.0.%' IDENTIFIED BY 'contrasenia';

GRANT INSERT, SELECT ON album TO 'Banda';
GRANT INSERT, SELECT ON cancion TO 'Banda';
GRANT SELECT ON reproduccion TO 'Banda';