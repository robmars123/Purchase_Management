namespace Project_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asset Categories",
                c => new
                    {
                        AssetCategoryID = c.Int(nullable: false, identity: true),
                        AssetCategory = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AssetCategoryID);
            
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        AssetID = c.Int(nullable: false, identity: true),
                        AssetDescription = c.String(maxLength: 255),
                        EmployeeID = c.Int(),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                        AssetCategoryID = c.Int(),
                        StatusID = c.Int(),
                        DepartmentID = c.Int(),
                        VendorID = c.Int(),
                        Make = c.String(nullable: false, maxLength: 50),
                        ModelNumber = c.String(maxLength: 50),
                        SerialNumber = c.String(nullable: false, maxLength: 50),
                        DateAcquired = c.DateTime(nullable: false, precision: 0, storeType: "datetime2"),
                        DateSold = c.DateTime(precision: 0, storeType: "datetime2"),
                        PurchasePrice = c.Decimal(nullable: false, storeType: "money"),
                        DepreciationMethod = c.String(maxLength: 50),
                        DepreciableLife = c.Single(),
                        SalvageValue = c.Decimal(storeType: "money"),
                        CurrentValue = c.Decimal(storeType: "money"),
                        Comments = c.String(),
                        Description = c.String(maxLength: 255),
                        NextSchedMaint = c.DateTime(precision: 0, storeType: "datetime2"),
                        Processor = c.String(maxLength: 255),
                        RAM = c.String(maxLength: 255),
                        Condition = c.String(nullable: false, maxLength: 255),
                        ComputerName = c.String(nullable: false, maxLength: 255),
                        SSMA_TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    })
                .PrimaryKey(t => t.AssetID)
                .ForeignKey("dbo.Asset Categories", t => t.AssetCategoryID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Status", t => t.StatusID)
                .ForeignKey("dbo.Vendors", t => t.VendorID)
                .Index(t => t.EmployeeID)
                .Index(t => t.AssetCategoryID)
                .Index(t => t.StatusID)
                .Index(t => t.DepartmentID)
                .Index(t => t.VendorID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        DepartmentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Employees", t => t.DepartmentID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        OfficeLocation = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Depreciation",
                c => new
                    {
                        DepreciationID = c.Int(nullable: false, identity: true),
                        AssetID = c.Int(),
                        DepreciationDate = c.DateTime(precision: 0, storeType: "datetime2"),
                        DepreciationAmount = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.DepreciationID)
                .ForeignKey("dbo.Assets", t => t.AssetID, cascadeDelete: true)
                .Index(t => t.AssetID);
            
            CreateTable(
                "dbo.Maintenance",
                c => new
                    {
                        MaintenanceID = c.Int(nullable: false, identity: true),
                        AssetID = c.Int(),
                        MaintenanceDate = c.DateTime(precision: 0, storeType: "datetime2"),
                        MaintenanceDescription = c.String(maxLength: 255),
                        MaintenancePerformedBy = c.String(maxLength: 50),
                        MaintenanceCost = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.MaintenanceID)
                .ForeignKey("dbo.Assets", t => t.AssetID, cascadeDelete: true)
                .Index(t => t.AssetID);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false),
                        PromotionDate = c.DateTime(),
                        AssetID = c.Int(),
                        EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.ManagerId)
                .ForeignKey("dbo.Assets", t => t.ManagerId)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.ManagerId)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        Status = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorID = c.Int(nullable: false, identity: true),
                        VendorName = c.String(maxLength: 50),
                        ContactFirstName = c.String(maxLength: 30),
                        ContactLastName = c.String(maxLength: 50),
                        Title = c.String(maxLength: 50),
                        Address = c.String(maxLength: 255),
                        City = c.String(maxLength: 50),
                        StateOrProvince = c.String(maxLength: 20),
                        PostalCode = c.String(maxLength: 20),
                        Country = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 30),
                        FaxNumber = c.String(maxLength: 30),
                        Notes = c.String(),
                        SSMA_TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    })
                .PrimaryKey(t => t.VendorID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        ReportName = c.String(maxLength: 50),
                        ReportDesc = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ReportID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assets", "VendorID", "dbo.Vendors");
            DropForeignKey("dbo.Assets", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Managers", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Managers", "ManagerId", "dbo.Assets");
            DropForeignKey("dbo.Maintenance", "AssetID", "dbo.Assets");
            DropForeignKey("dbo.Assets", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Depreciation", "AssetID", "dbo.Assets");
            DropForeignKey("dbo.Assets", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Departments", "DepartmentID", "dbo.Employees");
            DropForeignKey("dbo.Assets", "AssetCategoryID", "dbo.Asset Categories");
            DropIndex("dbo.Managers", new[] { "EmployeeID" });
            DropIndex("dbo.Managers", new[] { "ManagerId" });
            DropIndex("dbo.Maintenance", new[] { "AssetID" });
            DropIndex("dbo.Depreciation", new[] { "AssetID" });
            DropIndex("dbo.Departments", new[] { "DepartmentID" });
            DropIndex("dbo.Assets", new[] { "VendorID" });
            DropIndex("dbo.Assets", new[] { "DepartmentID" });
            DropIndex("dbo.Assets", new[] { "StatusID" });
            DropIndex("dbo.Assets", new[] { "AssetCategoryID" });
            DropIndex("dbo.Assets", new[] { "EmployeeID" });
            DropTable("dbo.Reports");
            DropTable("dbo.Vendors");
            DropTable("dbo.Status");
            DropTable("dbo.Managers");
            DropTable("dbo.Maintenance");
            DropTable("dbo.Depreciation");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Assets");
            DropTable("dbo.Asset Categories");
        }
    }
}
