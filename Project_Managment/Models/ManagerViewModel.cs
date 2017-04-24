using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_Managment.Models
{
   

    public class ManagersModel
    {
        [Key]
        public int GroupID { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }
    }

    public class EmployeesModel
    {
        public int EmployeeID { get; set; }


        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string OfficeLocation { get; set; }

        public int? GroupID { get; set; }
    }

    public class AssetsModel
    {
       
        public int AssetID { get; set; }

        [StringLength(255)]
        public string AssetDescription { get; set; }
        // [ForeignKey("Employees")]
        // [Key]

        public int? EmployeeID { get; set; }


        public int? AssetCategoryID { get; set; }

        //[Required(ErrorMessage ="please enter or select the status ID")]
        public int? StatusID { get; set; }

        //[Required(ErrorMessage ="please enter the departmentID")]
        public int? DepartmentID { get; set; }

        //[Required(ErrorMessage = "please enter the vendor ID")]
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

    }
}