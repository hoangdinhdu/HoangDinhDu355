using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangDinhDu355.Models;

namespace HoangDinhDu355.Controllers
{
    public class CompanyHDD355Controller : Controller
    {
        private readonly MvcMovieContext _context;
        StringProcessHDD355 strPro = new StringProcessHDD355();

        public CompanyHDD355Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CompanyHDD355
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyHDD355.ToListAsync());
        }

        // GET: CompanyHDD355/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyHDD355 = await _context.CompanyHDD355
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyHDD355 == null)
            {
                return NotFound();
            }

            return View(companyHDD355);
        }

        // GET: CompanyHDD355/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyHDD355/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyHDD355 companyHDD355)
        {
            if (ModelState.IsValid)
            {
                companyHDD355.CompanyName =  strPro.LowerToUpper(companyHDD355.CompanyName);
                _context.Add(companyHDD355);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyHDD355);
        }

        // GET: CompanyHDD355/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyHDD355 = await _context.CompanyHDD355.FindAsync(id);
            if (companyHDD355 == null)
            {
                return NotFound();
            }
            return View(companyHDD355);
        }

        // POST: CompanyHDD355/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyHDD355 companyHDD355)
        {
            if (id != companyHDD355.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyHDD355);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyHDD355Exists(companyHDD355.CompanyId))
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
            return View(companyHDD355);
        }

        // GET: CompanyHDD355/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyHDD355 = await _context.CompanyHDD355
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyHDD355 == null)
            {
                return NotFound();
            }

            return View(companyHDD355);
        }

        // POST: CompanyHDD355/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyHDD355 = await _context.CompanyHDD355.FindAsync(id);
            _context.CompanyHDD355.Remove(companyHDD355);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyHDD355Exists(string id)
        {
            return _context.CompanyHDD355.Any(e => e.CompanyId == id);
        }
    }
}
