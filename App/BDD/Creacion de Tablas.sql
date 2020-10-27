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
CodMovimiento int null,
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
GastoPermitido decimal (18, 2)  null,
Fecha datetime null
)
go

create table Notas(
Id_Nota int primary key identity,
TituloNota nvarchar (50),
MsjNota nvarchar (200),
FechaNota datetime
)
go
Create table DataUser(
IdUser int primary key identity not null,
UserName varchar(50) not null,
UserPass varchar (50) not null
)


create table NotificacionesDiarias(
Id int primary Key identity,
HoraAlarma1 varchar(2) null,
MinutoAlarma1 varchar(2) null,
HoraAlarma2 varchar(2) null,
MinutoAlarma2 varchar(2) null,
HoraAlarma3 varchar(2) null,
MinutoAlarma3 varchar(2) null
)

create proc sp_SiguienteCuota
as
begin
WITH siguiente_cuota AS(
    SELECT *, ROW_NUMBER() OVER( PARTITION BY ISNULL( CodMovimiento, Id_Mov) ORDER BY NumCuotaPaga DESC) rn
    FROM Movimientos
	where CantCuotas > 1
	and NumCuotaPaga = (select max(NumCuotaPaga) from Movimientos)
	and NumCuotaPaga != CantCuotas
)
SELECT *
FROM siguiente_cuota
WHERE rn = 1
end

create procedure sp_SaldoActual
as
begin
declare @SumaTotal Decimal
declare @PermitidoTotal Decimal
set @SumaTotal = (select sum(Importe) from Movimientos
where TipoMovimiento != 'Gasto Permitido')
set @PermitidoTotal = (select sum(Importe) from Movimientos mov
where TipoMovimiento = 'Gasto Permitido' and mov.FechaRealizada >= 
(select Fecha from SaldosEstablecidos where Fecha = (select max(Fecha) from SaldosEstablecidos)))
if @SumaTotal is null
begin
set @SumaTotal = 0
end
if @PermitidoTotal is null
begin
set @PermitidoTotal = 0
end
select @SumaTotal as SumaSaldo, @PermitidoTotal as SumaPermitido
end
