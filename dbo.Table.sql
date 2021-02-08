CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] DATETIME NULL, 
    [DailyPrice] SMALLMONEY NULL, 
    [Description] NVARCHAR(50) NULL
)
