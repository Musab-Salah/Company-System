using CompanySystem.Common;
using CompanySystem.DAL;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.BusinessLogic.EmployeeDetails
{
    public class EmployeeDetailsBo : TrackableData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public int DepartmentId { get; set; }

        public int EmployeeId { get; set; }
    }
}
