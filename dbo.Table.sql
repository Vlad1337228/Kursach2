CREATE TABLE [dbo].[auto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [company] NCHAR(20) NOT NULL, 
    [mark] NCHAR(20) NOT NULL, 
    [relise] DATETIME NOT NULL, 
    [hourse_power] INT NOT NULL, 
    [transmission] NCHAR(3) NOT NULL, 
    [new_or_old] NCHAR(10) NULL, 
    [price] INT NULL, 
    [city] NCHAR(30) NULL
)
