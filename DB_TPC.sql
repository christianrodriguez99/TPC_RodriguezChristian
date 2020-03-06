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
estado bit not null ,
dinero money,
administrador bit
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
estadoProducto varchar(50) not null
)
go
create table Ventas(
id int primary key identity (1,1),
cantidad int not null,
idUsuarioVendedor int foreign key references Usuarios(id),
idUsuarioComprador int foreign key references Usuarios(id),
idPublicacion int foreign key references Publicaciones(id),
fecha datetime not null,
precioTotal money not null
)
go
create table Compras(
id int primary key identity (1,1),
cantidad int not null,
idUsuarioVendedor int foreign key references Usuarios(id),
idUsuarioComprador int foreign key references Usuarios(id),
idPublicacion int foreign key references Publicaciones(id),
fecha datetime not null,
precioTotal money not null
)
go
create table ComprasPendientes
(
id int primary key identity (1,1),
cantidad int not null,
preciototal money not null,
idPublicacion int foreign key references Publicaciones(id),
idUsuarioVendedor int foreign key references Usuarios(id),
idUsuarioComprador int foreign key references Usuarios(id),
fecha datetime not null,
)
go
create table MarcasPendientes
(
id int primary key identity(1,1),
nombre varchar(50) not null,
idUsuario int foreign key references Usuarios(id),
estado bit not null
)
go
create table CategoriasPendientes
(
id int primary key identity(1,1),
nombre varchar(50) not null,
idUsuario int foreign key references Usuarios(id),
estado bit not null
)
go
create table Notificaciones
(
id int primary key identity(1,1),
descripcion varchar(200) not null,
idUsuario int foreign key references Usuarios(id)
)
insert into Usuarios(nombreDeUsuario,clave,dni,nombre,apellido,email,telefono,estado,administrador) Values ('Chris','33286489xd','41956008','Christian','Rodriguez','christiansrodriguez99@gmail.com','1145602785',1,1)
go
insert into Usuarios(nombreDeUsuario,clave,dni,nombre,apellido,email,telefono,estado,administrador) Values ('Maxi','asd','41956008','Maxi','Profe','a@a.com','1145602785',1,1)
go
insert into Marcas(nombre,estado) Values ('HP',1)
go
insert into Marcas(nombre,estado) Values ('DELL',0)
go
insert into Marcas(nombre,estado) Values ('ACER',1)
go
insert into Marcas(nombre,estado) Values ('PHILCO',1)
go
insert into Marcas(nombre,estado) Values ('MOTOROLA',1)
go
insert into Categorias(nombre,estado) Values ('Notebook',1)
go
insert into Categorias(nombre,estado) Values ('Desktop',1)
go
insert into Categorias(nombre,estado) Values ('Heladera',1)
go
insert into Categorias(nombre,estado) Values ('Telefono',1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Notebook HP i5','Cara','https://intermediary-i.linio.com/p/a3014bbef3ee5fe69bd771ea43f00e1f-product.jpg',12,10000,1,1,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Desktop Dell i7','Barata','https://http2.mlstatic.com/pc-de-escritorio-dell-i5-4gb-hd-1tb-win10-pro-vostro-oferta-para-uso-hogar-y-empresa-garantia-oficial-D_NQ_NP_895983-MLA31077531976_062019-O.webp',99,500,2,2,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Notebook Dell i7','Impecable','https://http2.mlstatic.com/notebook-dell-inspiron-5584-i5-16g-2t-win-10-gforce-ram-ideal-para-juegos-y-diseno-D_NQ_NP_757148-MLA31351560646_072019-F.jpg',12,10000,1,1,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Notebook Acer','Flama','https://www.fullh4rd.com.ar/img/productos/notebook-acer-aspire3-celeron-4g-500-linux-1.jpg',99,500,3,1,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Heladera Philips con freezer','Carasa','https://hendel-r7d8odghj1.stackpathdns.com/media/catalog/product/cache/877042223109cc2bc0869ffe42af0ed8/3/4/34966-min.jpg',12,10000,3,1,1,1,1)
go
insert into Publicaciones (titulo,descripcion,urlimagen,stock,precio,idMarca,idCategoria,idUsuario,estado,estadoProducto)values('Celular Moto g5','Rapido','https://http2.mlstatic.com/celular-motorola-moto-g5-32gb-D_NQ_NP_749377-MLA31600204728_072019-O.webp',99,500,5,4,1,1,1)
select * from Usuarios
select * from Usuarios where nombreDeUsuario= 'chris'
--SELECT n.id,n.descripcion,u.nombreDeUsuario FROM notificaciones AS n inner join Usuarios as u on n.idUsuario=u.id where u.nombreDeUsuario = 'franca'
----select mp.id,mp.nombre,mp.estado,u.nombreDeUsuario from MarcasPendientes as mp inner join Usuarios as u on mp.idUsuario = u.id
--SELECT n.id,n.descripcion FROM Notificaciones AS n inner join Usuarios as u on n.id=u.id where n.id=u.id
--select Count(nombreDeUsuario) from Usuarios where nombreDeUsuario = 'chrispa'
--select Count(nombre) from MarcasPendientes where nombre = 'HP'
--select * from Marcas
--select cp.id,cp.cantidad,cp.fecha,cp.preciototal,p.id,p.titulo,uc.nombreDeUsuario,uc.id,uv.id from ComprasPendientes as cp inner join Publicaciones as p on cp.idPublicacion = p.id inner join Usuarios as uc on cp.idUsuarioComprador = uc.id inner join Usuarios as uv on cp.idUsuarioVendedor = uv.id
--select clave from usuarios where nombreDeUsuario = 'chrispa'
--select id from usuarios where nombreDeUsuario = 'chrispa' and clave = '33286489xd'
--select * from Publicaciones
--delete from Publicaciones
--SELECT p.titulo,p.descripcion,p.urlimagen,p.stock,p.precio,u.nombre FROM Publicaciones as p  inner join Usuarios as u on u.id = p.idUsuario where u.nombreDeUsuario = 'chrispa'
--SELECT v.cantidad,v.fecha,p.id,p.titulo,v.precioTotal,ve.id as idvendedor,c.id FROM Ventas as v  inner join Publicaciones as p on v.idPublicacion=p.id inner join Usuarios as ve on ve.id = v.idUsuarioVendedor inner join Usuarios as c on c.id = v.idUsuarioComprador where c.nombreDeUsuario = 'chrispa'
--SELECT c.cantidad,c.fecha,p.id,p.titulo,c.precioTotal,ve.id,co.id,ve.nombreDeUsuario FROM Compras as c  inner join Publicaciones as p on c.idPublicacion=p.id inner join Usuarios as ve on ve.id = c.idUsuarioVendedor inner join Usuarios as co on co.id = c.idUsuarioComprador where co.nombreDeUsuario = 'chrispa'
--SELECT v.cantidad,v.fecha,p.id,p.titulo,v.precioTotal,ve.id,c.id,c.nombreDeUsuario FROM Ventas as v  inner join Publicaciones as p on v.idPublicacion=p.id inner join Usuarios as ve on ve.id = v.idUsuarioVendedor inner join Usuarios as c on c.id = v.idUsuarioComprador where ve.nombreDeUsuario = 'franca'
--use master
--go
--drop database DB_TPC



