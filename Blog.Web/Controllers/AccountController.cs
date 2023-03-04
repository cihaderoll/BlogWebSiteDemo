using Blog.Common.Dtos.Account;
using Blog.Core.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(ILogger<HomeController> logger, IAccountService service)
        {
            _accountService = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto data)
        {
            await _accountService.Login(data);

            return Json("Account/Login");
        }
    }
}
