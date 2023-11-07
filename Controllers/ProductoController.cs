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
    public class ProductoController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Productos != null ?
                        View(await _context.Productos.Include(p => p.Categoria).Include(p => p.Proveedor).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Proveedors'  is null.");
        }

        // GET: Proveedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var proveedor = await _context.Productos.Include(p => p.Categoria).Include(p => p.Proveedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        public IActionResult Create()
        {
            ViewData["Categorias"] = new SelectList(_context.Categorias, "Id", "Nombre");
            ViewData["Proveedors"] = new SelectList(_context.Proveedors, "Id", "Nombre");
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Precio,Cantidad,Descripcion")] Producto producto, int CategoriasId, int ProveedorsId)
        {
            if (ModelState.IsValid)
            {

                // Obtener la categoría seleccionada por su Id
                producto.Categoria = _context.Categorias.FirstOrDefault(c => c.Id == CategoriasId);

                // Obtener el proveedor seleccionado por su Id
                producto.Proveedor = _context.Proveedors.FirstOrDefault(p => p.Id == ProveedorsId);

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }


    }

}