CREATE TABLE [dbo].[Groups] (
    [GroupID]   INT           IDENTITY (1, 1) NOT NULL,
    [GroupName] NVARCHAR (50) NULL,
    CONSTRAINT [Groups$PrimaryKey] PRIMARY KEY CLUSTERED ([GroupID] ASC)
);

