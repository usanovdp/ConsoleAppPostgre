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
        readonly StreamWriter logStream = new StreamWriter("f:\\sqlite\\myPostgreLog.txt", true);
        public DbSet<User> Users { get; set; } = null!;

 //       public ApplicationContext()
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
//        public override void Dispose()
//       {
//            base.Dispose();
//            logStream.Dispose();
//        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=admin");
            optionsBuilder.LogTo(logStream.WriteLine);
        }
    }
}

