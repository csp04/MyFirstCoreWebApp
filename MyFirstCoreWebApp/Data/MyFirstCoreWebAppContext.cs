using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstCoreWebApp.Models
{
    public class MyFirstCoreWebAppContext : DbContext
    {
        public MyFirstCoreWebAppContext (DbContextOptions<MyFirstCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstCoreWebApp.Models.Movie> Movie { get; set; }
    }
}
