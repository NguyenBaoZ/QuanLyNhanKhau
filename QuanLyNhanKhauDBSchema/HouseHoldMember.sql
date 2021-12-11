CREATE TABLE [dbo].[HouseHoldMember]
(
	[BookId] INT NOT NULL, 
    [CitizenId] INT NOT NULL, 
    CONSTRAINT [PK_HouseHoldMember] PRIMARY KEY ([BookId],[CitizenId]), 
)