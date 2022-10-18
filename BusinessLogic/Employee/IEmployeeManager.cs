using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.Employee
{
    public interface IEmployeeManager
    {
        List<EmployeeEntity> GetAllEmployee();
        void DeleteEmployee(int id);
        EmployeeEntity GetEmployeeById(int id);
        EmployeeEntity CreateUpdate(EmployeeBo bo, int id = 0);

    }
}
