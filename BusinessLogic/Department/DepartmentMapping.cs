using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.Department
{
    public static class EmployeeMapping
    {
        public static DepartmentEntity? MapBoToEntity(this DepartmentBo bo)
        {
            if (bo == null) return null;
            return new DepartmentEntity
            {
                Id = bo.Id,
                Name = bo.Name,
                Prefix = bo.Prefix,
                Description = bo.Description,
                CreatedBy = bo.CreatedBy,
                CreatedOn = bo.CreatedOn,
                ModifiedBy = bo.ModifiedBy,
                ModifiedOn = bo.ModifiedOn,
                IsDeleted = bo.IsDeleted
            };
        }
    }
}
