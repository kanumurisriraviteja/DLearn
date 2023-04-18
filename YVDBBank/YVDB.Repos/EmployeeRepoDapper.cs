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
        public List<CustomerDTO> GiveCustomers()
        {
            GenericDapper<CustomerDTO> gd = new GenericDapper<CustomerDTO>();
            return gd.SQLQueryAsync("select * from Customer").Result.ToList<CustomerDTO>();
        }
        public void AddCustomer(CustomerDTO customer)
        {

        }
    }
}
