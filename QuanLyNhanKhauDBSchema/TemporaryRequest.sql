CREATE TABLE [dbo].[TemporaryRequest]
(
	[RequestId] INT IDENTITY(1,1) NOT NULL ,
    [RequestBy] INT NOT NULL,
    [Reason] NTEXT NULL, 
    [Approved] VARCHAR(10) NOT NULL DEFAULT 'UNAPPROVED', 
    [ResolveDescription] NTEXT NULL, 
    [ResolveBy] INT NOT NULL, 
    [ExpiredDate] DATETIME NULL DEFAULT GETDATE(), 
    [CreatedDate] DATETIME NULL DEFAULT GETDATE(), 
    [RequestType] CHAR(10) null default 'TEMPORARY_ABSENCE',
    CONSTRAINT [FK_TemporaryRequest_RequestBy] FOREIGN KEY ([RequestBy]) REFERENCES [CitizenDetails]([DetailId]), 
    CONSTRAINT [FK_TemporaryRequest_ResolveBy] FOREIGN KEY ([ResolveBy]) REFERENCES [Users]([Id]), 
    CONSTRAINT [CK_TemporaryRequest_RequestType] CHECK ([RequestType] in ('TEMPORARY_ABSENCE','TEMPORATE_CITIZEN')),
    CONSTRAINT [CK_TemporaryRequest_Approved] CHECK ([Approved] in ('UNAPPROVED','APPROVED','DENY')), 
    CONSTRAINT [PK_TemporaryRequest] PRIMARY KEY ([RequestId])
)
