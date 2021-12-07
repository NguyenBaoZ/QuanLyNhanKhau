CREATE TABLE [dbo].[HouseholdBook]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Address] NTEXT NULL, 
    [CreateDate] DATETIME NULL DEFAULT GETDATE()
)
