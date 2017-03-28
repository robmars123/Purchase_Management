namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
 
    public partial class Asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asset()
        {
            Depreciations = new HashSet<Depreciation>();
            Maintenances = new HashSet<Maintenance>();
          
        }

        
        






        [Key]
        public int AssetID { get; set; }

        [StringLength(255)]
        public string AssetDescription { get; set; }

        public int? EmployeeID { get; set; }

     /*   [Required(ErrorMessage ="please enter the employee First Name" )]
        public int? FirstName { get; set; }

        [Required(ErrorMessage ="please enter employee Last name" )]
        public int? LastName { get; set; }
*/

        public int? AssetCategoryID { get; set; }
        
        //[Required(ErrorMessage ="please enter or select the status ID")]
        public int? StatusID { get; set; }

        //[Required(ErrorMessage ="please enter the departmentID")]
        public int? DepartmentID { get; set; }

        //[Required(ErrorMessage = "please enter the vendor ID")]
        public int? VendorID { get; set; }

        [Required(ErrorMessage ="please enter the make")]
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

        public string Comments { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NextSchedMaint { get; set; }

        [StringLength(255)]
        public string Processor { get; set; }

        [StringLength(255)]
        public string RAM { get; set; }

        [Required(ErrorMessage = "please enter the asset condition")]
        [StringLength(255)]
        public string Condition { get; set; }

        [Required(ErrorMessage = "please enter the computer name")]
        [StringLength(255)]
        public string ComputerName { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

       
       




        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Depreciation> Depreciations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance> Maintenances { get; set; }
        

        //Nagivation Properties
        //Just added [Key] on top and these  table names - then you can access from the Index.cshtml - Asset
        //employee table
        public virtual Employee  Employees { get;  set; }
        //asset_cat
        public virtual Asset_Category Asset_Category { get; set; }
        //Status
        public virtual Status Status { get; set; }
        //Department
        public virtual Department Department { get; set; }
        //Vendor
        public virtual Vendor Vendor { get; set; }

        //Managers
      //  [ForeignKey("ManagerId")]
        public virtual Manager Manager { get; set; }
    }
}
