create database DB_TPC
go
use DB_TPC
go
create table Usuarios
(
id int primary key identity(1,1),
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
id int primary key identity(1,1),
idUsuario int foreign key references Usuarios(id),
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
urlImagen varchar(200) not null,
stock int not null,
precio money not null,
idCategoria int foreign key references Categorias(id),
idMarca int foreign key references Marcas(id),
idProducto bigint foreign key references Productos(id),
idUsuario int foreign key references Usuarios(id),
estado bit not null,
)
go
create table Ventas(
id int primary key identity (1,1),
cantidad int not null,
idUsuarioVendedor int foreign key references Usuarios(id),
idUsuarioComprador int foreign key references Usuarios(id),
idPublicacion int foreign key references Publicaciones(id),
fecha datetime not null
)
go
create table Compras(
id int primary key identity (1,1),
cantidad int not null,
idUsuarioVendedor int foreign key references Usuarios(id),
idUsuarioComprador int foreign key references Usuarios(id),
idPublicacion int foreign key references Publicaciones(id),
fecha datetime not null
)
go
create table PublicacionesxUsuarios(
idUsuario int foreign key references Usuarios(id),
idPublicacion int foreign key references Publicaciones(id),
)
go
insert into Usuarios(nombreDeUsuario,clave,dni,nombre,apellido,email,telefono,estado) Values ('Chrispa','33286489xd','41956008','Christian','Rodriguez','christiansrodriguez99@gmail.com','1145602785',1)
go
insert into Usuarios(nombreDeUsuario,clave,dni,nombre,apellido,email,telefono,estado) Values ('Chrispaa','33286489xd','41956008','Christian','Rodriguez','christiansrodriguez99@gmail.com','1145602785',1)
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
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria,idUsuario)values('Noteebook','Carasa','https://intermediary-i.linio.com/p/a3014bbef3ee5fe69bd771ea43f00e1f-product.jpg',12,10000,1,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,estado,idMarca,idCategoria,idUsuario)values('Deskotip','Baratita','https://http2.mlstatic.com/pc-de-escritorio-dell-i5-4gb-hd-1tb-win10-pro-vostro-oferta-para-uso-hogar-y-empresa-garantia-oficial-D_NQ_NP_895983-MLA31077531976_062019-O.webp',99,500,1,2,1,2)

select Count(nombreDeUsuario) from Usuarios where nombreDeUsuario = 'chrispa'
select clave from usuarios where nombreDeUsuario = 'chrispa'
select id from usuarios where nombreDeUsuario = 'chrispa' and clave = '33286489xd'
select * from Publicaciones
delete from Publicaciones
use master
go
drop database DB_TPC


