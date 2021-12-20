CREATE TABLE [dbo].[HouseholdTranfer]
(
	[TranferId] INT IDENTITY(1,1) NOT NULL,
    [FromAddress] NTEXT NULL,
    [ToAddress] NTEXT NOT NULL, 
    [BookId] INT NOT NULL, 
    [Approved] VARCHAR(10) NOT NULL DEFAULT 'UNAPPROVED', 
    [ResolveDescription] NTEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    [Reason] NTEXT NULL, 
    [CreatedDate] DATETIME NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_HouseholdTranfer_HouseholdBook] FOREIGN KEY ([BookId]) REFERENCES [HouseholdBook]([BookId]),
    CONSTRAINT [FK_HouseholdTranfer_ResolveBy] FOREIGN KEY ([ResolveBy]) REFERENCES [Users]([Id]),
    CONSTRAINT [CK_HouseholdTranfer_Approved] CHECK ([Approved] in ('UNAPPROVED','APPROVED','DENY')), 
    CONSTRAINT [PK_HouseholdTranfer] PRIMARY KEY ([TranferId])
)