using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PFE_CHU.Models;

namespace PFE_CHU.Controllers
{
    public class HopitauxController : Controller
    {
        private readonly Context _context;

        public HopitauxController(Context context)
        {
            _context = context;
        }

        // GET: Hopitaux
        public async Task<IActionResult> Index()
        {
              return _context.Hopitaux != null ? 
                          View(await _context.Hopitaux.ToListAsync()) :
                          Problem("Entity set 'Context.Hopitaux'  is null.");
        }

        // GET: Hopitaux/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Hopitaux == null)
            {
                return NotFound();
            }

            var hopitaux = await _context.Hopitaux
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hopitaux == null)
            {
                return NotFound();
            }

            return View(hopitaux);
        }

        // GET: Hopitaux/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hopitaux/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Libelle")] Hopitaux hopitaux)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hopitaux);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hopitaux);
        }

        // GET: Hopitaux/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Hopitaux == null)
            {
                return NotFound();
            }

            var hopitaux = await _context.Hopitaux.FindAsync(id);
            if (hopitaux == null)
            {
                return NotFound();
            }
            return View(hopitaux);
        }

        // POST: Hopitaux/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Libelle")] Hopitaux hopitaux)
        {
            if (id != hopitaux.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hopitaux);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HopitauxExists(hopitaux.Id))
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
            return View(hopitaux);
        }

        // GET: Hopitaux/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Hopitaux == null)
            {
                return NotFound();
            }

            var hopitaux = await _context.Hopitaux
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hopitaux == null)
            {
                return NotFound();
            }

            return View(hopitaux);
        }

        // POST: Hopitaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Hopitaux == null)
            {
                return Problem("Entity set 'Context.Hopitaux'  is null.");
            }
            var hopitaux = await _context.Hopitaux.FindAsync(id);
            if (hopitaux != null)
            {
                _context.Hopitaux.Remove(hopitaux);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HopitauxExists(int? id)
        {
          return (_context.Hopitaux?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
