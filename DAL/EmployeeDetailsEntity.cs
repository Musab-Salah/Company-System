using CompanySystem.Common;
using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.DAL
{
    [Table("EmployeeDetails")]
    public class EmployeeDetailsEntity : TrackableData
    {
        
        public int Id { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }


        public int DepartmentId { get; set; }
        public DepartmentEntity ForDepartmentId { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeEntity ForEmployeeId { get; set; }
 
    }
}
