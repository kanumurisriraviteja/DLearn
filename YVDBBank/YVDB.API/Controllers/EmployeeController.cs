using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YVDB.Models;
using YVDB.Repos;

namespace YVDB.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CustomerRepo r;
        public EmployeeController()
        {
            r = new CustomerRepo();
        }

        [HttpGet(Name = "ShowCustomers")]
        public List<Customer> ShowCustomers()
        {
           return r.GiveCustomers();
           
        }

    }
}
