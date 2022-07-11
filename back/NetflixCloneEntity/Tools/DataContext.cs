
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Tools
{
    public class DataContext : DbContext
    {
        //public DbSet<Account> Accounts { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Desktop\Projets\NetflixClone\back\NetflixCloneEntity.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
