CREATE TABLE [dbo].[Vendors] (
    [VendorID]         INT            IDENTITY (1, 1) NOT NULL,
    [VendorName]       NVARCHAR (50)  NULL,
    [ContactFirstName] NVARCHAR (30)  NULL,
    [ContactLastName]  NVARCHAR (50)  NULL,
    [Title]            NVARCHAR (50)  NULL,
    [Address]          NVARCHAR (255) NULL,
    [City]             NVARCHAR (50)  NULL,
    [StateOrProvince]  NVARCHAR (20)  NULL,
    [PostalCode]       NVARCHAR (20)  NULL,
    [Country]          NVARCHAR (50)  NULL,
    [PhoneNumber]      NVARCHAR (30)  NULL,
    [FaxNumber]        NVARCHAR (30)  NULL,
    [Notes]            NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]   ROWVERSION     NOT NULL,
    CONSTRAINT [Vendors$PrimaryKey] PRIMARY KEY CLUSTERED ([VendorID] ASC),
    CONSTRAINT [SSMA_CC$Vendors$VendorName$disallow_zero_length] CHECK (len([VendorName])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$ContactFirstName$disallow_zero_length] CHECK (len([ContactFirstName])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$ContactLastName$disallow_zero_length] CHECK (len([ContactLastName])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$Title$disallow_zero_length] CHECK (len([Title])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$Address$disallow_zero_length] CHECK (len([Address])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$City$disallow_zero_length] CHECK (len([City])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$StateOrProvince$disallow_zero_length] CHECK (len([StateOrProvince])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$PostalCode$disallow_zero_length] CHECK (len([PostalCode])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$Country$disallow_zero_length] CHECK (len([Country])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$PhoneNumber$disallow_zero_length] CHECK (len([PhoneNumber])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$FaxNumber$disallow_zero_length] CHECK (len([FaxNumber])>(0)),
    CONSTRAINT [SSMA_CC$Vendors$Notes$disallow_zero_length] CHECK (len([Notes])>(0))
);


GO
CREATE NONCLUSTERED INDEX [Vendors$ContactLastName]
    ON [dbo].[Vendors]([ContactLastName] ASC);


GO
CREATE NONCLUSTERED INDEX [Vendors$PostalCode]
    ON [dbo].[Vendors]([PostalCode] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[VendorID]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'VendorID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[VendorName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'VendorName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[ContactFirstName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'ContactFirstName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[ContactLastName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'ContactLastName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[Title]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'Title';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[Address]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'Address';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[City]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'City';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[StateOrProvince]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'StateOrProvince';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[PostalCode]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'PostalCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[Country]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'Country';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[PhoneNumber]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'PhoneNumber';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[FaxNumber]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'FaxNumber';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[Notes]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'COLUMN', @level2name = N'Notes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'CONSTRAINT', @level2name = N'Vendors$PrimaryKey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[ContactLastName]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'INDEX', @level2name = N'Vendors$ContactLastName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'Laptop Database.[Vendors].[PostalCode]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Vendors', @level2type = N'INDEX', @level2name = N'Vendors$PostalCode';

