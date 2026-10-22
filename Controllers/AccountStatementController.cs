using Microsoft.AspNetCore.Mvc;

namespace Bank_App.Controllers
{
    public class AccountStatementController : Controller
    {
        
        // GET: AccountStatementController
        private readonly IWebHostEnvironment _env;
        public AccountStatementController(IWebHostEnvironment env)
        {
            _env = env;
        }
        [Route("Account-statement")]
        public IActionResult AccountStatement()
        {
            var path = Path.Combine(
                _env.ContentRootPath,
                "StatementFolder",
                "Bank_statement.pdf"
            );
            if (!Path.Exists(path))
            {
                return NotFound("Not found");
            }
            return PhysicalFile(path,"application/pdf");
        }


    }
}
