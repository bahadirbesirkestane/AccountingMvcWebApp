using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        List<Category> GetAll();
        List<Category> GetAllByCompanyId(int companyId);
        Category GetById(int id);
        //List<Category> GetAllByCompanyId(int companyId);

    }
}
