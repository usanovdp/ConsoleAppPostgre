using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppPostgre
{
    using Microsoft.EntityFrameworkCore;
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

 //       public ApplicationContext()
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=admin");
//        }
    }
}

