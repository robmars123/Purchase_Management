CREATE TABLE [dbo].[Assets] (
    [AssetID]            INT            IDENTITY (1, 1) NOT NULL,
    [AssetDescription]   NVARCHAR (255) NULL,
    [EmployeeID]         INT            NULL,
    [AssetCategoryID]    INT            DEFAULT ((2)) NULL,
    [StatusID]           INT            NULL,
    [DepartmentID]       INT            NULL,
    [VendorID]           INT            NULL,
    [Make]               NVARCHAR (50)  NULL,
    [ModelNumber]        NVARCHAR (50)  NULL,
    [SerialNumber]       NVARCHAR (50)  NULL,
    [DateAcquired]       DATETIME2 (0)  NULL,
    [DateSold]           DATETIME2 (0)  NULL,
    [PurchasePrice]      MONEY          NULL,
    [DepreciationMethod] NVARCHAR (50)  NULL,
    [DepreciableLife]    REAL           NULL,
    [SalvageValue]       MONEY          NULL,
    [CurrentValue]       MONEY          NULL,
    [Comments]           NVARCHAR (MAX) NULL,
    [Description]        NVARCHAR (255) NULL,
    [NextSchedMaint]     DATETIME2 (0)  NULL,
    [Processor]          NVARCHAR (255) NULL,
    [RAM]                NVARCHAR (255) NULL,
    [Condition]          NVARCHAR (255) NULL,
    [ComputerName]       NVARCHAR (255) NULL,
    [SSMA_TimeStamp]     ROWVERSION     NOT NULL,
    [GroupID]            INT            NULL,
    CONSTRAINT [Assets$PrimaryKey] PRIMARY KEY CLUSTERED ([AssetID] ASC),
    CONSTRAINT [FK_Assets_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID]),
    CONSTRAINT [SSMA_CC$Assets$AssetDescription$disallow_zero_length] CHECK (len([AssetDescription])>(0)),
    CONSTRAINT [SSMA_CC$Assets$Comments$disallow_zero_length] CHECK (len([Comments])>(0)),
    CONSTRAINT [SSMA_CC$Assets$DepreciationMethod$disallow_zero_length] CHECK (len([DepreciationMethod])>(0)),
    CONSTRAINT [SSMA_CC$Assets$Description$disallow_zero_length] CHECK (len([Description])>(0)),
    CONSTRAINT [SSMA_CC$Assets$Make$disallow_zero_length] CHECK (len([Make])>(0)),
    CONSTRAINT [SSMA_CC$Assets$ModelNumber$disallow_zero_length] CHECK (len([ModelNumber])>(0)),
    CONSTRAINT [SSMA_CC$Assets$SerialNumber$disallow_zero_length] CHECK (len([SerialNumber])>(0))
);


GO
CREATE NONCLUSTERED INDEX [Assets$AssetCategoryID]
    ON [dbo].[Assets]([AssetCategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$DateAcquired]
    ON [dbo].[Assets]([DateAcquired] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$DepartmentID]
    ON [dbo].[Assets]([DepartmentID] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$EmployeeID]
    ON [dbo].[Assets]([EmployeeID] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$Make]
    ON [dbo].[Assets]([Make] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$SerialNumber]
    ON [dbo].[Assets]([SerialNumber] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$StatusID]
    ON [dbo].[Assets]([StatusID] ASC);


GO
CREATE NONCLUSTERED INDEX [Assets$VendorID]
    ON [dbo].[Assets]([VendorID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[AssetID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'AssetID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[AssetDescription]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'AssetDescription';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[EmployeeID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'EmployeeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[AssetCategoryID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'AssetCategoryID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[StatusID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'StatusID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DepartmentID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'DepartmentID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[VendorID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'VendorID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Make]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'Make';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[ModelNumber]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'ModelNumber';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[SerialNumber]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'SerialNumber';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DateAcquired]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'DateAcquired';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DateSold]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'DateSold';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[PurchasePrice]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'PurchasePrice';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DepreciationMethod]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'DepreciationMethod';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DepreciableLife]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'DepreciableLife';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[SalvageValue]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'SalvageValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[CurrentValue]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'CurrentValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Comments]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'Comments';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Description]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[NextSchedMaint]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'NextSchedMaint';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Processor]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'Processor';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[RAM]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'RAM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Condition]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'Condition';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[ComputerName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'COLUMN', @level2name = N'ComputerName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'CONSTRAINT', @level2name = N'Assets$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[AssetCategoryID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$AssetCategoryID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DateAcquired]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$DateAcquired';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[DepartmentID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$DepartmentID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[EmployeeID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$EmployeeID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[Make]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$Make';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[SerialNumber]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$SerialNumber';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[StatusID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$StatusID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Assets].[VendorID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Assets', @level2type = N'INDEX', @level2name = N'Assets$VendorID';

