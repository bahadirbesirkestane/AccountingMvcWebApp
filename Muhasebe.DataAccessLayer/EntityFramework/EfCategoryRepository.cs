using Microsoft.EntityFrameworkCore;
using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.DataAccessLayer.Concrete;
using Muhasebe.DataAccessLayer.Repositories;
using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        //public List<Category> GetAllWithCompanyId(int companyId)
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Categories
        //        .Include(x => x.Company)
        //        .Where(x => x.CompanyId == companyId)
        //        .ToList();
        //    }

        
        //}
    }
}
