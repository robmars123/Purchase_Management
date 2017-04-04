namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {

        public Employee() { }
      //  [Key, ForeignKey("Manager")] //FK for Manager Table
      [Key]
        public int EmployeeID { get; set; }



        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string OfficeLocation { get; set; }

        public virtual Department Department { get; set; }

     

    }
}
