
namespace Project_Managment.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ManagerList")]
    public class ManagerList
    {
        [Key, ForeignKey("Assets")]
        public int ManagerListID { get; set; }
        public int EmployeeID { get; set; }
        public int GroupID { get; set; }
        public int AssetID { get; set; }

        public virtual Employee Employees { get; set; }
        public virtual Group Groups { get; set; }
        public virtual Asset Assets { get; set; }
        //public virtual ICollection<Employee_Asset> Employees_Assets { get; set; }
    }
}