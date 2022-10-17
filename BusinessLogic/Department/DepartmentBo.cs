using CompanySystem.Common;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.Department
{
    public class DepartmentBo : TrackableData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Prefix { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
