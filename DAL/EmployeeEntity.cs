using CompanySystem.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.DAL
{
    [Table("Employee")]
    public class EmployeeEntity : TrackableData
    {
        [Key]
        public int Id { get; set; }
        [Unicode]
        public string SN { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int ManagerId { get; set; } //need self rel
        public EmployeeDetailsEntity EmployeeId { get; set; }

        //public EmployeeEntity Manager { get; set; }
       

       

    }
}
