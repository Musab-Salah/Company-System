using CompanySystem.DAL;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.BusinessLogic.PageSection
{
    public class PageSectionManager : IPageSectionManager
    {

        protected readonly CompanyContext _context;

        public PageSectionManager(CompanyContext context)
        {
            _context = context;
        }

        public List<PageSectionEntity> GetAll()
        {
            var allpagecontent = _context.PageSections.Where(x => !x.IsDeleted).ToList();

            return allpagecontent;
        }

        public void DeleteSection(int id)
        {
            var entity = _context.PageSections.FirstOrDefault(x => x.Id == id);

            if (  entity.IsDeleted == false)
            {
                entity.IsDeleted = true;
                _context.Update(entity);
                _context.SaveChanges();
            }

        }
        public PageSectionEntity GetSectionById(int id)
        {
            if (id != 0) { 
            var Page = _context.PageSections.FirstOrDefault(x => x.Id == id);
            PageSectionEntity pageContentbyid = new PageSectionEntity();
                //pageContentbyid.Id = Page.Id;
            pageContentbyid.Title = Page.Title;
            pageContentbyid.Description = Page.Description;
            pageContentbyid.OrderNumber = Page.OrderNumber;
            pageContentbyid.IsDeleted = Page.IsDeleted;
            return pageContentbyid;
            }
            PageSectionEntity EBO=new PageSectionEntity();
            
            return EBO;
        }

        public PageSectionEntity CreateUpdate(PageSectionBo bo, int id = 0)
        {
            var c = bo.MapBoToEntity();
            if (id == 0)
            {
               
                _context.Add(c);
                _context.SaveChanges();
                return c;
            }
           ///// need repair
            _context.Update(c);
            _context.SaveChanges();
            return c;
        }
    }
}



