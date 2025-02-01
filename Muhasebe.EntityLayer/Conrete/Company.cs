using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.EntityLayer.Conrete
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(300)]
        public string? CompanyAddress { get; set; }

        [Phone]
        public string CompanyPhone { get; set; }

        // Bir şirketin müşterilerini temsil eden ilişki
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<User> Users { get; set; }


    }
}
