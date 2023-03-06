using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) 
        {
        }

        public DbSet<Prueba> Pruebas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}