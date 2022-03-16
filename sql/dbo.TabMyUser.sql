CREATE TABLE [dbo].[TabMyUser] (
    [UserID]       INT           IDENTITY (1, 1) NOT NULL,
    [NameUser]     NVARCHAR (50) NULL,
    [PasswordUser] NVARCHAR (50) NULL,
    [Name]         NVARCHAR (50) NULL,
    [UserPic]      IMAGE         NULL,
    CONSTRAINT [PK_TabMyUser] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

