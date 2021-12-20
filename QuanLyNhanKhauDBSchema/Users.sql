CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY  , 
    [Email] VARCHAR(30) NOT NULL, 
    [Password] VARCHAR(30) NOT NULL, 
    [Enable] BIT NOT NULL DEFAULT 1, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Role] VARCHAR(9) NULL DEFAULT 'MEMBER', 
    CONSTRAINT [CK_Users_Role] CHECK ([Role] in ('MEMBER','ADMIN','MODERATOR')),
)
GO

CREATE INDEX [Email_idx] ON [dbo].[Users]([Email]);
GO

