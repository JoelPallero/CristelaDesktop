CREATE TABLE [dbo].[Notas]
(
	Id_Nota int primary key identity,
	TituloNota nvarchar (50),
	MsjNota nvarchar (200),
	FechaNota datetime
)
