using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smoothboard.Data;
using Smoothboard.Models;

namespace Smoothboard.Controllers
{
    public class InteressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InteressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Interesses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Interesse.Include(i => i.Contact).Include(i => i.Surfboard);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Interesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesse
                .Include(i => i.Contact)
                .Include(i => i.Surfboard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesse == null)
            {
                return NotFound();
            }

            return View(interesse);
        }

        // GET: Interesses/Create
        public IActionResult Create()
        {
            ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id");
            ViewData["SurfboardId"] = new SelectList(_context.Surfboard, "Id", "Id");
            return View();
        }

        // POST: Interesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContactId,SurfboardId,Behandeld")] Interesse interesse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interesse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", interesse.ContactId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboard, "Id", "Id", interesse.SurfboardId);
            return View(interesse);
        }

        // GET: Interesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesse.FindAsync(id);
            if (interesse == null)
            {
                return NotFound();
            }
            ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", interesse.ContactId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboard, "Id", "Id", interesse.SurfboardId);
            return View(interesse);
        }

        // POST: Interesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContactId,SurfboardId,Behandeld")] Interesse interesse)
        {
            if (id != interesse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interesse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InteresseExists(interesse.Id))
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
            ViewData["ContactId"] = new SelectList(_context.Contact, "Id", "Id", interesse.ContactId);
            ViewData["SurfboardId"] = new SelectList(_context.Surfboard, "Id", "Id", interesse.SurfboardId);
            return View(interesse);
        }

        // GET: Interesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesse = await _context.Interesse
                .Include(i => i.Contact)
                .Include(i => i.Surfboard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesse == null)
            {
                return NotFound();
            }

            return View(interesse);
        }

        // POST: Interesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interesse = await _context.Interesse.FindAsync(id);
            _context.Interesse.Remove(interesse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InteresseExists(int id)
        {
            return _context.Interesse.Any(e => e.Id == id);
        }
    }
}
