using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFW.Models
{
    public class SaleItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleItemID { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string SaleName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }


        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}
