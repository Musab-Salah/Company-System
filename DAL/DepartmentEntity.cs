﻿using CompanySystem.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.DAL
{
    [Table("Department")]
    public class DepartmentEntity : TrackableData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Prefix { get; set; }
        [Required]
        public string? Description { get; set; }



        public ICollection<EmployeeDetailsEntity>? EmployeeDetailsForDepartment { get; set; }
        
    }
}
