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
        [Key]
        public int Employee_AssetID { get; set; }
       
        public int AssetID { get; set; }
        public int EmployeeID { get; set; }
        public int ManagerListID { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual ManagerList ManagerLists { get; set; }
    }
}