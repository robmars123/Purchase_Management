CREATE TABLE [dbo].[Departments] (
    [DepartmentID]   INT           IDENTITY (1, 1) NOT NULL,
    [DepartmentName] NVARCHAR (50) NULL,
    CONSTRAINT [Departments$PrimaryKey] PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);

