using Muhasebe.BusinessLayer.Abstract;
using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.DataAccessLayer.EntityFramework;
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
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public void AddCategory(Category category)
        {
            _categoryDAL.Insert(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public List<Category> GetAllByCompanyId(int companyId)
        {
            return _categoryDAL.GetAll(x=> x.CompanyId == companyId);
        }

        //public List<Category> GetAllByCompanyId(int companyId)
        //{
        //    return _categoryDAL.GetAllWithCompanyId(companyId);
        //}

        public Category GetById(int id)
        {

            return _categoryDAL.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
