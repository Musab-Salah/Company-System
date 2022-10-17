using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.Department
{
    public interface IDepartmentManager
    {
        List<DepartmentEntity> GetAllDepartment();
        void DeleteDepartment(int id);
        DepartmentEntity GetDepartmentById(int id);
        DepartmentEntity CreateUpdate(DepartmentBo bo, int id = 0);
    }
}
