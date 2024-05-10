using CRUD_operations.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_operations.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; } 
    }
}
