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
telefono varchar(50) not null,
estado bit not null 
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
id int primary key identity(1,1),
nombre varchar(50) not null,
estado bit not null
)
go
create table Categorias(
id int primary key identity(1,1),
nombre varchar(50) not null,
estado bit not null
)
go
create table Productos(
id bigint primary key identity(1,1),
nombre varchar(50) not null,

estado bit not null
)
go
create table Publicaciones(
id int primary key identity(1,1),
titulo varchar(50) not null,
descripcion varchar(50) not null,
urlImagen varchar(100) not null,
stock int not null,
precio money not null,
idCategoria int foreign key references Categorias(id),
idMarca int foreign key references Marcas(id),
idProducto bigint foreign key references Productos(id),
idUsuario bigint foreign key references Usuarios(id),
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
go
insert into Categorias(nombre,estado) Values ('Notebook',1)
go
insert into Categorias(nombre,estado) Values ('Desktop',1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria)values('Noteebook','Hola Papi','Todavia No TEngo',12,12,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria)values('Deskotip','Baratita','Todavia No TEngo',112,122,2,1,1)

select Count(nombreDeUsuario) from Usuarios where nombreDeUsuario = 'chrispa'
select clave from usuarios where nombreDeUsuario = 'chrispa'
use master
go
drop database DB_TPC


