using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class CurrentBalanceController : Controller
    {
        // GET: CurrentBalanceController
        [Route("get-current-balance/{accountNumber:int}")]
        public IActionResult CurrentBalance(int accountNumber)
        {
            if(accountNumber != 1001)
            {
                return NotFound("account number is incorect");
            }
            return Ok($"Balance: 5000");
        }

    }
}
