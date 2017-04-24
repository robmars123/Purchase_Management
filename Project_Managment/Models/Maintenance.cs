namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maintenance")]
    public partial class Maintenance
    {
        public int MaintenanceID { get; set; }

        public int? AssetID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? MaintenanceDate { get; set; }

        [StringLength(255)]
        public string MaintenanceDescription { get; set; }

        [StringLength(50)]
        public string MaintenancePerformedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaintenanceCost { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
