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
        private List<Customer> _cust = new List<Customer>();
        public CustomerData CustomerData { get; }
        public EmployeeRepo()
        {
            CustomerData = CustomerData.Instance;
            _cust = CustomerData.GetCustomers();

        }
        public List<Customer> GiveCustomers()
        {
            return _cust;
        }
        public void AddCustomer(Customer customer)
        {
            customer.CustomerId = (_cust.MaxBy(x => x.CustomerId) ?? new Customer() { CustomerId = 1 }).CustomerId + 1;
            _cust.Add(customer);
        }
    }
}
