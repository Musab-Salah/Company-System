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
        public string? SN { get; set; }
        [Unicode]
        public string? Email { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Password { get; set; }
        public int ManagerId { get; set; }

        public EmployeeDetailsEntity? EmployeeDetailsR { get; set; }

        public ICollection<EmployeeEntity>? Employee { get; set; }
        public EmployeeEntity? Manger { get; set; }

        //[NotMapped]
        //public string DecryptedPassword
        //{
        //    get { return EncryptionDecryptionPass.Decrypt_Password(Password); }
        //    set { Password = EncryptionDecryptionPass.Decrypt_Password(value); }
        //}
    }
}
