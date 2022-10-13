
using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata;

namespace CompanySystem.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>()
           .HasOne(b => b.EmployeeId)
           .WithOne(i => i.ForEmployeeId)
           .HasForeignKey<EmployeeDetailsEntity>(b => b.EmployeeId);

            modelBuilder.Entity<DepartmentEntity>()
          .HasOne(b => b.DepartmentId)
          .WithOne(i => i.ForDepartmentId)
          .HasForeignKey<EmployeeDetailsEntity>(b => b.DepartmentId);


            //modelBuilder.Entity<EmployeeEntity>()
            //.HasOne<EmployeeEntity>(s => s.Manager)
            //.WithOne()
            //.HasForeignKey<EmployeeEntity>(ad => ad.ManagerId);



            modelBuilder.Seed();
        }
        public DbSet<PageSectionEntity> PageSections { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EmployeeDetailsEntity> EmployeeDetailss { get; set; }

    }

}

        
        
        
        
    

