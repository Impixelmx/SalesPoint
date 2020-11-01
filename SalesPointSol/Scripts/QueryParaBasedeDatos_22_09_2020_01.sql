--Usamos Master Para Comenzar
USE master ;
	GO
--Creamos la base de datos
CREATE DATABASE SalesPoint
	GO
--Seleccionamos la base de datos que acabamoss de crear
USE
	SalesPoint
GO
--Tabla categoría
CREATE TABLE Categoria(
       IdCategoria INT primary key NOT NULL IDENTITY(1,1),
       Nombre varchar(50) not null unique,
       Descripcion varchar(256) null,
       Estado bit default(1)	 
)
INSERT Categoria 
	(nombre,descripcion) 
VALUES 	
	('PAPELES EXTENDIDOS','Cartulina,Papel China, Papel Crepe, Papel Contac, Papel Cascaron, Papel Bond,Papel T.CARTA'),
	('ARTÍCULOS DE ESCRITURA','Boligrafos, Lapices, Crayones, Lapices de Colores,Marcatextos'),
	('LIBRETAS Y CUADERNOS','Libreta Profesional, Cuaderno F.Italiana,Cuaderno F.Francesa,Libreta Francesa, Libreta de Tareas, Libretas Contables'), 
	('ARTíCULOS DE OFICINA','Tijeras, Clips, Grapas, Engrapadoras,Recopiladores,Perforadoras,Pizarrones'),
	('PINTURAS Y CRAYONES','Pintura Escolar,Pintura Acrilica, Crayones, Acuarelas ,Pintura Dactilar, Pintura Digital'), 
	('ARTíCULOS ESCOLARES','Sacapuntas, Sellos Didacticos, Pegamento Escolar, Lapiz Adhesivo, Adornos Escolares, Material Didactico');
--select * from categoria;
GO
--Tabla artículo
CREATE TABLE Articulo(
       IdArticulo int IDENTITY(1,1) PRIMARY KEY,
       IdCategoria integer not null,
	   Imagen image NULL,
       Codigo varchar(50) null,
       Nombre varchar(100) not null,
	   Descripcion varchar(256) null, 
	   Marca varchar(100) not null,
       PrecioCompra decimal(11,2) not null,
       PrecioVenta decimal(11,2) not null,
       Stock integer not null,
	   StockMinimo integer not null,
	   AvisoStockMinimo varchar(50) null,       
       Codigobarras varchar(13) null,
       Estatus bit default(1), 
       FOREIGN KEY (IdCategoria) REFERENCES Categoria (IdCategoria)
)
INSERT INTO Articulo
	(IdCategoria, Imagen, Codigo, Nombre,Descripcion,Marca, PrecioCompra, PrecioVenta, Stock,StockMinimo, AvisoStockMinimo, Codigobarras,Estatus)
VALUES
	(1, '','PA0001', 'Cartulina Blanca', 'Cartulinas Blanca 50 X 65 cm 150 g/m2', 'Carvajal',1.26, 2.00,10, 5,'El estock es minimo 5', '1234567890400',1),
	(2, '','PA0002', 'Boligrafo Punto Mediano', 'Bic punto mediano, en color Negro Azul y Rojo', 'Bic',4, 6,10, 5,'El estock es minimo 5', '1234567890400',1),
	(3, '','PA0003', 'Libreta Frances', ' Scribe raya', 'Scribe',1.26, 2.00,10, 5,'El estock es minimo 5', '1234567890400',1),
	(4, '','PA0004', 'Tijera Escolar', 'corte perfecto Ideal para negocio', 'Pekes',1.26, 2.00,10, 5,'El estock es minimo 5', '1234567890400',1),
	(5, '','PA0005', 'Crayola', 'corte perfecto Ideal para negocio', 'Vividel',1.26, 2.00,10, 5,'El estock es minimo 5', '1234567890400',1),
	(6, '','PA0006', 'Sacapuntas Economico', '*Escolares muy económicos Excelente filo *modelos y colores surtidos', 'Smarty',1.26, 2.00,10, 5,'El estock es minimo 5', '1234567890400',1);
GO	 
--Tabla persona
CREATE TABLE Persona(
       IdPersona int IDENTITY(1,1) PRIMARY KEY,
       TipoPersona varchar(20) not null,
       Nombre varchar(100) not null,
       TipoDocumento varchar(20) null,
       NumDocumento varchar(20) null,
       Direccion varchar(70) null,
       Telefono varchar(20) null,
       Email varchar(50) null
)
INSERT INTO Persona
	(TipoPersona, Nombre, TipoDocumento,NumDocumento, Direccion, Telefono, Email)
