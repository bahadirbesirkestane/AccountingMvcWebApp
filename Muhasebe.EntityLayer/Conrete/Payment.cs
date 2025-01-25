using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        public string? PaymentType { get; set; }

        public decimal PaymentAmount { get; set; }

        public Customer Customer { get; set; }

      
    }
}
