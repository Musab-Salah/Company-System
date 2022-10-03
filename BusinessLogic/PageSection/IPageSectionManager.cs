using CompanySystem.DAL;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.PageSection
{
    public interface IPageSectionManager
    {
       
        List<PageSectionEntity> GetAll();

        void DeleteSection (int id);

        PageSectionEntity GetSectionById(int id);

        PageSectionEntity CreateUpdate(PageSectionBo bo, int id = 0);

    }
}
