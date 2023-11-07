using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectControlBodega.Models;

namespace ProjectControlBodega.Controllers
{
    public class CompaniaDeEnvioController : Controller
    {
        private readonly AppDbContext _context;

        public CompaniaDeEnvioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CompaniaDeEnvio
        public async Task<IActionResult> Index()
        {
              return _context.CompaniaDeEnvios != null ? 
                          View(await _context.CompaniaDeEnvios.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.CompaniaDeEnvios'  is null.");
        }

        // GET: CompaniaDeEnvio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CompaniaDeEnvios == null)
            {
                return NotFound();
            }

            var companiaDeEnvio = await _context.CompaniaDeEnvios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companiaDeEnvio == null)
            {
                return NotFound();
            }

            return View(companiaDeEnvio);
        }

        // GET: CompaniaDeEnvio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompaniaDeEnvio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Precio,Correo,Numero")] CompaniaDeEnvio companiaDeEnvio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companiaDeEnvio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companiaDeEnvio);
        }

        // GET: CompaniaDeEnvio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CompaniaDeEnvios == null)
            {
                return NotFound();
            }

            var companiaDeEnvio = await _context.CompaniaDeEnvios.FindAsync(id);
            if (companiaDeEnvio == null)
            {
                return NotFound();
            }
            return View(companiaDeEnvio);
        }

        // POST: CompaniaDeEnvio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Precio,Correo,Numero")] CompaniaDeEnvio companiaDeEnvio)
        {
            if (id != companiaDeEnvio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companiaDeEnvio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompaniaDeEnvioExists(companiaDeEnvio.Id))
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
            return View(companiaDeEnvio);
        }

        // GET: CompaniaDeEnvio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CompaniaDeEnvios == null)
            {
                return NotFound();
            }

            var companiaDeEnvio = await _context.CompaniaDeEnvios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companiaDeEnvio == null)
            {
                return NotFound();
            }

            return View(companiaDeEnvio);
        }

        // POST: CompaniaDeEnvio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CompaniaDeEnvios == null)
            {
                return Problem("Entity set 'AppDbContext.CompaniaDeEnvios'  is null.");
            }
            var companiaDeEnvio = await _context.CompaniaDeEnvios.FindAsync(id);
            if (companiaDeEnvio != null)
            {
                _context.CompaniaDeEnvios.Remove(companiaDeEnvio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompaniaDeEnvioExists(int id)
        {
          return (_context.CompaniaDeEnvios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
