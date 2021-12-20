CREATE TABLE [dbo].[HouseHoldMember]
(
	[BookId] INT NOT NULL, 
    [CitizenId] INT NOT NULL, 
    CONSTRAINT [FK_HouseHoldMember_BookID] FOREIGN KEY ([BookID]) REFERENCES [HouseholdBook]([BookId]), 
    CONSTRAINT [FK_HouseHoldMember_CitizenId] FOREIGN KEY ([CitizenId]) REFERENCES [CitizenDetails]([DetailId]),
)