using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Common.Dtos.Account;
using Microsoft.AspNetCore.Identity;

namespace Blog.Core.Services.Abstract
{
    public interface IAccountService
    {
        Task Login(LoginDto dto);
    }
}
