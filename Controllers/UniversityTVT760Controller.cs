using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranVanTuyen760.Models;

namespace TranVanTuyen760.Controllers
{
    public class UniversityTVT760Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public UniversityTVT760Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: UniversityTVT760
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityTVT760.ToListAsync());
        }

        // GET: UniversityTVT760/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTVT760 = await _context.UniversityTVT760
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityTVT760 == null)
            {
                return NotFound();
            }

            return View(universityTVT760);
        }

        // GET: UniversityTVT760/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityTVT760/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityTVT760 universityTVT760)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityTVT760);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityTVT760);
        }

        // GET: UniversityTVT760/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTVT760 = await _context.UniversityTVT760.FindAsync(id);
            if (universityTVT760 == null)
            {
                return NotFound();
            }
            return View(universityTVT760);
        }

        // POST: UniversityTVT760/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityTVT760 universityTVT760)
        {
            if (id != universityTVT760.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityTVT760);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityTVT760Exists(universityTVT760.UniversityId))
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
            return View(universityTVT760);
        }

        // GET: UniversityTVT760/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTVT760 = await _context.UniversityTVT760
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityTVT760 == null)
            {
                return NotFound();
            }

            return View(universityTVT760);
        }

        // POST: UniversityTVT760/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityTVT760 = await _context.UniversityTVT760.FindAsync(id);
            _context.UniversityTVT760.Remove(universityTVT760);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityTVT760Exists(string id)
        {
            return _context.UniversityTVT760.Any(e => e.UniversityId == id);
        }
    }
}
