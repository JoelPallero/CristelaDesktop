CREATE PROCEDURE [dbo].[sp_SiguienteCuota]
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