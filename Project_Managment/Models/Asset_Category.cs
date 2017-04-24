namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asset Categories")]
    public partial class Asset_Category
    {
        [Key]
        public int AssetCategoryID { get; set; }

        [StringLength(50)]
        public string AssetCategory { get; set; }
    }
}
