using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Category
            //modelBuilder.Entity<Category>().HasKey(x => x.Id);

            //modelBuilder.Entity<Category>(entity =>
            //entity.Property(x => x.Name).IsRequired()
            //);
        }

    }
}
