CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NCHAR(50) NOT NULL, 
    [Endereco] NCHAR(100) NOT NULL, 
    [Telefone] NCHAR(10) NOT NULL, 
    [Email] NCHAR(100) NULL
)
