CREATE DATABASE PortLogDB
GO

SET DATEFORMAT dmy
GO

USE PortLogDB
GO

CREATE TABLE Cliente (
	id int identity(1,1) not null,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	Cedula nvarchar(8) not null,
	constraint PK_idCliente primary key (id)
)

CREATE TABLE Producto (
	id int identity(1,1) not null,
	Codigo nvarchar(10) unique not null,
	Nombre varchar(50) not null,
	PesoPorUnidad int not null,
	idCliente int not null, 
	constraint PK_idProducto primary key (id),
	constraint FK_idClienteProducto foreign key (idCliente) references Cliente(id) 
)



CREATE TABLE Importacion (
	id int identity(1,1) not null,
	FechaIngreso datetime not null,
	FechaPrevSalida datetime not null,
	FechaSalida datetime null,
	idProducto int not null,
	CantidadUnidades int not null,
	PrecioUnitario int not null,
	constraint FK_idProductoImportacion foreign key (idProducto) references Producto(id)
)
drop table Usuario
CREATE TABLE Usuario (
	id int identity(1,1) not null,
	Cedula varchar(8) not null,
	Contraseña varchar(15) not null,
	Rol varchar(10) not null,
	constraint PK_idUsuario primary key (id)
)

SET ansi_warnings OFF


INSERT INTO Usuario
VALUES ('1', 'uno', 'admin')

INSERT INTO Cliente VALUES 
('Jane', 'Brannigan', 3777699),
('Norah', 'Paddy', 5943563),
('Osmond', 'Meikle', 4086478),
('Walsh', 'Jenny', 3964251),
('Ferd', 'Vandrill', 5659606),
('Con', 'Gotecliffe', 4320280),
('Hinda', 'Molfino', 5774515),
('Jess', 'Lunbech', 5077227),
('Cyndie', 'Scough', 5882524),
('Teodora', 'Portch', 5461581)


INSERT INTO Producto VALUES 
 ('PC467', 'Gatorade - Orange', 74, 6),
 ('PC576', 'Dry Ice', 111, 10),
 ('PC428', 'Pear - Prickly', 155, 7),
 ('PC308', 'Rum - White', 92, 6),
 ('PC258', 'Blouse / Shirt / Sweater', 139, 10),
 ('PC470', 'Tendrils - Baby Pea, Organic', 148, 7),
 ('PC642', 'Ezy Change Mophandle', 98, 10),
 ('PC275', 'Juice - V8 Splash', 55, 9),
 ('PC846', 'Coriander - Ground', 168, 5),
 ('PC281', 'Cup Translucent', 98, 1),
 ('PC401', 'Cheese - Brick With Onion', 26, 1),
 ('PC821', 'Nut - Pecan, Pieces', 172, 9),
 ('PC430', 'Soup Campbells - Italian Wedding', 157, 8),
 ('PC994', 'Compound - Pear', 145, 5),
 ('PC218', 'Chicken - Thigh, Bone In', 162, 8),
 ('PC923', 'Wine - Tio Pepe Sherry Fino', 107, 3),
 ('PC189', 'Rice - 7 Grain Blend', 191, 2),
 ('PC667', 'Alize Sunset', 195, 9),
 ('PC566', 'Pastry - French Mini Assorted', 64, 10),
 ('PC591', 'Vinegar - Raspberry', 31, 5),
 ('PC793', 'Quail - Whole, Bone - In', 111, 1),
 ('PC323', 'Jagermeister', 132, 4),
 ('PC864', 'Lemon Pepper', 106, 9),
 ('PC689', 'Lamb - Sausage Casings', 73, 7),
 ('PC778', 'Transfer Sheets', 16, 3),
 ('PC964', 'Sherry - Dry', 196, 10),
 ('PC918', 'Frangelico', 150, 8),
 ('PC472', 'Momiji Oroshi Chili Sauce', 69, 7),
 ('PC421', 'Broom Handle', 179, 6),
 ('PC143', 'Wine - Riesling Dr. Pauly', 77, 7),
 ('PC773', 'Wine - Red, Lurton Merlot De', 137, 10),
 ('PC573', 'Wanton Wrap', 189, 5),
 ('PC193', 'Drambuie', 88, 7),
 ('PC883', 'Appetizer - Lobster Phyllo Roll', 128, 5),
 ('PC375', 'Potato - Sweet', 31, 7),
 ('PC561', 'Beef Tenderloin Aaa', 41, 6),
 ('PC184', 'Puree - Strawberry', 67, 10),
 ('PC298', 'Oil - Truffle, Black', 28, 3),
 ('PC319', 'Mackerel Whole Fresh', 180, 7),
 ('PC109', 'Gelatine Powder', 173, 7),
 ('PC138', 'Cheese - Augre Des Champs', 200, 1),
 ('PC847', 'Pastry - Baked Cinnamon Stick', 92, 1),
 ('PC990', 'Chicken - Leg, Fresh', 29, 5),
 ('PC850', 'Cheese - Fontina', 153, 3),
 ('PC301', 'V8 - Tropical Blend', 139, 8)

INSERT INTO Importacion VALUES
('11/04/2020', '13/05/2020', '01/05/2020', 24, 889, 124),
('28/04/2020', '08/05/2020', null, 34, 118, 127),
('22/04/2020', '02/05/2020', null, 24, 869, 65),
('01/04/2020', '04/05/2020', '16/05/2020', 22, 673, 25),
('11/04/2020', '02/05/2020', '05/05/2020', 29, 365, 33),
('09/04/2020', '13/05/2020', '30/05/2020', 42, 896, 160),
('07/04/2020', '13/05/2020', null, 8, 821, 171),
('07/04/2020', '13/05/2020', null, 10, 949, 58),
('27/04/2020', '12/05/2020', null, 33, 131, 133),
('02/04/2020', '04/05/2020', '17/05/2020', 42, 895, 24)


SELECT * FROM Cliente
SELECT * FROM Producto
SELECT * FROM Importacion
SELECT * FROM Usuario
