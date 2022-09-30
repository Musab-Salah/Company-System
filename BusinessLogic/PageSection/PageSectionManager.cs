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
           var List = new List<PageSectionEntity>();

           var allpagecontent = _context.PageSections.ToList();

            foreach (var pageContentEntity in allpagecontent)
            {
                
               if(pageContentEntity.IsDeleted == false) { 
               List.Add(new PageSectionEntity()
               {
                   Id = pageContentEntity.Id,
                   Title = pageContentEntity.Title,
                   Description = pageContentEntity.Description,
                   OrderNumber = pageContentEntity.OrderNumber,

               });
                }
            }
            return List;
        }

        public void AddSection(PageSectionBo pageContentBo)
        {
          
           var c = pageContentBo.MapBoToEntity();
            _context.Add(c);

            _context.SaveChanges();

        }
        public void DeleteSection(PageSectionBo pageContentBo)
        {

           var c = pageContentBo.MapBoToEntity();

            _context.Remove(c);

            _context.SaveChanges();
        }
        public PageSectionEntity GetSectionById(int id)
        {
            var Page = _context.PageSections.FirstOrDefault(x => x.Id == id);
            PageSectionEntity pageContentbyid = new PageSectionEntity();
           
            pageContentbyid.Title = Page.Title;
            pageContentbyid.Description = Page.Description;
            pageContentbyid.OrderNumber = Page.OrderNumber;

            return pageContentbyid;
        }

        public void UpdateSection(PageSectionBo pageContentBo)
        {
            var c = pageContentBo.MapBoToEntity();

           _context.Update(c);
           _context.SaveChanges();

        }

        public int GetId(PageSectionBo pageContentBo)
        {
            PageSectionEntity c = pageContentBo.MapBoToEntity();

            
            
             return c.Id;
        }  
    }

}

