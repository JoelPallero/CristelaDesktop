create database AdministradorPersonal

use AdministradorPersonal

Create table Movimientos(
Id_Mov int primary key identity not null,
Importe decimal(18, 02) not null,
TipoMovimiento varchar(20) not null,
FechaRealizada DateTime not null,
NumCuotaPaga int not null,
CantCuotas int not null,
Observaciones nvarchar (200) null,
CodMovimiento int null,--acá se registra el Id_Mov para identificar los pagos divididos que provienen del mismo movimiento
check (TipoMovimiento in ('Agua', 
'Cobro', 
'Comida',
'Compra',
'Extraccion', 
'Gas', 
'Gasto Permitido',
'Luz', 
'Pago', 
'Sueldo',
'SuperMercado',
'Transferencia', 
'Venta dolares',
'Otros')),
check (CantCuotas in ('1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14',
'15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28', '29', '30',
'31', '32', '33', '34', '35', '36'))
)
go

create table SaldosEstablecidos(
Id_SE int primary key identity not null,
SaldoEmergencia decimal (18, 2)  null,
SaldoCritico decimal (18, 2)  null,
GastoPermitido decimal (18, 2)  null
)
go

create table Notas(
Id_Nota int primary key identity,
TituloNota nvarchar (50),
MsjNota nvarchar (200),
FechaNota datetime
)

Create table DataUser(
IdUser int primary key identity not null,
UserName varchar(50) not null,
UserPass varchar (50) not null,
)

----------------------------------------


exec sp_CargarTipoMovimientos

insert into Movimientos values ('1500', 'Pago', GETDATE(), 'No', '1', 'ASASAS', '1', '1750', '2000')

select SaldoActual from Movimientos
where Id_Mov = (select max (Id_Mov - 1) from Movimientos where Id_Mov > 1)
or (Id_Mov = (select max(Id_Mov) from Movimientos where Id_Mov <= 1))
go

select * from Movimientos 

select SaldoActual
From Movimientos
where Id_Mov = (select max(Id_Mov) from Movimientos where Id_Mov > 0)

Delete Movimientos where Id_Mov = 2

SET LANGUAGE ESPAÑOL
select * from Movimientos
where FechaCreacion >= 19/09/2020


truncate table Movimientos

select * from Movimientos 
select * from PagosAgendados

select * from Movimientos where AgendarPago = 'si' and CantCuotas > 1

insert into PagosAgendados
values  ('9', '22-10-2020')

insert into SaldosEstablecidos values (0, 0, 0)

select * from Movimientos


create proc sp_SaldoActualizado
as
select sum(Importe) as SumaTotal from Movimientos
where TipoMovimiento != 'Gasto Permitido'

execute sp_SaldoActualizado

select sum(Importe) as GastoPermitido 
from Movimientos
where TipoMovimiento = 'GastoPermitido'


SaldosEstablecidos  
where TipoMovimiento = 'GastoPermitido'
and FechaRealizada >= Fecha

create proc sp_GastoPermitido
as
declare @SumaTotal Decimal(18,2)
set @SumaTotal = (select sum(Importe) from Movimientos
where TipoMovimiento = 'Gasto Permitido')
if @SumaTotal is null
begin
set @SumaTotal = 0
end
select @SumaTotal as SumaTotal

execute sp_GastoPermitido


select * from Movimientos 


--usar  distintc para traer los movimientos con el Numcuota paga más alto y quitar los duplicados

select * from Movimientos where NumCuotaPaga < CantCuotas
and NumCuotaPaga like (select max(distinct NumCuotaPaga) from Movimientos where NumCuotaPaga < CantCuotas)

truncate table Movimientos