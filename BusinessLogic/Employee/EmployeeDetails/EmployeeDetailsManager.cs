using CompanySystem.Common;
using CompanySystem.DAL;


namespace CompanySystem.BusinessLogic.EmployeeDetails
{
    public class EmployeeDetailsManager : IEmployeeDetailsManager
    {
        protected readonly CompanyContext _context;
        public EmployeeDetailsManager(CompanyContext context)
        {
            _context = context;
        }
        public List<EmployeeDetailsEntity> GetAllEmployeeDetails()
        {
            return (_context.EmployeeDetailss.Where(entity => !entity.IsDeleted).ToList());

        }
        public void DeleteEmployeeDetails(int id)
        {  
            var entity = _context.PageSections.FirstOrDefault(entity => entity.Id == id);
            if(entity == null)
                throw new Exception("Page Section Not Found");
            if (!entity.IsDeleted)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                _context.SaveChanges();
                throw new Exception("Page Section Is Deleted");
            }
        }
        public EmployeeDetailsEntity GetEmployeeDetailsById(int id)
        {
            var entity = _context.EmployeeDetailss.FirstOrDefault(x => x.Id == id);
            if (entity == null || id == 0)
                throw new Exception("Page Section Not Found");
            if (entity.IsDeleted)
                throw new Exception("Page Section Is Deleted");
            return entity;
        }
        public EmployeeDetailsEntity CreateUpdate(EmployeeDetailsBo bo, int id = 0)
        {
            var entity = bo.MapBoToEntity();
            if (id == 0)
               _context.Add(entity);
            if (id != 0)
                _context.Update(entity);
            _context.SaveChanges();
            return entity; 
        }
    }
}