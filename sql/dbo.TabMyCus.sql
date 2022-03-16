CREATE TABLE [dbo].[TabMyCus] (
    [IDCus]      INT           IDENTITY (1, 1) NOT NULL,
	[CnicCus]    FLOAT NULL,
    [NameCus]    NVARCHAR (50) NULL,
    [AddressCus] NVARCHAR (50) NULL,
    [PhoneCus]   FLOAT (53)    NULL,
    CONSTRAINT [PK_TabMyCus] PRIMARY KEY CLUSTERED ([IDCus] ASC)
);

