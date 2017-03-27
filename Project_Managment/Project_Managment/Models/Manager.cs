namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manager
    {
        public Manager() { }
        [Key, ForeignKey("Asset")]
        public int ManagerId { get; set; }

        
        public DateTime? PromotionDate { get; set; }
        
       
        public int? AssetID { get; set; }
      // [ForeignKey("EmployeeID")] //not valid
        public int? EmployeeID { get; set; }

       
    
        public virtual Employee Employees { get; set; }
       
        public virtual Asset Asset { get; set; }
    }
}
