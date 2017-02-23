namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Department
    {


        public Department() { }
        [Key, ForeignKey("Employees")]
        [Display(Name = "User Role")]
        public int DepartmentID { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        // public int EmployeeID { get; set; }

     
        public IEnumerable<SelectListItem> Departments { get; set; }

        public virtual Employee Employees { get; set; }

    }
}
