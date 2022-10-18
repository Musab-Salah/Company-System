using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.Department
{
    public class DepartmentManager : IDepartmentManager
    {
        protected readonly CompanyContext _context;
        public DepartmentManager(CompanyContext context)
        {
            _context = context;
        }
        public List<DepartmentEntity> GetAllDepartment()
        {
            return(_context.Departments.Where(entity => !entity.IsDeleted).ToList());
        }
        public void DeleteDepartment(int id)
        {  
            var entity = _context.Departments.FirstOrDefault(entity => entity.Id == id);
            if(entity == null)
                throw new Exception("Department Not Found");
            if (!entity.IsDeleted)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                _context.SaveChanges();
                throw new Exception("Department Is Deleted");
            }
        }
        public DepartmentEntity GetDepartmentById(int id)
        {
            var entity = _context.Departments.FirstOrDefault(x => x.Id == id);
            if (entity == null || id == 0)
                throw new Exception("Department Not Found");
            if (entity.IsDeleted)
                throw new Exception("Department Is Deleted");
            return entity;
        }
        public DepartmentEntity CreateUpdate(DepartmentBo bo, int id = 0)
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