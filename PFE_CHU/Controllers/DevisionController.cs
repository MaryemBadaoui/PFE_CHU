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
    public class DevisionController : Controller
    {
        private readonly Context _context;

        public DevisionController(Context context)
        {
            _context = context;
        }

        // GET: Devision
        public async Task<IActionResult> Index()
        {
              return _context.Devisions != null ? 
                          View(await _context.Devisions.ToListAsync()) :
                          Problem("Entity set 'Context.Devisions'  is null.");
        }

        // GET: Devision/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Devisions == null)
            {
                return NotFound();
            }

            var devision = await _context.Devisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (devision == null)
            {
                return NotFound();
            }

            return View(devision);
        }

        // GET: Devision/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Libelle")] Devision devision)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devision);
        }

        // GET: Devision/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Devisions == null)
            {
                return NotFound();
            }

            var devision = await _context.Devisions.FindAsync(id);
            if (devision == null)
            {
                return NotFound();
            }
            return View(devision);
        }

        // POST: Devision/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Libelle")] Devision devision)
        {
            if (id != devision.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevisionExists(devision.Id))
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
            return View(devision);
        }

        // GET: Devision/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Devisions == null)
            {
                return NotFound();
            }

            var devision = await _context.Devisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (devision == null)
            {
                return NotFound();
            }

            return View(devision);
        }

        // POST: Devision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Devisions == null)
            {
                return Problem("Entity set 'Context.Devisions'  is null.");
            }
            var devision = await _context.Devisions.FindAsync(id);
            if (devision != null)
            {
                _context.Devisions.Remove(devision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevisionExists(int? id)
        {
          return (_context.Devisions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
