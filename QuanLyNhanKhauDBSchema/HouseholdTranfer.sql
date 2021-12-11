CREATE TABLE [dbo].[HouseholdTranfer]
(
	[TranferId] INT NOT NULL,
    [FromAddress] NTEXT NULL,
    [ToAddress] NTEXT NOT NULL, 
    [BookId] INT NOT NULL, 
    [Approved] CHAR(10) NOT NULL DEFAULT 'UNAPPROVED', 
    [ResolveDescription] NTEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    [Reason] NTEXT NULL, 
    [CreatedDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_HouseholdTranfer_HouseholdBook] FOREIGN KEY ([BookId]) REFERENCES [HouseholdBook]([BookId]), 
    CONSTRAINT [CK_HouseholdTranfer_Approved] CHECK ([Approved] in ('UNAPPROVED','APPROVED','DENY')), 
    CONSTRAINT [PK_HouseholdTranfer] PRIMARY KEY ([TranferId])
)
