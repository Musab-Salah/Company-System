using CompanySystem.BusinessLogic.Employee;
using Microsoft.AspNetCore.Mvc;


namespace CompanySystem.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeManager _manager;
        public EmployeeController(IEmployeeManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_manager.GetAllEmployee());
        }
        [HttpPost]
        public IActionResult Create([FromBody] EmployeeBo bo)
        {
            if (ModelState.IsValid)
                return Ok(_manager.CreateUpdate(bo));
            return BadRequest("Wrong Information");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _manager.DeleteEmployee(id);
            return Ok("Is Deleted");
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_manager.GetEmployeeById(id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] EmployeeBo bo, [FromRoute] int id)
        {
            if(bo == null)
                return BadRequest("Department Not Found");
            if(!bo.IsDeleted)
                return Ok(_manager.CreateUpdate(bo, id));
            return NotFound("Department Is Deleted");
        }
    }
}
