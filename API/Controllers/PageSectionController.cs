using CompanySystem.BusinessLogic.PageSection;
using Microsoft.AspNetCore.Mvc;


namespace CompanySystem.API.Controllers
{
    public class PageSectionController : Controller
    {
        private readonly IPageSectionManager _manager;
        public PageSectionController(IPageSectionManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_manager.GetAllPageSection().OrderBy(m => m.OrderNumber));
        }
        [HttpPost]
        public IActionResult Create([FromBody] PageSectionBo bo)
        {
            if(ModelState.IsValid)
             return Ok(_manager.CreateUpdate(bo));
             return BadRequest("Wrong Information");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _manager.DeleteSection(id);
            return Ok("Is Deleted");
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_manager.GetSectionById(id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] PageSectionBo bo, [FromRoute] int id)
        {
            if(bo == null)
                return BadRequest("Page Section Not Found");
            if(!bo.IsDeleted)
                return Ok(_manager.CreateUpdate(bo, id));
            return NotFound("Page Section Is Deleted");
        }
    }
}
