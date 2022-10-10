
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<PageSectionEntity> PageSections { get; set; }
    }

}

        
        
        
        
    

