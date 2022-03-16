CREATE TABLE [dbo].[InnCash] (
    [CIID]       INT           IDENTITY (1, 1) NOT NULL,
    [CashTotals] INT           NULL,
    [CashComes]  NVARCHAR (50) NULL,
    [CashNet]    FLOAT (53)    NULL,
    CONSTRAINT [PK_InnCash] PRIMARY KEY CLUSTERED ([CIID] ASC)
);

