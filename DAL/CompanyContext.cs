
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.DAL
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CompanyDB;Trusted_Connection=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<PageSectionEntity> PageSections { get; set; }

    }

}

        
        
        
        
    

