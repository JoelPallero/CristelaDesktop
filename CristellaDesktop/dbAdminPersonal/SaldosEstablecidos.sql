CREATE TABLE [dbo].[SaldosEstablecidos]
(
	[Id_SE] int primary key identity (1000, 1) not null,
	[SaldoEmergencia] decimal (18, 2)  null DEFAULT 0,
	[SaldoCritico] decimal (18, 2)  null DEFAULT 0,
	[GastoPermitido] decimal (18, 2)  null DEFAULT 0,
	[Fecha] datetime null DEFAULT 0,     
)
