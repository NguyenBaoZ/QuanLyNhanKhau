CREATE TABLE [dbo].[CitizenDetails]
(
    [DetailId] INT  NOT NULL IDENTITY,
	[User_Id] INT NULL,
    [Address] NTEXT NOT NULL, 
    [BirthDate] DATETIME NOT NULL, 
    [CCCDId] CHAR(12) NULL , 
    [UpdatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Gender] VARCHAR(5) NOT NULL DEFAULT 'MALE', 
    [Name] NCHAR(10) NOT NULL, 
    [CCCDProvideAddress] NTEXT NOT NULL, 
    [CCCDProvideDate] DATETIME NOT NULL, 
    [CCCDProvideUrgent] NCHAR(20) NOT NULL, 
    [Phone] NCHAR(10) NOT NULL, 
    [ContactEmail] NCHAR(30) NOT NULL, 

    CONSTRAINT [FK_CitizenDetails_Users] FOREIGN KEY ([User_Id]) REFERENCES [Users]([Id]), 
    CONSTRAINT [CK_CitizenDetails_Gender] CHECK ([Gender] in ('MALE','FEMALE')), 
    CONSTRAINT [AK_CtitizenDetails_CCCDId] UNIQUE ([CCCDId]), 
    CONSTRAINT [PK_CtitizenDetails] PRIMARY KEY ([DetailId])
)
GO

