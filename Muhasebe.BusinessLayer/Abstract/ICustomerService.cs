using Muhasebe.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        List<Customer> GetAll();
        List<Customer> GetAllByCompanyId(int companyId);
        Customer GetById(int id);
    }
}
