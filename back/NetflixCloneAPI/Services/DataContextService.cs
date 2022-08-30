using Microsoft.EntityFrameworkCore;
using NetflixCloneAPI.Models;

namespace NetflixCloneAPI.Services
{
    public class DataContextService : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Genre_resource> Genre_resources { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Desktop\Projets\NetflixClone\back\NetflixCloneDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

    }
}