VALUES
	('Cliente','Julio','Nota','0001','367 Addison Avenue, Palo Alto','(650) 497-8596.','a@dev.com.mx');


GO
--Creamos la tabla ususarios, en  la base de datos de Sales Point
create table Users (
    UserID INT NOT NULL IDENTITY(1,1),
    UserName nvarchar(128) not null,
    Password nvarchar(128) not null,
    Email nvarchar(128),	
	Birthday date not null,
    Language  nvarchar(150) not null,
	constraint PK_tblUsers primary key (UserID)
)
--Insertamos Usuarios base en la tabla Usuarios
INSERT INTO Users 
    (UserName,Password,Email,Birthday,Language) 
VALUES 
    ('Good','Salespointdev123...','good@salespoint.com.mx','1990-07-29T18:10:00','Español'),
	('Admin','Salespointdev123...','admin@salespoint.com.mx','1990-07-29T18:10:00','Español'),
	('Vendor','Salespointdev123...','vendor@salespoint.com.mx','1990-07-29T18:10:00','Español');

--Select *from Users*/

--A pesar de que esta comentado podemos usarlo para poder ver las afectaciones de la tabla  
 
	GO
--Creamos la tabla de roles de usuario 

create table Roles (
   RoleID INT NOT NULL IDENTITY(1,1),
   RoleName nvarchar(50)
   constraint PK_tblRoles primary key (RoleID)
)
--Insertamos roles bases 
INSERT INTO Roles 
    (RoleName) 
VALUES 
    ('Good'),
	('Admin'),
	('Vendor');
--Select *from Roles

--A pesar de que esta comentado podemos usarlo para poder ver las afectaciones de la tabla  
-- se crea una tabla de clases de relación intermedia. Esta tabla se utiliza para asignar las 
--asociaciones entre los objetos de origen y de destino

	GO
--Creamos la tabla union de usuarios y roles
create table UserRoles (
    UserID int,
    RoleID int, 
	foreign key (UserID) references Users (UserID),
	foreign key (RoleID) references Roles (RoleID),
)

GO

 --Select *from UserRoles

/*alter table UserRoles with check add constraint FK_UserRoles_Roles 
foreign key (RoleID) references Roles (RoleID)

alter table UserRoles with check add constraint FK_UserRoles_Users 
foreign key (UserID) references Users (UserID)*/

--Tabla ingreso
create table Ingreso(
       IdIngreso integer primary key IDENTITY(1,1),
       IdProveedor integer not null,
       UserID integer not null,
       TipoComprobante varchar(20) not null,
       SerieComprobante varchar(7) null,
       NumeroComprobante varchar (10) not null,
       Fecha datetime not null,
       Impuesto decimal (4,2) not null,
       Total decimal (11,2) not null,
       Estatus varchar(20) not null,
       FOREIGN KEY (IdProveedor) REFERENCES Persona (IdPersona),
       FOREIGN KEY (UserID) REFERENCES Users (UserID)
)
 
GO

--Tabla detalle_ingreso
create table DetalleIngreso(
       IdDetalleIngreso integer primary key IDENTITY(1,1),
       IdIngreso integer not null,
       IdArticulo integer not null,
       Cantidad integer not null,
       precio decimal(11,2) not null,
       FOREIGN KEY (IdIngreso) REFERENCES Ingreso (IdIngreso) ON DELETE CASCADE,
       FOREIGN KEY (IdArticulo) REFERENCES Articulo (IdArticulo)
)

GO	
--Tabla venta
create table Venta(
       IdVenta integer primary key IDENTITY(1,1),
       IdCliente integer not null,
       UserID integer not null,
       TipoComprobante varchar(20) not null,
       SerieComprobante varchar(7) null,
       NumeroComprobante varchar (10) not null,
       FechaHora datetime not null,
       Impuesto decimal (4,2) not null,
       Total decimal (11,2) not null,
       Estado varchar(20) not null,
       FOREIGN KEY (idcliente) REFERENCES persona (idpersona),
       FOREIGN KEY (UserID) REFERENCES Users (UserID)
)

GO

--Tabla detalle_venta
create table DetalleVenta(
       IdDetalleVenta integer primary key IDENTITY(1,1),
       IdVenta integer not null,
       IdArticulo integer not null,
       Cantidad integer not null,
       Precio decimal(11,2) not null,
       Descuento decimal(11,2) not null,
       FOREIGN KEY (IdVenta) REFERENCES venta (IdVenta) ON DELETE CASCADE,
       FOREIGN KEY (IdArticulo) REFERENCES articulo (IdArticulo)
);
