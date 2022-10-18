using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.EmployeeDetails
{
    public interface IEmployeeDetailsManager
    {
        List<EmployeeDetailsEntity> GetAllEmployeeDetails();
        void DeleteEmployeeDetails(int id);
        EmployeeDetailsEntity GetEmployeeDetailsById(int id);
        EmployeeDetailsEntity CreateUpdate(EmployeeDetailsBo bo, int id = 0);
    }
}
