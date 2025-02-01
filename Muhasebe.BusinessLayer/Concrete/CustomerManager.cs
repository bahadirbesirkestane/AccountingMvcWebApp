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
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }
        public void AddCustomer(Customer customer)
        {
            _customerDAL.Insert(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDAL.GetAll();
        }

        public List<Customer> GetAllByCompanyId(int companyId)
        {
            return _customerDAL.GetAll(x => x.CompanyId == companyId);
        }

        public Customer GetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public void RemoveCustomer(Customer customer)
        {
            _customerDAL.Delete(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerDAL.Update(customer);
        }
    }
}
