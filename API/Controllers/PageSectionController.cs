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
        public IActionResult Index()
        {
            var c = _manager.GetAll().OrderBy(m => m.OrderNumber);
           
            return View(c);
        }
        [HttpGet]
        public IActionResult Get(int id ){
            if (id == 0)
                return View("Create");

            var entity = _manager.GetSectionById(id);
            return View("Update", entity);
        }
        [HttpPost]
        public IActionResult Create(PageSectionBo bo )
        {
            if (ModelState.IsValid) { 
            var c = _manager.CreateUpdate(bo);

             return RedirectToAction("Index", c);
            }
            return View();
        }
        [HttpPut]
        [Route("{Controller}/Update/{id}")]
        public IActionResult Update(PageSectionBo bo, int id)
        {
            if (ModelState.IsValid) { 
                var c = _manager.CreateUpdate(bo, id);
            return RedirectToAction("Index", c);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _manager.DeleteSection(id);
            return RedirectToAction("Index");
        }

       

    }
}
