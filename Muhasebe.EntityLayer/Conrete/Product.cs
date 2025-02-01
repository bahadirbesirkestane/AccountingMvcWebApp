using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; } // Ürün açıklaması eklendi

        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; } // Stok adedi eklendi

        [Required]
        public bool ProductStatus  { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
