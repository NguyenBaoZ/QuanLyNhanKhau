CREATE TABLE [dbo].[HouseholdBook]
(
	[BookId] INT NOT NULL , 
    [Address] NTEXT NULL, 
    [CreateDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdateDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Owner] INT NOT NULL , 
    CONSTRAINT [FK_HouseholdBook_CitizenDetails] FOREIGN KEY ([Owner]) REFERENCES [CitizenDetails]([DetailId]), 
    CONSTRAINT [PK_HouseholdBook] PRIMARY KEY ([BookId]), 
    CONSTRAINT [AK_HouseholdBook_Owner] UNIQUE ([Owner]) 
)
