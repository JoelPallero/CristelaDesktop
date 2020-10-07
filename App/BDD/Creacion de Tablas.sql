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
PagoAgendado varchar(2) not null,
PagoFinalizado varchar(2) not null,
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

create proc sp_PagosAgendados
as
begin
Select * from Movimientos 
Where PagoFinalizado = 'No' and NumCuotaPaga < CantCuotas
and NumCuotaPaga = (select max(Id_Mov) from Movimientos)
Order by FechaRealizada desc
end

exec sp_PagosAgendados
Delete Movimientos where Id_Mov = 6


Select * from Movimientos 
where PagoFinalizado = 'no'
and NumCuotaPaga < CantCuotas

Order by FechaRealizada desc

select Importe, TipoMovimiento, FechaRealizada, NumCuotaPaga, CantCuotas, max(NumCuotaPaga), Observaciones 
from Movimientos 
where PagoFinalizado = 'no'
and NumCuotaPaga < CantCuotas
and NumCuotaPaga = (select max(NumCuotaPaga) from Movimientos)
Group by Importe, TipoMovimiento, FechaRealizada, NumCuotaPaga, CantCuotas, NumCuotaPaga, Observaciones 
Order by FechaRealizada desc

WITH siguiente_cuota AS(
    SELECT *, ROW_NUMBER() OVER( PARTITION BY ISNULL( CodMovimiento, Id_Mov) ORDER BY NumCuotaPaga DESC) rn
    FROM Movimientos
    WHERE PagoFinalizado = 'No'
    AND NumCuotaPaga < CantCuotas
)
SELECT *
FROM Movimientos
WHERE rn = 1;


delete movimientos where Id_Mov = 1010