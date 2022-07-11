
using Microsoft.EntityFrameworkCore;
using NetflixCloneEntity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Resource> resources{ get; set; }
        public DbSet<Faq> faqs{ get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Desktop\Projets\NetflixClone\back\NetflixCloneEntity.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
