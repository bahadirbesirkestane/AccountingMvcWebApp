using Microsoft.EntityFrameworkCore;
using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.DataAccessLayer.Concrete;
using Muhasebe.DataAccessLayer.Repositories;
using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDAL
    {
        // Tüm ürünleri getirir
        public List<Product> GetAllWithCategoty()
        {
            using(var c=new Context())
            {
                return c.Products.Include(x => x.Category).ToList();
            }
            
        }

        public List<Product> GetProductsWithCategory(int companyId)
        {
            using (var c = new Context())
            {
                return c.Products
                .Include(x => x.Category)
                .Where(x => x.Category.CompanyId == companyId)
                .ToList();
            }
        }
    }
}
