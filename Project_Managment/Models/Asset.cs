namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Assets")]
    public partial class Asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asset()
        {
            Depreciations = new HashSet<Depreciation>();
            Maintenances = new HashSet<Maintenance>();

        }
       
        [Key, ForeignKey("Employees_Assets")]
        public int AssetID { get; set; }

        [StringLength(255)]
        public string AssetDescription { get; set; }

        public int? EmployeeID { get; set; }


        public int? AssetCategoryID { get; set; }

        public int? StatusID { get; set; }

        public int? DepartmentID { get; set; }
   
        public int? VendorID { get; set; }

        [Required(ErrorMessage = "please enter the make")]
        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string ModelNumber { get; set; }

        [Required(ErrorMessage = "please enter the serial number ")]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "please enter the date acquired ")]
        [Column(TypeName = "datetime2")]
        public DateTime? DateAcquired { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateSold { get; set; }

        [Required(ErrorMessage = "please enter the purchase price")]
        [Column(TypeName = "money")]
        public decimal? PurchasePrice { get; set; }

        [StringLength(50)]
        public string DepreciationMethod { get; set; }

        public float? DepreciableLife { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalvageValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrentValue { get; set; }
        [ConcurrencyCheck]
        public string Comments { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NextSchedMaint { get; set; }

        [StringLength(255)]
        public string Processor { get; set; }

        [StringLength(255)]
        public string RAM { get; set; }

        
        [StringLength(255)]
        public string Condition { get; set; }

        [Required(ErrorMessage = "please enter the computer name")]
        [StringLength(255)]
        public string ComputerName { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
       
        public int? ManagerListID { get; set; }

        //public int? DepartmentCode { get; set; }
        //public int? FundCode { get; set; }
        //public int? ObjectCode { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Depreciation> Depreciations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance> Maintenances { get; set; }


        //Nagivation Properties
        //Just added [Key] on top and these  table names - then you can access from the Index.cshtml - Asset
        //employee table

       public virtual Employee Employees { get; set; }
        //asset_cat
        public virtual Asset_Category Asset_Category { get; set; }
        //Status
        public virtual Status Status { get; set; }
        //Department
        public virtual Department Department { get; set; }
        //Vendor
        public virtual Vendor Vendor { get; set; }

        public virtual ManagerList ManagerList { get; set; }
       // public virtual ICollection<ManagerList> _ManagerLists { get; set; }
        public virtual Employee_Asset Employees_Assets { get; set; }

    }
}
