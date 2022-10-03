using CompanySystem.DAL;

namespace CompanySystem.BusinessLogic.PageSection
{
    public static class PageSectionMapping
    {
        public static PageSectionEntity MapBoToEntity(this PageSectionBo bo)
        {
            return new PageSectionEntity
            {
                Id = bo.Id,
                Title = bo.Title,
                Description = bo.Description,
                OrderNumber = bo.OrderNumber,
                CreatedBy = bo.CreatedBy,
                CreatedOn = bo.CreatedOn,
                ModifiedBy = bo.ModifiedBy,
                ModifiedOn = bo.ModifiedOn,
                IsDeleted = bo.IsDeleted
            };
        }
    }
}
