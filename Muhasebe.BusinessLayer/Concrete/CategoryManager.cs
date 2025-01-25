using Muhasebe.BusinessLayer.Abstract;
using Muhasebe.DataAccessLayer.Repositories;
using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public void AddCategory(Category category)
        {
            
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
