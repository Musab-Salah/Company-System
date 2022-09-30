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

                }

                );

        }

    }
}
