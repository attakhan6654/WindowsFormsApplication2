CREATE TABLE [dbo].[OutCash] (
    [COID]       INT           IDENTITY (1, 1) NOT NULL,
    [CashTotals] INT           NULL,
    [CashGos]    NVARCHAR (50) NULL,
    [CashNets]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_OutCash] PRIMARY KEY CLUSTERED ([COID] ASC)
);

