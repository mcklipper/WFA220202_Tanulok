using Microsoft.EntityFrameworkCore;
using Students.Models;

namespace Students.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"Data Source = (localdb)\MSSQLLocalDB; " +
                "Initial Catalog = students; " +
                "Integrated Security = True;"
            );

            base.OnConfiguring(options);
        }

    }
}
