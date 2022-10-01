using CompanySystem.DAL;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.PageSection
{
    public interface IPageSectionManager
    {
       
        List<PageSectionEntity> GetAll();

        void AddSection(PageSectionBo pageContentBo);

        void UpdateSection(PageSectionBo pageContentBo);

        void DeleteSection (PageSectionBo pageContentBo);

        PageSectionEntity GetSectionById(int id);

        int GetId(PageSectionBo pageContentBo);

    }
}
