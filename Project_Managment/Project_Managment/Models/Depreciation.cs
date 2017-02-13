namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Depreciation")]
    public partial class Depreciation
    {
        public int DepreciationID { get; set; }

        public int? AssetID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DepreciationDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DepreciationAmount { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
