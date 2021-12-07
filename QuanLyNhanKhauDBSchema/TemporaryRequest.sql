CREATE TABLE [dbo].[TemporaryRequest]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [RequestBy] INT NOT NULL,
    [Approved] BIT NOT NULL DEFAULT 0, 
    [ResolveDescription] NTEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    [Reason] NTEXT NULL, 
    [ExpiredDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    [CreatedDate] NCHAR(10) NULL DEFAULT GETDATE(), 
    [RequestType] CHAR(10) null default 'TEMPORARY_ABSENCE',
    CONSTRAINT [FK_TemporaryRequest_RequestBy] FOREIGN KEY ([RequestBy]) REFERENCES [CitizenDetails]([DetailId]), 
    CONSTRAINT [FK_TemporaryRequest_ResolveBy] FOREIGN KEY ([ResolveBy]) REFERENCES [Users]([Id]), 
    CONSTRAINT [CK_TemporaryRequest_RequestType] CHECK ([RequestType] in ('TEMPORARY_ABSENCE','TEMPORATE_CITIZEN'))
)
