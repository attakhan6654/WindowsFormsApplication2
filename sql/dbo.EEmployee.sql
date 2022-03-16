CREATE TABLE [dbo].[EEmployee] (
    [EmpIds]            INT           IDENTITY (1, 1) NOT NULL,
    [EmpFNames]         NVARCHAR (50) NOT NULL,
    [EmpLNames]         NVARCHAR (50) NOT NULL,
    [EmpUserNames]      NVARCHAR (50) NOT NULL,
    [EmpAdds]           NVARCHAR (50) NOT NULL,
    [EmpPhones]         NVARCHAR (50) NOT NULL,
    [EmpCnics]          NVARCHAR (50) NOT NULL,
    [EmpEdus]           NVARCHAR (50) NOT NULL,
    [EmpExps]           NVARCHAR (50) NOT NULL,
    [EmpDobs]           NVARCHAR (50) NOT NULL,
    [EmpGens]           NVARCHAR (50) NOT NULL,
    [EmpEmerNos]        NVARCHAR (50) NOT NULL,
    [EmpBloodGroups]    NVARCHAR (50) NOT NULL,
    [EmpMartialStatuss] NVARCHAR (50) NOT NULL,
	[EmpSalary]       FLOAT (53)    NULL,
    CONSTRAINT [PK_EEmployee] PRIMARY KEY CLUSTERED ([EmpIds] ASC)
);

