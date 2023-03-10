using Blog.Common.Dtos.Account;
using Blog.Core.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Blog.Core.Services.Concrete
{
    public class AccountService : IAccountService
    {
        public SignInManager<IdentityUser> _signInManager { get; set; }
        public UserManager<IdentityUser> _userManager { get; set; }

        public AccountService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task Login(LoginDto dto)
        {
            var user = await _userManager.FindByNameAsync(dto.UserName);
            if (user == null)
                return;

            try
            {
                var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

                if (result.Succeeded)
                {
                    var claims = await _userManager.GetClaimsAsync(user);

                    await _userManager.AddClaimAsync(user, new Claim("UserName", user.UserName));
                }

            }
            catch (Exception ex)
            {
                var a = ex;
            }

            return;
        }
    }
}
