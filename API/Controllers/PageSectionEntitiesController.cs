using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanySystem.DAL;

namespace CompanySystem.API.Controllers
{
    public class PageSectionEntitiesController : Controller
    {
        private readonly CompanyContext _context;

        public PageSectionEntitiesController(CompanyContext context)
        {
            _context = context;
        }

        // GET: PageSectionEntities
        public async Task<IActionResult> Index()
        {
              return View(await _context.PageSections.ToListAsync());
        }

        // GET: PageSectionEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PageSectionEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,OrderNumber,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,IsDeleted")] PageSectionEntity pageSectionEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pageSectionEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pageSectionEntity);
        }

        // GET: PageSectionEntities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PageSections == null)
            {
                return NotFound();
            }

            var pageSectionEntity = await _context.PageSections.FindAsync(id);
            if (pageSectionEntity == null)
            {
                return NotFound();
            }
            return View(pageSectionEntity);
        }

        // POST: PageSectionEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,OrderNumber,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,IsDeleted")] PageSectionEntity pageSectionEntity)
        {
            if (id != pageSectionEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pageSectionEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageSectionEntityExists(pageSectionEntity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pageSectionEntity);
        }

        // GET: PageSectionEntities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PageSections == null)
            {
                return NotFound();
            }

            var pageSectionEntity = await _context.PageSections
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pageSectionEntity == null)
            {
                return NotFound();
            }

            return View(pageSectionEntity);
        }

        // POST: PageSectionEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PageSections == null)
            {
                return Problem("Entity set 'CompanyContext.PageSections'  is null.");
            }
            var pageSectionEntity = await _context.PageSections.FindAsync(id);
            if (pageSectionEntity != null)
            {
                _context.PageSections.Remove(pageSectionEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PageSectionEntityExists(int id)
        {
          return _context.PageSections.Any(e => e.Id == id);
        }
    }
}
