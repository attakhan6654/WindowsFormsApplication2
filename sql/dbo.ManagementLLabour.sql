CREATE TABLE [dbo].[ManagementLLabour] (
    [LabourID]      INT        IDENTITY    NOT NULL,
    [LabourCNIC]    FLOAT (53)    NULL,
    [LabourName]    NVARCHAR (50) NULL,
    [LabourAddress] NVARCHAR (50) NULL,
    [LabourPhonen]  FLOAT (53)    NULL,
    [LabourPaidSalary]  FLOAT (53)    NULL, 
    CONSTRAINT [PK_ManagementLLabour] PRIMARY KEY ([LabourID]),
);

