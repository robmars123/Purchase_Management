namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }
    }
}
