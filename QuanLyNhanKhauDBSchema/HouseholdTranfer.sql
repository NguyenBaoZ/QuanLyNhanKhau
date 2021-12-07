CREATE TABLE [dbo].[HouseholdTranfer]
(
	[Id] INT NOT NULL,
    [FromBookID] INT NULL,
    [ToBookID] INT NULL, 
    [CitizenDetails] INT NULL, 
    [RequestBy] INT NOT NULL,
    [Approved] BIT NOT NULL DEFAULT 0,
    [ResolveDescription] NTEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    [Reason] NTEXT NULL, 
    [ExpiredDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    [CreatedDate] NCHAR(10) NULL DEFAULT GETDATE(), 
)
