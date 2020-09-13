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

--Creamos la tabla ususarios, en  la base de datos de Sales Point
create table Users (
    UserID INT NOT NULL IDENTITY(1,1),
    UserName nvarchar(128) not null,
    Password nvarchar(128) not null,
    Email nvarchar(128)
	constraint PK_tblUsers primary key (UserID)
)
--Insertamos Usuarios base en la tabla Usuarios
INSERT INTO Users 
    (UserName,Password,Email) 
VALUES 
    ('Good','Salespointdev123...','good@salespoint.com.mx'),
	('Admin','Salespointdev123...','admin@salespoint.com.mx'),
	('Vendor','Salespointdev123...','vendor@salespoint.com.mx');

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

 --Select *from UserRoles

/*alter table UserRoles with check add constraint FK_UserRoles_Roles 
foreign key (RoleID) references Roles (RoleID)

alter table UserRoles with check add constraint FK_UserRoles_Users 
foreign key (UserID) references Users (UserID)*/










 