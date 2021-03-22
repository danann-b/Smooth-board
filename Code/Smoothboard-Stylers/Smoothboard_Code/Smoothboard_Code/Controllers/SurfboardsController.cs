using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smoothboard_Code.Data;
using Smoothboard_Code.Models;

namespace Smoothboard_Code.Controllers
{
    public class SurfboardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SurfboardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Surfboards
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Surfboard.Include(s => s.Materiaal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Surfboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboard = await _context.Surfboard
                .Include(s => s.Materiaal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfboard == null)
            {
                return NotFound();
            }

            return View(surfboard);
        }

        // GET: Surfboards/Create
        public IActionResult Create()
        {
            ViewData["MateriaalId"] = new SelectList(_context.Set<Materiaal>(), "Id", "Id");
            return View();
        }

        // POST: Surfboards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Beschrijving,Prijs,FotoUrl,MateriaalId")] Surfboard surfboard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surfboard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MateriaalId"] = new SelectList(_context.Set<Materiaal>(), "Id", "Id", surfboard.MateriaalId);
            return View(surfboard);
        }

        // GET: Surfboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboard = await _context.Surfboard.FindAsync(id);
            if (surfboard == null)
            {
                return NotFound();
            }
            ViewData["MateriaalId"] = new SelectList(_context.Set<Materiaal>(), "Id", "Id", surfboard.MateriaalId);
            return View(surfboard);
        }

        // POST: Surfboards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Beschrijving,Prijs,FotoUrl,MateriaalId")] Surfboard surfboard)
        {
            if (id != surfboard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surfboard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfboardExists(surfboard.Id))
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
            ViewData["MateriaalId"] = new SelectList(_context.Set<Materiaal>(), "Id", "Id", surfboard.MateriaalId);
            return View(surfboard);
        }

        // GET: Surfboards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfboard = await _context.Surfboard
                .Include(s => s.Materiaal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surfboard == null)
            {
                return NotFound();
            }

            return View(surfboard);
        }

        // POST: Surfboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfboard = await _context.Surfboard.FindAsync(id);
            _context.Surfboard.Remove(surfboard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfboardExists(int id)
        {
            return _context.Surfboard.Any(e => e.Id == id);
        }
    }
}
