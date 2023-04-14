using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YVDB.Models;
using YVDB.Repos;
using YVDB.Repos.IRepos;

namespace YVDB.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CustomerHCController : ControllerBase
    {
        private readonly ICustomerRepoRBI cr;
        private readonly ILogger<CustomerHCController> _logger;
        public CustomerHCController(ILogger<CustomerHCController> logger, ICustomerRepoRBI customerRepoRBI)
        {
            cr = customerRepoRBI;
            _logger = logger;
        }

        [HttpPost(Name = "AddHCBalance")]
        public IActionResult AddCustomerHCBalance(int custId, int balance)
        {
            try
            {
                cr.AddBalance(custId, balance);
                return Ok();
            }
            catch (Exception e) { return BadRequest(); }

        }
        [HttpPost(Name = "WithDrawHCBalance")]
        public IActionResult WithDrawCustomerBalance(int custId, int balance)
        {
            try
            {
                cr.WithDrawBalance(custId, balance);
                return Ok();

            }
            catch (Exception e) { return BadRequest(); }

        }

        [HttpGet(Name = "ShowHCBalance")]
        public IActionResult ShowCustomerBalance(int custId)
        {
            try
            {
                double bal = cr.ShowBalance(custId);
                return Ok(bal);
            }
            catch (Exception e) { return BadRequest("Error while processing the request"); }
        }
    }
}
