﻿
CREATE DATABASE Navegador
 
GO
use Navegador
GO
CREATE TABLE usuarios(
	id_Usuario bigint IDENTITY(1,1) Primary key NOT NULL,
	usuario varchar(50) NULL,
	contraseña varchar(50) NULL,
	perfil int NULL,
	Nombre varchar(50) NULL,
	Apellido1 varchar(50) NULL,
	Apellido2 varchar(50) NULL,
) 

GO

CREATE TABLE Historiales(
	id_historial bigint IDENTITY(1,1) Primary key  NOT NULL,
	id_Usuario bigint NULL,
	FechaIngreso datetime NULL,
	CONSTRAINT FK_Historial_usuarios1 FOREIGN KEY(id_Usuario)REFERENCES usuarios (id_Usuario)
)


