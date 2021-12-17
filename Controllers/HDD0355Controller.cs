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
    public class HDD0355Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public HDD0355Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: HDD0355
        public async Task<IActionResult> Index()
        {
            return View(await _context.HDD0355.ToListAsync());
        }

        // GET: HDD0355/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDD0355 = await _context.HDD0355
                .FirstOrDefaultAsync(m => m.HDDId == id);
            if (hDD0355 == null)
            {
                return NotFound();
            }

            return View(hDD0355);
        }

        // GET: HDD0355/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HDD0355/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HDDId,HDDname,HDDGender")] HDD0355 hDD0355)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hDD0355);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hDD0355);
        }

        // GET: HDD0355/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDD0355 = await _context.HDD0355.FindAsync(id);
            if (hDD0355 == null)
            {
                return NotFound();
            }
            return View(hDD0355);
        }

        // POST: HDD0355/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HDDId,HDDname,HDDGender")] HDD0355 hDD0355)
        {
            if (id != hDD0355.HDDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hDD0355);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HDD0355Exists(hDD0355.HDDId))
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
            return View(hDD0355);
        }

        // GET: HDD0355/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDD0355 = await _context.HDD0355
                .FirstOrDefaultAsync(m => m.HDDId == id);
            if (hDD0355 == null)
            {
                return NotFound();
            }

            return View(hDD0355);
        }

        // POST: HDD0355/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hDD0355 = await _context.HDD0355.FindAsync(id);
            _context.HDD0355.Remove(hDD0355);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HDD0355Exists(string id)
        {
            return _context.HDD0355.Any(e => e.HDDId == id);
        }
    }
}
