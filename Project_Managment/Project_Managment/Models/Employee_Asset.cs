using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_Managment.Models
{
    public class Employee_Asset
    {

        public int AssetID { get; set; }

        [StringLength(255)]
        public string AssetDescription { get; set; }
        
        public int? EmployeeID { get; set; }

        public int? AssetCategoryID { get; set; }

        public int? StatusID { get; set; }

        public int? DepartmentID { get; set; }

        public int? VendorID { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string ModelNumber { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateAcquired { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateSold { get; set; }

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

        [StringLength(255)]
        public string Condition { get; set; }

        [StringLength(255)]
        public string ComputerName { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }



        
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Depreciation> Depreciations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance> Maintenances { get; set; }

      
        public virtual Employee Employees { get; internal set; }
    }
}