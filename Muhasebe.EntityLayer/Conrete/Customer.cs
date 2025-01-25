using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(150)]
        public string CustomerName { get; set; }

        [StringLength(300)]
        public string? CustomerAddress { get; set; }

        [Phone]
        public string CustomerPhone { get; set; }

        [EmailAddress]
        public string CustomerEmail { get; set; }

        // Bir müşterinin ait olduğu şirket
        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<Invoice>? Invoices { get; set; }
        public ICollection<Payment>? Payments { get; set; }

    }
}
