CREATE TABLE [dbo].[Depreciation] (
    [DepreciationID]     INT           IDENTITY (1, 1) NOT NULL,
    [AssetID]            INT           NULL,
    [DepreciationDate]   DATETIME2 (0) NULL,
    [DepreciationAmount] MONEY         NULL,
    CONSTRAINT [Depreciation$PrimaryKey] PRIMARY KEY CLUSTERED ([DepreciationID] ASC),
    CONSTRAINT [Depreciation$Reference4] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Assets] ([AssetID]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [Depreciation$AssetID]
    ON [dbo].[Depreciation]([AssetID] ASC);


GO
CREATE NONCLUSTERED INDEX [Depreciation$DepreciationDate]
    ON [dbo].[Depreciation]([DepreciationDate] ASC);


GO
CREATE NONCLUSTERED INDEX [Depreciation$Reference4]
    ON [dbo].[Depreciation]([AssetID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[DepreciationID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'COLUMN', @level2name = N'DepreciationID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[AssetID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'COLUMN', @level2name = N'AssetID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[DepreciationDate]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'COLUMN', @level2name = N'DepreciationDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[DepreciationAmount]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'COLUMN', @level2name = N'DepreciationAmount';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'CONSTRAINT', @level2name = N'Depreciation$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[Reference4]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'CONSTRAINT', @level2name = N'Depreciation$Reference4';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[AssetID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'INDEX', @level2name = N'Depreciation$AssetID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[DepreciationDate]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'INDEX', @level2name = N'Depreciation$DepreciationDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Depreciation].[Reference4]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Depreciation', @level2type = N'INDEX', @level2name = N'Depreciation$Reference4';

