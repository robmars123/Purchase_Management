namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group
    {
        // public Group() { }
        [Key]
        public int GroupID { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }

        
    }
}
