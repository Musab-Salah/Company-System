using Microsoft.EntityFrameworkCore;

namespace CompanySystem.DAL
{
    public static class CompanySystemSeed
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PageSectionEntity>().HasData(

                new PageSectionEntity
                {
                    Id = 1,
                    OrderNumber = 0,
                    Title = "Musab",
                    Description = "First Description",
                    CreatedBy = "Musab",
                    CreatedOn = DateTime.Now,
                   IsDeleted = false,
                   ModifiedBy  = "SALAH",
                   ModifiedOn = DateTime.Now,

                },

                 new PageSectionEntity
                 {
                     Id = 2,
                     OrderNumber = 0,
                     Title = "test",
                     Description = "First Description",
                     CreatedBy = "Musab",
                     CreatedOn = DateTime.Now,
                     IsDeleted = true,
                     ModifiedBy = "SALAH",
                     ModifiedOn = DateTime.Now,

                 }

                );

            modelBuilder.Entity<EmployeeEntity>().HasData(

                new EmployeeEntity
                {
                    Id = 1,
                    ManagerId = 1,
                  FullName = "Manger",
                  Password = "dsf32dsf",
                    CreatedBy = "Musab",
                    CreatedOn = DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "SALAH",
                    ModifiedOn = DateTime.Now,
                }
                );

        }

    }
}
