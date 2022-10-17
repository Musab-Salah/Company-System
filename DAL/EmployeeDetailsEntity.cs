using CompanySystem.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.DAL
{
    [Table("EmployeeDetails")]
    public class EmployeeDetailsEntity : TrackableData
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
        public DepartmentEntity? DepartmentEntity { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeEntity? EmployeeEntity { get; set; }
 
    }
}
