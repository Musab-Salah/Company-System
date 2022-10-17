using CompanySystem.BusinessLogic.Department;
using Microsoft.AspNetCore.Mvc;


namespace CompanySystem.API.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentManager _manager;
        public DepartmentController(IDepartmentManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_manager.GetAllDepartment());
        }
        [HttpPost]
        public IActionResult Create([FromBody] DepartmentBo bo)
        {
            if(ModelState.IsValid)
               return Ok(_manager.CreateUpdate(bo));
             return BadRequest("Wrong Information");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _manager.DeleteDepartment(id);
            return Ok("Is Deleted");
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_manager.GetDepartmentById(id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] DepartmentBo bo, [FromRoute] int id)
        {
            if(bo == null)
                return BadRequest("Department Not Found");
            if(!bo.IsDeleted)
                return Ok(_manager.CreateUpdate(bo, id));
            return NotFound("Department Is Deleted");
        }
    }
}
