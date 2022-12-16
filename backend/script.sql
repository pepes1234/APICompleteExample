use master
go

if exists(select * from sys.databases where name = 'Exemplo')
	drop database Exemplo
go

create database Exemplo
go

use Exemplo
go

create table Usuario(
	Id int primary key identity,
	Nome VARCHAR(255),
	Email VARCHAR(255),
	Senha VARCHAR(255),
);
go

create table Token(
	ID int identity primary key,
	UserID int references Usuario(ID),
	Value varchar(MAX) not null
);
go

create table Notas(
	Id int primary key identity,
	UsuarioID int references Usuario(Id),
	Nota VARCHAR(255),
);
go