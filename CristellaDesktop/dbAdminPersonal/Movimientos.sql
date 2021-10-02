CREATE TABLE [dbo].[Movimientos]
(
	[Id_Mov] INT NOT NULL PRIMARY KEY, 
    [Importe] DECIMAL(18, 2) NOT NULL, 
    [TipoMovimiento] VARCHAR(30) NOT NULL,
    [FechaRealizada] DATETIME NOT NULL,
    [NumCuotaPaga] INT not null,
    [CantCuotas] int not null,
    [Observaciones] nvarchar (200) null,
    [CodMovimiento] int null,
    [PagoFinalizado] varchar(2) not null, 
    [IdSe] INT not NULL,
    CONSTRAINT [FK_SaldosEstablecidos_Movimientos] FOREIGN KEY ([IdSe]) REFERENCES [SaldosEstablecidos]([Id_SE])
)