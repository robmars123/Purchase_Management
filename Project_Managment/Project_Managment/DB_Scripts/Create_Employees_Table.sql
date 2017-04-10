CREATE TABLE [dbo].[Employees] (
    [EmployeeID]     INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [LastName]       NVARCHAR (50) NULL,
    [OfficeLocation] NVARCHAR (20) DEFAULT ('87th Street') NULL,
    [GroupID]        INT           NULL,
    [DepartmentID]   INT           NULL,
    CONSTRAINT [Employees$PrimaryKey] PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    CONSTRAINT [SSMA_CC$Employees$FirstName$disallow_zero_length] CHECK (len([FirstName])>(0)),
    CONSTRAINT [SSMA_CC$Employees$LastName$disallow_zero_length] CHECK (len([LastName])>(0)),
    CONSTRAINT [SSMA_CC$Employees$OfficeLocation$disallow_zero_length] CHECK (len([OfficeLocation])>(0))
);


GO
CREATE NONCLUSTERED INDEX [Employees$LastName]
    ON [dbo].[Employees]([LastName] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[EmployeeID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'COLUMN', @level2name = N'EmployeeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[FirstName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'COLUMN', @level2name = N'FirstName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[LastName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'COLUMN', @level2name = N'LastName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[OfficeLocation]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'COLUMN', @level2name = N'OfficeLocation';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'CONSTRAINT', @level2name = N'Employees$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Employees].[LastName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees', @level2type = N'INDEX', @level2name = N'Employees$LastName';

