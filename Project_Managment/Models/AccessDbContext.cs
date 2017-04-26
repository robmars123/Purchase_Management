namespace Project_Managment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class AccessDbContext : DbContext
    {
        //internal object Manager;

        public AccessDbContext()
            : base("name=AccessDbContext")
        {
        }


        public virtual DbSet<Asset_Category> Asset_Categories { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Depreciation> Depreciations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Employee_Asset> Employee_Assets { get; set; } //bridge table
        public virtual DbSet<ManagerList> ManagerLists { get; set; }

        internal object Entry(Employee employee, Department department)
        {
            throw new NotImplementedException();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Employee>()
            //  .HasMany(t => t.Assets)
            //  .WithMany(t => t.Employees)
            //  .Map(m =>
            //  {
            //      m.ToTable("Employee_Assets");
            //      m.MapLeftKey("EmployeeID");
            //      m.MapRightKey("AssetID");
            //    });

            modelBuilder.Entity<Asset>()
                .Property(e => e.DateAcquired)
                .HasPrecision(0);

            modelBuilder.Entity<Asset>()
                .Property(e => e.DateSold)
                .HasPrecision(0);

            modelBuilder.Entity<Asset>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Asset>()
                .Property(e => e.SalvageValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Asset>()
                .Property(e => e.CurrentValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Asset>()
                .Property(e => e.NextSchedMaint)
                .HasPrecision(0);

            modelBuilder.Entity<Asset>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            //modelBuilder.Entity<Asset>()
            //    .HasMany(e => e.Depreciations)
            //    .WithOptional(e => e.Asset)
            //    .WillCascadeOnDelete();

            //modelBuilder.Entity<Asset>()
            //    .HasMany(e => e.Maintenances)
            //    .WithOptional(e => e.Asset)
            //    .WillCascadeOnDelete();

            modelBuilder.Entity<Depreciation>()
                .Property(e => e.DepreciationDate)
                .HasPrecision(0);

            modelBuilder.Entity<Depreciation>()
                .Property(e => e.DepreciationAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Maintenance>()
                .Property(e => e.MaintenanceDate)
                .HasPrecision(0);

            modelBuilder.Entity<Maintenance>()
                .Property(e => e.MaintenanceCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();
        }

        public System.Data.Entity.DbSet<Project_Managment.Models.Invoice> Invoices { get; set; }
    }
}
