CREATE TABLE [dbo].[TabMyInv] (
    [IDInv]      INT           NOT NULL,
    [NameInv]    NVARCHAR (50) NOT NULL,
    [CompanyInv] NVARCHAR (50) NOT NULL,
    [PhoneInv]   FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_TabMyInv] PRIMARY KEY CLUSTERED ([IDInv] ASC)
);

