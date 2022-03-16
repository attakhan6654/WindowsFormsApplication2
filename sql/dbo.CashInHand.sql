CREATE TABLE [dbo].[CashInHand] (
    [CIHID]         INT        IDENTITY (1, 1) NOT NULL,
    [TotalsAmount]  INT        NULL,
    [LabourPayment] FLOAT (53) NULL,
    [PerdayExpence] FLOAT (53) NULL,
    CONSTRAINT [PK_CashInHand] PRIMARY KEY CLUSTERED ([CIHID] ASC)
);

