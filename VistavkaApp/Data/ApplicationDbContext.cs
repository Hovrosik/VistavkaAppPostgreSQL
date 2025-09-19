using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VistavkaApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Vistavka> Vistavkas {get; set;}
        public DbSet<Posetitel> Posetitels {get; set;}
        public DbSet<Bilet> Bilets {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка формата даты для PostgreSQL
            modelBuilder.Entity<Bilet>()
                .Property(e => e.DateOfVisit)
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Vistavka>()
                .Property(e => e.DateBegin)
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Vistavka>()
                .Property(e => e.DateEnd)
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Posetitel>()
                .Property(e => e.DateOfBirth)
                .HasColumnType("timestamp without time zone");
        }
    }
}
