CREATE TABLE [dbo].[UserDetails]
(
	[User_Id] INT NOT NULL Primary Key,
    [Address] NTEXT NULL, 
    [BirthDate] DATETIME NULL, 
    [CCCDId] CHAR(12) NULL, 
    [UpdatedAt] NCHAR(10) NULL, 
    CONSTRAINT [FK_UserDetails_Users] FOREIGN KEY (user_id) REFERENCES [Users]([Id])
)
