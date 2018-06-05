CREATE DATABASE Parcial1Db
GO
USE Parcial1Db
GO
CREATE TABLE Grupos
(
	GrupoId int primary key identity(1,1),
	Fecha varchar(30),
	Descripcion varchar(13),
	Cantidad varchar(13),
	Grupos varchar(10),
	Integrantes varchar(30)
);