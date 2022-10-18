
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Security.Principal;

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
                .HasOne<EmployeeDetailsEntity>(s => s.EmployeeDetailsR)
                .WithOne(ad => ad.EmployeeEntity)
                .HasForeignKey<EmployeeDetailsEntity>(ad => ad.EmployeeId);

            modelBuilder.Entity<EmployeeDetailsEntity>()
                .HasOne<DepartmentEntity>(s => s.DepartmentEntity)
                .WithMany(g => g.EmployeeDetailsForDepartment)
                .HasForeignKey(s => s.DepartmentId);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(a => a.Manger)
                .WithMany()
                .HasForeignKey(a => a.Id);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(a => a.Manger)
                .WithMany(b => b.Employee)
                .HasForeignKey(a => a.ManagerId);

            modelBuilder.Seed();
        }
        public DbSet<PageSectionEntity> PageSections { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EmployeeDetailsEntity> EmployeeDetailss { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }

    }

}

        
        
        
        
    

