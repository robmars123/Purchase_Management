CREATE TABLE [dbo].[Maintenance] (
    [MaintenanceID]          INT            IDENTITY (1, 1) NOT NULL,
    [AssetID]                INT            NULL,
    [MaintenanceDate]        DATETIME2 (0)  NULL,
    [MaintenanceDescription] NVARCHAR (255) NULL,
    [MaintenancePerformedBy] NVARCHAR (50)  NULL,
    [MaintenanceCost]        MONEY          NULL,
    CONSTRAINT [Maintenance$PrimaryKey] PRIMARY KEY CLUSTERED ([MaintenanceID] ASC),
    CONSTRAINT [Maintenance$Reference3] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[Assets] ([AssetID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [SSMA_CC$Maintenance$MaintenanceDescription$disallow_zero_length] CHECK (len([MaintenanceDescription])>(0)),
    CONSTRAINT [SSMA_CC$Maintenance$MaintenancePerformedBy$disallow_zero_length] CHECK (len([MaintenancePerformedBy])>(0))
);


GO
CREATE NONCLUSTERED INDEX [Maintenance$AssetID]
    ON [dbo].[Maintenance]([AssetID] ASC);


GO
CREATE NONCLUSTERED INDEX [Maintenance$MaintenanceDate]
    ON [dbo].[Maintenance]([MaintenanceDate] ASC);


GO
CREATE NONCLUSTERED INDEX [Maintenance$Reference3]
    ON [dbo].[Maintenance]([AssetID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenanceID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'MaintenanceID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[AssetID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'AssetID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenanceDate]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'MaintenanceDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenanceDescription]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'MaintenanceDescription';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenancePerformedBy]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'MaintenancePerformedBy';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenanceCost]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'COLUMN', @level2name = N'MaintenanceCost';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'CONSTRAINT', @level2name = N'Maintenance$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[Reference3]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'CONSTRAINT', @level2name = N'Maintenance$Reference3';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[AssetID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'INDEX', @level2name = N'Maintenance$AssetID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[MaintenanceDate]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'INDEX', @level2name = N'Maintenance$MaintenanceDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Maintenance].[Reference3]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Maintenance', @level2type = N'INDEX', @level2name = N'Maintenance$Reference3';

