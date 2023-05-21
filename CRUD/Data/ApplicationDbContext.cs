using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }



    }
}
