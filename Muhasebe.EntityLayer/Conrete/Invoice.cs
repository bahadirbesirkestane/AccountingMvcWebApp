using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        public decimal InvoiceTotal { get; set; }

        public Customer Customer { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }

    }
}
