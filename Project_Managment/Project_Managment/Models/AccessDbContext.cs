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

       // public int ManagerId { get; set; }


       // public DateTime? PromotionDate { get; set; }

       // // [Key]
       // public int EmployeeID { get; set; }

       //// [StringLength(50)]
       // public string FirstName { get; set; }

       //// [StringLength(50)]
       // public string LastName { get; set; }

       // internal object GetRoles()
       // {
       //     throw new NotImplementedException();
       // }

      //  // [StringLength(20)]
      //  public string OfficeLocation { get; set; }
      //  //[Key]
      //  public int AssetID { get; set; }

      // // [StringLength(255)]
      //  public string AssetDescription { get; set; }

      ////  public int? EmployeeID { get; set; }

      //  public int? AssetCategoryID { get; set; }

      //  public int? StatusID { get; set; }

      //  public int? DepartmentID { get; set; }

      //  public int? VendorID { get; set; }

      // // [StringLength(50)]
      //  public string Make { get; set; }


        

      //  //[StringLength(50)]
      //  public string ModelNumber { get; set; }

      //  //[StringLength(50)]
      //  public string SerialNumber { get; set; }

      //  [Column(TypeName = "datetime2")]
      //  public DateTime? DateAcquired { get; set; }

      //  [Column(TypeName = "datetime2")]
      //  public DateTime? DateSold { get; set; }

      //  [Column(TypeName = "money")]
      //  public decimal? PurchasePrice { get; set; }

      ////  [StringLength(50)]
      //  public string DepreciationMethod { get; set; }

      //  public float? DepreciableLife { get; set; }

      //  [Column(TypeName = "money")]
      //  public decimal? SalvageValue { get; set; }

      //  [Column(TypeName = "money")]
      //  public decimal? CurrentValue { get; set; }

      //  public string Comments { get; set; }

      // // [StringLength(255)]
      //  public string Description { get; set; }

      //  [Column(TypeName = "datetime2")]
      //  public DateTime? NextSchedMaint { get; set; }

      // // [StringLength(255)]
      //  public string Processor { get; set; }

      // // [StringLength(255)]
      //  public string RAM { get; set; }

      ////  [StringLength(255)]
      //  public string Condition { get; set; }

      // // [StringLength(255)]
      //  public string ComputerName { get; set; }

      //  [Column(TypeName = "timestamp")]
      ////  [MaxLength(8)]
      ////  [Timestamp]
      //  public byte[] SSMA_TimeStamp { get; set; }


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
        public virtual DbSet<Employee_Asset> Employee_Assets { get; set; }
       
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

       // public System.Data.Entity.DbSet<Project_Managment.Models.Managers> Managers { get; set; }
    }
}
