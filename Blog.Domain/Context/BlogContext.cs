using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Context
{
    public class BlogContext: DbContext
    {
        public BlogContext(): base()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer("Data Source=CIHAD; Initial Catalog=BlogDb; User Id=sa; Password=SqlServer2023;Trust Server Certificate=true");
        }
    }
}
