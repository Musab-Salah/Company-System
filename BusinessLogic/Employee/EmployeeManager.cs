using CompanySystem.Common;
using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.Employee
{
    public class EmployeeManager : IEmployeeManager
    {
        protected readonly CompanyContext _context;
        public EmployeeManager(CompanyContext context)
        {
            _context = context;
        }
        public List<EmployeeEntity> GetAllEmployee()
        {
           return (_context.Employees.Where(entity => !entity.IsDeleted).ToList()); 
        }
        public void DeleteEmployee(int id)
        {
            var entity = _context.Employees.FirstOrDefault(entity => entity.Id == id);
            if (entity == null)
                throw new Exception("Employees Not Found");
            if (!entity.IsDeleted)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                _context.SaveChanges();
                throw new Exception("Employees Is Deleted");
            }
        }
        public EmployeeEntity GetEmployeeById(int id)
        {
            var entity = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (entity == null || id == 0)
                throw new Exception("Employees Not Found");
            if (entity.IsDeleted)
                throw new Exception("Employees Is Deleted");
            return entity;
        }
        public EmployeeEntity CreateUpdate(EmployeeBo bo, int id = 0)
        {
            var entity = bo.MapBoToEntity();
            entity.Password = Security.Encrypt_Password(entity.Password);
            
            //entity.SN = /* Add Prefix + */ "-" + SerialNoGenerator.RandomString();
            if (id == 0)
                _context.Add(entity);
            if (id != 0)
                _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
