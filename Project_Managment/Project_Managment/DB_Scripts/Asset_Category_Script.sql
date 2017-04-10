CREATE TABLE [dbo].[Asset Categories] (
    [AssetCategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [AssetCategory]   NVARCHAR (50) NULL,
    CONSTRAINT [Asset Categories$PrimaryKey] PRIMARY KEY CLUSTERED ([AssetCategoryID] ASC),
    CONSTRAINT [SSMA_CC$Asset Categories$AssetCategory$disallow_zero_length] CHECK (len([AssetCategory])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Asset Categories]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Asset Categories';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Asset Categories].[AssetCategoryID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Asset Categories', @level2type = N'COLUMN', @level2name = N'AssetCategoryID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Asset Categories].[AssetCategory]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Asset Categories', @level2type = N'COLUMN', @level2name = N'AssetCategory';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Asset Categories].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Asset Categories', @level2type = N'CONSTRAINT', @level2name = N'Asset Categories$PrimaryKey';

