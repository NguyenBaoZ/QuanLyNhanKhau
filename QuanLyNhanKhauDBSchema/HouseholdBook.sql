CREATE TABLE [dbo].[HouseholdBook]
(
	[BookId] INT NOT NULL PRIMARY KEY, 
    [Address] NTEXT NULL, 
    [CreateDate] DATETIME NULL DEFAULT GETDATE(), 
    [UpdateDate] DATETIME NULL DEFAULT GETDATE(), 
    [HouseHoldOwner] INT NOT NULL, 
    CONSTRAINT [FK_HouseholdBook_CitizenDetails] FOREIGN KEY ([HouseHoldOwner]) REFERENCES [CitizenDetails]([DetailId]) 
)
