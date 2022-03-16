CREATE TABLE [dbo].[TabMyInfo] (
    [IDInfo]      INT           NOT NULL,
    [NameInfo]    NVARCHAR (50) NULL,
    [AddressInfo] NVARCHAR (50) NULL,
    [AgeInfo]     FLOAT (53)    NULL,
    CONSTRAINT [PK_TabMyInfo] PRIMARY KEY CLUSTERED ([IDInfo] ASC)
);

