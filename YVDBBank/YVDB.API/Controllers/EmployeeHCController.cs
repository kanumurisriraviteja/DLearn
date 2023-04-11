using Microsoft.AspNetCore.Mvc;
using YVDB.Models;
using YVDB.Repos;
using YVDB.Repos.IRepos;

namespace YVDB.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeHCController : ControllerBase
    {
        private readonly IEmployeeRepo er;
        private readonly ILogger<EmployeeHCController> _logger;
        public EmployeeHCController(ILogger<EmployeeHCController> logger)
        {
            er = new EmployeeRepo();
            _logger = logger;
        }

        [HttpGet(Name = "ShowHCCustomers")]
        public List<Customer> ShowStaticCustomers()
        {
            return er.GiveCustomers();

        }

        [HttpPost(Name = "AddHCCustomers")]
        public IActionResult AddStaticCustomer([FromBody] Customer cus)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Customer c = new Customer
                    {
                        Name = cus.Name,
                        Address = cus.Address,
                        Aadhar = cus.Aadhar,
                        Age = cus.Age,
                        Password = "Test1",
                        Balance = 10000
                    };

                    if (cus.AccType == 1)
                    {
                        c.accountType = AccountType.Savings;
                    }
                    else if (cus.AccType == 2)
                    {
                        c.accountType = AccountType.Current;
                    }
                    else if (cus.AccType == 3)
                    {
                        c.accountType = AccountType.Salary;
                    }
                    else if (cus.AccType == 4)
                    {
                        c.accountType = AccountType.Senior;
                    }
                    else
                    {
                        c.accountType = AccountType.Savings;
                    }
                    er.AddCustomer(c);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
