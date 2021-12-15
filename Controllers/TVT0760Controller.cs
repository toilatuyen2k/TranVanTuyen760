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
    public class TVT0760Controller : Controller
    {
        StringProcessTVT760 str = new StringProcessTVT760();
        private readonly MvcMovieContext _context;

        public TVT0760Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: TVT0760
        public async Task<IActionResult> Index()
        {
            return View(await _context.TVT0760.ToListAsync());
        }

        // GET: TVT0760/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVT0760 = await _context.TVT0760
                .FirstOrDefaultAsync(m => m.TVTId == id);
            if (tVT0760 == null)
            {
                return NotFound();
            }

            return View(tVT0760);
        }

        // GET: TVT0760/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TVT0760/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TVTId,TVTName,TVTGender")] TVT0760 tVT0760)
        {
            if (ModelState.IsValid)
            {
                tVT0760.TVTName = str.LowerToUpper(tVT0760.TVTName);
                _context.Add(tVT0760);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tVT0760);
        }

        // GET: TVT0760/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVT0760 = await _context.TVT0760.FindAsync(id);
            if (tVT0760 == null)
            {
                return NotFound();
            }
            return View(tVT0760);
        }

        // POST: TVT0760/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TVTId,TVTName,TVTGender")] TVT0760 tVT0760)
        {
            if (id != tVT0760.TVTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tVT0760);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TVT0760Exists(tVT0760.TVTId))
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
            return View(tVT0760);
        }

        // GET: TVT0760/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tVT0760 = await _context.TVT0760
                .FirstOrDefaultAsync(m => m.TVTId == id);
            if (tVT0760 == null)
            {
                return NotFound();
            }

            return View(tVT0760);
        }

        // POST: TVT0760/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tVT0760 = await _context.TVT0760.FindAsync(id);
            _context.TVT0760.Remove(tVT0760);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TVT0760Exists(string id)
        {
            return _context.TVT0760.Any(e => e.TVTId == id);
        }
    }
}
