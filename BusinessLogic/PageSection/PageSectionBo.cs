using CompanySystem.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.PageSection
{
    public class PageSectionBo : TrackableData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public int OrderNumber { get; set; }
    }
}
