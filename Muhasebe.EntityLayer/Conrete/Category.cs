using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string? CategoryDescription { get; set; }

        [Required]
        public bool CategoryStatus { get; set; }

        public ICollection<Product> Products { get; set; }

        // Ürünün bağlı olduğu şirketi temsil eden ilişki

        // Bir müşterinin ait olduğu şirket
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
