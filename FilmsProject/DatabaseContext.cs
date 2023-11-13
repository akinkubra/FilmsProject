using FilmProject.Entities;

using Microsoft.EntityFrameworkCore;

namespace FilmProject
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=N305361\\SQLSERVER2017;Database=Film;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}
