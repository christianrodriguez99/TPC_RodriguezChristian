create database DB_TPC
go
use DB_TPC
go
create table Usuarios
(
id bigint primary key identity(1,1),
nombreDeUsuario varchar(50) not null,
clave varchar(50) not null,
dni varchar(50) not null,
nombre varchar(50) not null,
apellido varchar(50) not null,
email varchar(50) not null,
telefono varchar(50) not null
)
go
create table Administradores
(
id bigint primary key identity(1,1),
idUsuario bigint foreign key references Usuarios(id),
estado bit not null
)
go
create table Marcas(
id bigint primary key identity(1,1),
nombre varchar(50) not null,
estado bit not null
)
go
create table Categorias(
id bigint primary key identity(1,1),
nombre varchar(50) not null,
estado bit not null
)
go
create table Productos(
id bigint primary key identity(1,1),
nombre varchar(50) not null,
idCategoria bigint foreign key references Categorias(id),
idMarca bigint foreign key references Marcas(id),
estado bit not null
)
create table Publicacion(
id bigint primary key identity(1,1),
titulo varchar(50) not null,
descripcion varchar(50) not null,
urlImagen varchar(100) not null,
stock bigint not null,
precio money not null,
idProducto bigint foreign key references Productos(id),
estado bit not null,

)
go
insert into Marcas(nombre,estado) Values ('HP',1)
go
insert into Marcas(nombre,estado) Values ('DELL',0)
go
insert into Marcas(nombre,estado) Values ('ASUS',1)
go
insert into Marcas(nombre,estado) Values ('ACER',1)

select * from Marcas
use master
go
drop database DB_TPC


