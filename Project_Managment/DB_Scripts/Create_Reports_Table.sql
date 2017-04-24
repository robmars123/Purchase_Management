CREATE TABLE [dbo].[Reports] (
    [ReportID]   INT            IDENTITY (1, 1) NOT NULL,
    [ReportName] NVARCHAR (50)  NULL,
    [ReportDesc] NVARCHAR (255) NULL,
    CONSTRAINT [Reports$PrimaryKey] PRIMARY KEY CLUSTERED ([ReportID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [Reports$ReportID]
    ON [dbo].[Reports]([ReportID] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports].[ReportID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports', @level2type = N'COLUMN', @level2name = N'ReportID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports].[ReportName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports', @level2type = N'COLUMN', @level2name = N'ReportName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports].[ReportDesc]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports', @level2type = N'COLUMN', @level2name = N'ReportDesc';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports', @level2type = N'CONSTRAINT', @level2name = N'Reports$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Reports].[ReportID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Reports', @level2type = N'INDEX', @level2name = N'Reports$ReportID';

