namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
  
    public partial class Employee
    {

       // public Employee() { }

        //[Key, ForeignKey("Asset")] 
       // -- need to change. Taking over assetID
       [Key, ForeignKey("Employees_Assets")]
        public int EmployeeID { get; set; }


        public int? DepartmentID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string OfficeLocation { get; set; }

        public int? GroupID { get; set; }
      
       
        public virtual Department Department { get; set; }
        public virtual Group Group { get; set; }
       
        public virtual Employee_Asset Employees_Assets { get; set; }
    }
}
