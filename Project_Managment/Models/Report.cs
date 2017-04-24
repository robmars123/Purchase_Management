namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report
    {
        public int ReportID { get; set; }

        [StringLength(50)]
        public string ReportName { get; set; }

        [StringLength(255)]
        public string ReportDesc { get; set; }
    }
}
