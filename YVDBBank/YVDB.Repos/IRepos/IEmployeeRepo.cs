using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YVDB.Models;

namespace YVDB.Repos.IRepos
{
    public interface IEmployeeRepo
    {
        List<CustomerDTO> GiveCustomers();
         void AddCustomer(CustomerDTO customer);
    }
}
