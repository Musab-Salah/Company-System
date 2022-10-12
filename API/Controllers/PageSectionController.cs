using CompanySystem.BusinessLogic.PageSection;
using CompanySystem.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CompanySystem.API.Controllers
{


    public class PageSectionController : Controller
    {

        private readonly ILogger<PageSectionController> _logger;
        private readonly IPageSectionManager _manager;


        public PageSectionController(ILogger<PageSectionController> logger, IPageSectionManager manager)
        {
            _logger = logger;
            _manager = manager;

        }
        [HttpGet]
        public IActionResult Index ()
        {
            var c = _manager.GetAll().OrderBy(m => m.OrderNumber); ;

            return Ok(c);
        }
        [HttpPost]
        public IActionResult Create([FromBody] PageSectionBo bo)
        {
            if (ModelState.IsValid)
            {

                var c = _manager.CreateUpdate(bo);
                return Ok(c);
            }
            return BadRequest("nullinput");
          
        }
        [HttpDelete]
        public IActionResult Delete( int id)
        {
            _manager.DeleteSection(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            var entity = _manager.GetSectionById(id);
            return Ok(entity);
        }
        [HttpPut]
        public IActionResult Update([FromBody] PageSectionBo bo, [FromRoute] int id)
        {
            
            if (bo.IsDeleted == false)
            {
                var cc = _manager.CreateUpdate(bo, id);
                return Ok(cc);
            }
            return BadRequest("Nullinput Or Deleted");
        }
    }
}
