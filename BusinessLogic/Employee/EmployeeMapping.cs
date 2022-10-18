using CompanySystem.Common;
using CompanySystem.DAL;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.BusinessLogic.Employee
{
    public static class EmployeeMapping 
    {
        public static EmployeeEntity? MapBoToEntity(this EmployeeBo bo)
        {
            if (bo == null) return null;
            return new EmployeeEntity
            {
                Id = bo.Id,
                SN= bo.SN,
                FullName = bo.FullName,
                Email = bo.Email,
                Password= bo.Password,
                ManagerId= bo.ManagerId,
                CreatedBy = bo.CreatedBy,
                CreatedOn = bo.CreatedOn,
                ModifiedBy = bo.ModifiedBy,
                ModifiedOn = bo.ModifiedOn,
                IsDeleted = bo.IsDeleted
            };
        }
    }
}
