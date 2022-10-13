namespace CompanySystem.DAL
{
    public class DepartmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }



        public EmployeeDetailsEntity DepartmentId { get; set; }
        
    }
}
