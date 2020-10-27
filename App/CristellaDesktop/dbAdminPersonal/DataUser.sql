CREATE TABLE [dbo].[DataUser]
(
	IdUser int primary key identity not null,
	UserName varchar(50) not null,
	UserPass varchar (50) not null,
)
