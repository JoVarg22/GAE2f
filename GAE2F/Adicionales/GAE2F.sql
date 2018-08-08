CREATE DATABASE GAE2F;
USE GAE2F;
USE MASTER;

CREATE TABLE Alarmas(
ID_Alarma     INT            PRIMARY KEY,
Descripcion   VARCHAR(100)   NOT NULL,
Criticidad    VARCHAR(50)    NOT NULL,
);

CREATE TABLE Alarmas_Activas(
ID_ActAlarma  INT           PRIMARY KEY,
Fecha         DATETIME      NOT NULL,
Hora          TIME          NOT NULL,
ID_Sitio      INT           NOT NULL,
ID_Alarma     INT           NOT NULL,
FOREIGN KEY (ID_Sitio) REFERENCES Sitio(ID_Sitio),
FOREIGN KEY (ID_Alarma) REFERENCES Alarmas(ID_Alarma),
);

CREATE TABLE Sitio(
ID_Sitio     INT            PRIMARY KEY,
Sitio        VARCHAR(50)    NOT NULL,
);

CREATE TABLE Usuarios(
ID_Usuario   INT           PRIMARY KEY,
Usuario      VARCHAR(50)   NOT NULL,
Contraseña   VARCHAR(50)   NOT NULL,
Nombre       VARCHAR(50)   NOT NULL,
Apellido1    VARCHAR(50)   NOT NULL,
Apellido2    VARCHAR(50)   NOT NULL,
Telefono     INT           NOT NULL,
Correo       VARCHAR(50)   NOT NULL,
ID_Rol       INT           NOT NULL,
FOREIGN KEY (ID_Rol) REFERENCES Roles(ID_Rol),
);

CREATE TABLE Roles(
ID_Rol       INT           PRIMARY KEY,
Rol          VARCHAR(50)   NOT NULL,
);

INSERT INTO Alarmas(ID_Alarma, Descripcion, Criticidad) values (1,'Falla de AC','Mayor');
INSERT INTO Sitio(ID_Sitio, Sitio) VALUES (011, 'San Pedro');
INSERT INTO Alarmas_Activas(ID_ActAlarma, Fecha, Hora, ID_Sitio, ID_Alarma) VALUES (1,GETDATE(), GETDATE(),011,1);
INSERT INTO Usuarios(ID_Usuario, Usuario, Contraseña, Nombre, Apellido1, Apellido2, Telefono, Correo, ID_Rol) 
VALUES (1,'JOVARG22','VARGAS1992', 'JONATHAN', 'VARGAS', 'JIMENEZ',22781279,'JVARGASJI@GMAIL.COM' , 1);
INSERT INTO Roles(ID_Rol, Rol) VALUES (1, 'OPERADOR');
INSERT INTO Roles(ID_Rol, Rol) VALUES (2, 'SUPERVISOR');
INSERT INTO Roles(ID_Rol, Rol) VALUES (3, 'ADMINISTRADOR');

SELECT * FROM Alarmas_Activas;
SELECT * FROM Usuarios;
SELECT * FROM Sitio;
SELECT * FROM Roles;
SELECT * FROM Alarmas;