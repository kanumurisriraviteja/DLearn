using Microsoft.AspNetCore.Mvc;
using YVDB.Models;
using YVDB.Repos;
using YVDB.Repos.IRepos;

namespace YVDB.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo er;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepo erepo)
        {
            er = erepo;
            _logger = logger;
        }

        [HttpGet(Name = "ShowCustomers")]
        public List<CustomerDTO> ShowCustomers()
        {
            return er.GiveCustomers();

        }

        [HttpPost(Name = "AddCustomers")]
        public IActionResult AddCustomer([FromBody] CustomerDTO cus)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CustomerDTO c = new CustomerDTO
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
