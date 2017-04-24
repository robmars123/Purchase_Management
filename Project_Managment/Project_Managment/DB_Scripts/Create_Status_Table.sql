CREATE TABLE [dbo].[Status] (
    [StatusID] INT           IDENTITY (1, 1) NOT NULL,
    [Status]   NVARCHAR (20) NULL,
    CONSTRAINT [Status$PrimaryKey] PRIMARY KEY CLUSTERED ([StatusID] ASC),
    CONSTRAINT [SSMA_CC$Status$Status$disallow_zero_length] CHECK (len([Status])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Status]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Status';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Status].[StatusID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Status', @level2type = N'COLUMN', @level2name = N'StatusID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Status].[Status]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Status', @level2type = N'COLUMN', @level2name = N'Status';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Status].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Status', @level2type = N'CONSTRAINT', @level2name = N'Status$PrimaryKey';

