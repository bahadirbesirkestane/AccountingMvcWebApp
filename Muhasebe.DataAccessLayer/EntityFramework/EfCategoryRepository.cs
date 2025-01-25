using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.DataAccessLayer.Repositories;
using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
    }
}
