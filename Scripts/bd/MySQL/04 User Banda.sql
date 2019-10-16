/*1*/
CREATE USER 'usuarioAdministrador'@'10.120.0.%' IDENTIFIED BY '12345678';

GRANT SELECT, INSERT ON Bandas TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT, UPDATE ON Album TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT, UPDATE ON Cancion TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT ON Cliente TO 'usuarioAdministrador'@'10.120.0.%';

/*2*/
CREATE USER 'Banda'@'10.120.0.%' IDENTIFIED BY 'contrasenia';

GRANT SELECT ON Banda TO 'Banda'@'10.120.0.%';
GRANT INSERT, SELECT ON album TO 'Banda'@'10.120.0.%';
GRANT INSERT, SELECT ON cancion TO 'Banda'@'10.120.0.%';
GRANT SELECT ON reproduccion TO 'Banda'@'10.120.0.%';

/*3*/
CREATE USER 'usuarioCliente'@'10.120.0.%' IDENTIFIED BY '12345678';

GRANT SELECT ON Cliente TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON Banda TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON Album TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON Cancion TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT, INSERT ON Reproduccion TO 'usuarioCliente'@'10.120.0.%';