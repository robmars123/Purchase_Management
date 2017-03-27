namespace Project_Managment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Assets", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Assets", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Assets", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Assets", "VendorID", "dbo.Vendors");
            DropIndex("dbo.Assets", new[] { "EmployeeID" });
            DropIndex("dbo.Assets", new[] { "StatusID" });
            DropIndex("dbo.Assets", new[] { "DepartmentID" });
            DropIndex("dbo.Assets", new[] { "VendorID" });
            AddColumn("dbo.Assets", "FirstName", c => c.Int(nullable: false));
            AddColumn("dbo.Assets", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "EmployeeID", c => c.Int());
            AlterColumn("dbo.Assets", "StatusID", c => c.Int());
            AlterColumn("dbo.Assets", "DepartmentID", c => c.Int());
            AlterColumn("dbo.Assets", "VendorID", c => c.Int());
            CreateIndex("dbo.Assets", "EmployeeID");
            CreateIndex("dbo.Assets", "StatusID");
            CreateIndex("dbo.Assets", "DepartmentID");
            CreateIndex("dbo.Assets", "VendorID");
            AddForeignKey("dbo.Assets", "DepartmentID", "dbo.Departments", "DepartmentID");
            AddForeignKey("dbo.Assets", "EmployeeID", "dbo.Employees", "EmployeeID");
            AddForeignKey("dbo.Assets", "StatusID", "dbo.Status", "StatusID");
            AddForeignKey("dbo.Assets", "VendorID", "dbo.Vendors", "VendorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assets", "VendorID", "dbo.Vendors");
            DropForeignKey("dbo.Assets", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Assets", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Assets", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Assets", new[] { "VendorID" });
            DropIndex("dbo.Assets", new[] { "DepartmentID" });
            DropIndex("dbo.Assets", new[] { "StatusID" });
            DropIndex("dbo.Assets", new[] { "EmployeeID" });
            AlterColumn("dbo.Assets", "VendorID", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "DepartmentID", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "StatusID", c => c.Int(nullable: false));
            AlterColumn("dbo.Assets", "EmployeeID", c => c.Int(nullable: false));
            DropColumn("dbo.Assets", "LastName");
            DropColumn("dbo.Assets", "FirstName");
            CreateIndex("dbo.Assets", "VendorID");
            CreateIndex("dbo.Assets", "DepartmentID");
            CreateIndex("dbo.Assets", "StatusID");
            CreateIndex("dbo.Assets", "EmployeeID");
            AddForeignKey("dbo.Assets", "VendorID", "dbo.Vendors", "VendorID", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "StatusID", "dbo.Status", "StatusID", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.Assets", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
        }
    }
}
