CREATE TABLE [dbo].[user]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [telephone] INT NOT NULL, 
    [password] NVARCHAR(20) NOT NULL, 
    [name] NVARCHAR(30) NOT NULL, 
    [second_name] NVARCHAR(30) NOT NULL
)
