using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YVDB.Models;
using YVDB.Repos.Data;
using YVDB.Repos.IRepos;

namespace YVDB.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private List<CustomerDTO> _cust = new List<CustomerDTO>();
        public CustomerData CustomerData { get; }
        public EmployeeRepo()
        {
            CustomerData = CustomerData.Instance;
            _cust = CustomerData.GetCustomers();

        }
        public List<CustomerDTO> GiveCustomers()
        {
            return _cust;
        }
        public void AddCustomer(CustomerDTO customer)
        {
            customer.CustomerId = (_cust.MaxBy(x => x.CustomerId) ?? new CustomerDTO() { CustomerId = 1 }).CustomerId + 1;
            _cust.Add(customer);
        }
    }
}
