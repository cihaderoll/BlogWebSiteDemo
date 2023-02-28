using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Domains
{
    [Table("Users", Schema = "User")]
    public class User: IdentityUser<int>
    {
        public string PhotoPath { get; set; }
    }
}
