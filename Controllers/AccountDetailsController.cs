using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    
    public class AccountDetailsController : Controller
    {
        // GET: AccountDetails
        [Route("Account-details")]
        public IActionResult Details()
        {
            Account account = new Account();
            return Ok(account);
        }
    }
}
