namespace Project_Managment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Web;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int Id { get; set; }

        [Column("Firm Invoice")]
        public int? Firm_Invoice { get; set; }

        [Column("Case Name")]
        [StringLength(50)]
        public string Case_Name { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column("Invoice Date", TypeName = "date")]
        public DateTime? Invoice_Date { get; set; }

        [Column("Appealable Items")]
        public int? Appealable_Items { get; set; }

        [Column("Total Billed", TypeName = "money")]
        public decimal? Total_Billed { get; set; }

        public byte[] pdf { get; set; }
        public string FileName { get; set; }
        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Select File")]
        public HttpPostedFileBase files { get; set; }
    }
    public class FileDetailsModel
    {

        public int Id { get; set; }
        [Display(Name = "Uploaded File")]
        public String FileName { get; set; }
        public byte[] pdf { get; set; }


    }
}
