using CompanySystem.Common;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.Employee
{
    public class EmployeeBo : TrackableData
    {
        [Key]
        public int Id { get; set; }
        public string? SN { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public int ManagerId { get; set; }
    }
}
