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
    public class EmployeeRepoDapper : IEmployeeRepo
    {
        public List<Customer> GiveCustomers()
        {
            GenericDapper<Customer> gd = new GenericDapper<Customer>();
            return gd.SQLQueryAsync("select * from Customer").Result.ToList<Customer>();
        }
        public void AddCustomer(Customer customer)
        {

        }
    }
}
