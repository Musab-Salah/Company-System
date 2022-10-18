using CompanySystem.BusinessLogic.EmployeeDetails;
using Microsoft.AspNetCore.Mvc;


namespace CompanySystem.API.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        private readonly IEmployeeDetailsManager _manager;
        public EmployeeDetailsController(IEmployeeDetailsManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_manager.GetAllEmployeeDetails());
        }
        [HttpPost]
        public IActionResult Create([FromBody] EmployeeDetailsBo bo)
        {
            if(ModelState.IsValid)
             return Ok(_manager.CreateUpdate(bo));
             return BadRequest("Wrong Information");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _manager.DeleteEmployeeDetails(id);
            return Ok("Is Deleted");
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_manager.GetEmployeeDetailsById(id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] EmployeeDetailsBo bo, [FromRoute] int id)
        {
            if(bo == null)
                return BadRequest("Page Section Not Found");
            if(!bo.IsDeleted)
                return Ok(_manager.CreateUpdate(bo, id));
            return NotFound("Page Section Is Deleted");
        }
    }
}
