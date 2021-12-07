CREATE TABLE [dbo].[Absence]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ExpiredDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    [CreatedDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    [Approved] BIT NOT NULL DEFAULT 0, 
    [Description] TEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    CONSTRAINT [FK_Absence_Users] FOREIGN KEY ([ResolveBy]) REFERENCES [Users]([Id])
)
