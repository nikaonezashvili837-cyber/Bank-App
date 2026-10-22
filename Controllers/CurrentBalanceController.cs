using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class CurrentBalanceController : Controller
    {
        // GET: CurrentBalanceController
        [Route("get-current-balance/{accountNumber:int}")]
        public IActionResult CurrentBalance(int accountNumber)
        {
            Account account = new Account();
            
            if(accountNumber != account.AccountNumber )
            {
                return NotFound("account number is incorect");
            }
            return Ok($"Balance: {account.CurrentBalance}");
        }

    }
}
