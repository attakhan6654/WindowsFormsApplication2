CREATE TABLE [dbo].[TabMyUse] (
    [UserID]      INT       IDENTITY    NOT NULL,
    [FNameUse]    NVARCHAR (50) NULL,
    [LNameUse]    NVARCHAR (50) NULL,
    [NameUse]     NVARCHAR (50) NULL,
    [PasswordUse] NVARCHAR (50) NULL,
    [PhoneUse]    FLOAT (53)    NULL,
    [CnicUse]     NVARCHAR (50) NULL,
    [TypeUse]     NVARCHAR (50) NULL, 
    CONSTRAINT [PK_TabMyUse] PRIMARY KEY ([UserID])
);

