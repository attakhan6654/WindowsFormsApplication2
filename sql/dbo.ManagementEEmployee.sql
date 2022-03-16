CREATE TABLE [dbo].[ManagementEEmployee] (
    [EmpId]           INT           IDENTITY (1, 1) NOT NULL,
    [EmpFName]        NVARCHAR (50) NULL,
    [EmpLName]        NVARCHAR (50) NULL,
    [EmpUserName]     NVARCHAR (50) NULL,
    [EmpAdd]          NVARCHAR (50) NULL,
    [EmpWorkingPlace] NVARCHAR (50) NULL,
    [EmpEducation]    NVARCHAR (50) NULL,
    [EmpPaidSalary]   FLOAT (53)    NULL,
    [EmpCnic]         NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_ManagementEEmployee] PRIMARY KEY ([EmpId])
);

