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

        public IActionResult Index()
        {
            var c = _manager.GetAll().OrderBy(m => m.OrderNumber);
           
            return View(c);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
         PageSectionEntity pageSectionEntity = _manager.GetSectionById(id);


            return View("Create", pageSectionEntity);

        }

        [HttpPost]
        public IActionResult Edit(PageSectionBo bo )
        {
            

            if (ModelState.IsValid)
            {
                if (bo.Id == 0)
                    _manager.AddSection(bo);
                else
                    _manager.UpdateSection(bo);
               
                return RedirectToAction("Index", "PageSection");
            }

            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult Delete(PageSectionBo bo)
        {
           // PageSectionEntity pageSectionEntity = _manager.GetSectionById(id);
            _manager.DeleteSection( bo);

            return RedirectToAction("Index", "PageSection");
        }

        //
        //WORK ON METHOD FOR IS DELETE LATER
        //
        //[HttpPost]
        //public IActionResult Delete(PageSectionBo bo )
        //{
        //    _manager.DeleteSection(bo);
                
        //    return RedirectToAction("Index", "PageSection");
        //}


    }
}
