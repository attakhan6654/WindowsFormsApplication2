CREATE TABLE [dbo].[Contract] (
    [ContractorId]   INT           IDENTITY (1, 1) NOT NULL,
    [ContractorName] NVARCHAR (50) NULL,
    [SideId]         NVARCHAR (50) NULL,
    [DealAmount]     BIGINT        NULL,
    CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED ([ContractorId] ASC)
);

