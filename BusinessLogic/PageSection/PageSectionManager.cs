using CompanySystem.Common;
using CompanySystem.DAL;


namespace CompanySystem.BusinessLogic.PageSection
{
    public class PageSectionManager : IPageSectionManager
    {
        protected readonly CompanyContext _context;
        public PageSectionManager(CompanyContext context)
        {
            _context = context;
        }
        public List<PageSectionEntity>GetAllPageSection()
        {
            var t = _context.PageSections.Where(entity => !entity.IsDeleted).ToList();
            return t;
        }
        public void DeleteSection(int id)
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
        public PageSectionEntity GetSectionById(int id)
        {
            var entity = _context.PageSections.FirstOrDefault(x => x.Id == id);
            if (entity == null || id == 0)
                throw new Exception("Page Section Not Found");
            if (entity.IsDeleted)
                throw new Exception("Page Section Is Deleted");
            return entity;
        }
        public PageSectionEntity CreateUpdate(PageSectionBo bo, int id = 0)
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