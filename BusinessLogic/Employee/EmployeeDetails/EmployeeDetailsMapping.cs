using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.EmployeeDetails
{
    public static class EmployeeMapping
    {
        public static EmployeeDetailsEntity? MapBoToEntity(this EmployeeDetailsBo bo)
        {
            if (bo == null) return null;
            return new EmployeeDetailsEntity
            {
                Id = bo.Id,
                PhoneNumber = bo.PhoneNumber,
                Gender = bo.Gender,
                StartDate = bo.StartDate,
                DepartmentId = bo.DepartmentId,
                EmployeeId = bo.EmployeeId,
                CreatedBy = bo.CreatedBy,
                CreatedOn = bo.CreatedOn,
                ModifiedBy = bo.ModifiedBy,
                ModifiedOn = bo.ModifiedOn,
                IsDeleted = bo.IsDeleted
            };
        }
    }
}
