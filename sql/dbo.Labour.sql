CREATE TABLE [dbo].[Labour] (
    [LabourID]         INT           IDENTITY (1, 1) NOT NULL,
    [LabourCNIC]       FLOAT (53)    NULL,
    [LabourName]       NVARCHAR (50) NULL,
    [LabourAddress]    NVARCHAR (50) NULL,
    [LabourPhonen]     FLOAT (53)    NULL,
    [LabourSalary] FLOAT (53)    NULL,
    CONSTRAINT [PK_Labour] PRIMARY KEY CLUSTERED ([LabourID] ASC)
);

