namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        public int StatusID { get; set; }

        [Column("Status")]
        [StringLength(20)]
        public string Status1 { get; set; }
    }
}
