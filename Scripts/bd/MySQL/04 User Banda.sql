/*1*/
CREATE USER 'usuarioAdministrador'@'10.120.0.%' IDENTIFIED BY '12345678';

GRANT SELECT, INSERT ON banda TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT, UPDATE ON album TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT, UPDATE ON cancion TO 'usuarioAdministrador'@'10.120.0.%';
GRANT SELECT ON cliente TO 'usuarioAdministrador'@'10.120.0.%';

/*2*/
CREATE USER 'Banda'@'10.120.0.%' IDENTIFIED BY 'contrasenia';

GRANT SELECT ON banda TO 'Banda'@'10.120.0.%';
GRANT INSERT, SELECT ON album TO 'Banda'@'10.120.0.%';
GRANT INSERT, SELECT ON cancion TO 'Banda'@'10.120.0.%';
GRANT SELECT ON reproduccion TO 'Banda'@'10.120.0.%';

/*3*/
CREATE USER 'usuarioCliente'@'10.120.0.%' IDENTIFIED BY '12345678';

GRANT SELECT ON cliente TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON banda TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON album TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT ON cancion TO 'usuarioCliente'@'10.120.0.%';
GRANT SELECT, INSERT ON reproduccion TO 'usuarioCliente'@'10.120.0.%';


/*Roles con conexión 'localhost' para pruebas locales*/

/*1*/
CREATE USER 'usuarioAdministrador'@'localhost' IDENTIFIED BY '12345678';

GRANT SELECT, INSERT ON banda TO 'usuarioAdministrador'@'localhost';
GRANT SELECT, UPDATE ON album TO 'usuarioAdministrador'@'localhost';
GRANT SELECT, UPDATE ON cancion TO 'usuarioAdministrador'@'localhost';
GRANT SELECT ON cliente TO 'usuarioAdministrador'@'localhost';

/*2*/
CREATE USER 'Banda'@'localhost' IDENTIFIED BY 'contrasenia';

GRANT SELECT ON banda TO 'Banda'@'localhost';
GRANT INSERT, SELECT ON album TO 'Banda'@'localhost';
GRANT INSERT, SELECT ON cancion TO 'Banda'@'localhost';
GRANT SELECT ON reproduccion TO 'Banda'@'localhost';

/*3*/
CREATE USER 'usuarioCliente'@'localhost' IDENTIFIED BY '12345678';

GRANT SELECT ON cliente TO 'usuarioCliente'@'localhost';
GRANT SELECT ON banda TO 'usuarioCliente'@'localhost';
GRANT SELECT ON album TO 'usuarioCliente'@'localhost';
GRANT SELECT ON cancion TO 'usuarioCliente'@'localhost';
GRANT SELECT, INSERT ON reproduccion TO 'usuarioCliente'@'localhost';