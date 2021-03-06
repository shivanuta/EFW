using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFW.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        public double Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string Name { get; set; }


        public ICollection<SaleItem> SaleItemList { get; set; }
                    = new List<SaleItem>();
    }
}
