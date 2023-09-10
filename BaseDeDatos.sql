Create database Cooperativa3;
use Cooperativa3;
create table Asociados(
Identificacion nvarchar(50),
NombreCompleto nvarchar(200),
Telefono nvarchar(30),
Sinpe nvarchar(30),
Seccion nvarchar(20),
numeroAsociado nvarchar(30),
Correo nvarchar(200),
Calidad nvarchar(20)
);
create table AhorrosCorte(
	Identificacion nvarchar(50),
NombreCompleto nvarchar(200),
	totalAhorrado nvarchar(100),
	interes nvarchar(100),
	comision nvarchar(100),
	interesSubcuenta nvarchar(100),
	Correo nvarchar(200),
)
UPDATE AhorrosCorte
SET interesSubcuenta = '0';
create table Ahorros(
Identificacion nvarchar(20),
Ahorrado nvarchar(20),
Retirado nvarchar(20),
identificacionEncargado nvarchar(20),
Fecha nvarchar(20)
)
create table Inventario(
	Producto nvarchar(80),
	Cantidad nvarchar(15),
	Precio nvarchar(20),
	Fecha nvarchar(20)
)
create table Productos(
	Producto nvarchar(80),
	Cantidad nvarchar(15),
	Precio nvarchar(20),
	Fecha nvarchar(20)
)
create table Ventas(
	Producto nvarchar(80),
	Cantidad nvarchar(15),
	Fecha nvarchar(20)
)
create table ActivosFijos(
	descripcion nvarchar(30),
	marca nvarchar(20),
	modelo nvarchar(20),
	serie nvarchar(20),
	estado nvarchar(20),
	lugar nvarchar(20),
	fecha nvarchar(20)
)
create table Casillero(
NumeroCasillero nvarchar(20),
NombreCompleto nvarchar(200),
Seccion nvarchar(40),
recibo nvarchar(40),
tipoDeArrendamiento nvarchar(200),
costo nvarchar(40)
)
drop table Ahorros
use React;
select * from AhorrosCorte ;
alter Table Casillero drop Column Firma
-- Cambiar el nombre de la tabla de "Pruebas" a "NuevaPrueba"
EXEC sp_rename 'AhorrosCorte1', 'AhorrosCorte';
delete from AhorrosCorte where NombreCompleto = 'j'
update AhorrosCorte SET totalAhorrado='0',comision='0',interesSubcuenta='0';
select * from Asociados1;
update Ahorros set monto='2000'
EXEC sp_rename 'AhorrosCorte.interesesSubcuenta', 'interesSubcuenta', 'COLUMN';


INSERT INTO AhorrosCorte1(	Identificacion,
NombreCompleto,
	totalAhorrado,
	interes,
	comision,
	interesSubcuenta,
	Correo)
SELECT Identificacion,
NombreCompleto,
	totalAhorrado,
	interes,
	comision,
	interesSubcuenta,
	Correo
FROM AhorrosCorte ;

