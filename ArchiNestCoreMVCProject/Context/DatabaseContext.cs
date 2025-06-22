using ArchiNestCoreMVCProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.Context
{
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V7IDV6Q\\SQLEXPRESS01; Initial Catalog=ArchiNest; Integrated Security=True; TrustServerCertificate=True;");
        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
