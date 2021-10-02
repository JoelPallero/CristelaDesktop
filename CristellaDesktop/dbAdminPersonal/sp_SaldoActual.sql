CREATE PROCEDURE [dbo].[sp_SaldoActual]
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
