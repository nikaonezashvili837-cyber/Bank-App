using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class AccountDetails : Controller
    {
        // GET: AccountDetails
        [Route("Account-details")]
        public IActionResult Details()
        {
            var json = new 
            {
                accountNumber = 1001,
                accountHolderName= "Example Name",
                currentBalance = 5000,
            };
            return Ok(json);
        }
    }
}
