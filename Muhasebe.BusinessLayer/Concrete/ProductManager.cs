using Muhasebe.BusinessLayer.Abstract;
using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            var product= _productDal.GetAll(x => x.CategoryId == categoryId);

            return _productDal.GetAll(x=>x.CategoryId==categoryId);
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductListWithCategory(int companyId)
        {
            //_productDal.GetAllWithCategoty(//companyId);
            return _productDal.GetProductsWithCategory(companyId);
        }

        //public List<Product> GetProductListWithCategoryById(int companyId)
        //{
        //    return _productDal.GetProductsWithCategory(companyId);
        //}

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
