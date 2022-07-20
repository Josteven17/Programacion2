create database Examens2db

create table Clientes
(
	Factura int identity(1,1),
	cedula varchar(20) primary key,
	Nombre varchar(50) not null,
	Telefono varchar(15) not null,
	Direccion varchar(50) not null,
	Costo money,
	Descuento money,
	Subtotal money,
	Iva money,
	Total money,

)

create proc sp_guardar

@nombre varchar(50),
@cedula varchar(20),
@telefono varchar(15),
@direccion varchar(50),
	as
	begin 
	insert into Clientes (Nombre,Cedula,Telefono,Direccion)
	values(@nombre, @cedula, @telefono, @direccion)
	end



