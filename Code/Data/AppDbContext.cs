using ApiCrud.Code.Students;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Code.Data
{
    public class AppDbContext: DbContext
    {
        private DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.
            base.OnConfiguring(optionsBuilder);
        }
    }
}
