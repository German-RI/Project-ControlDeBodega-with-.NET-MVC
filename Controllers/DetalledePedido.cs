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
    public class DetalledePedidoController : Controller
    {
        private readonly AppDbContext _context;

        public DetalledePedidoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {

            if (id == null || _context.Detalledepedidos == null)
            {
                return NotFound();
            }
            ViewData["PedidoId"] = id;
            return _context.Detalledepedidos != null ?
                        View(await _context.Detalledepedidos.Include(p => p.Pedido).Include(p => p.Producto).Where( c => c.Pedido.Id == id).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.DetalledePedidos'  is null.");
        }

        // GET: Proveedor/Details/5
        /*public async Task<IActionResult> Details(int? id)
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
        }*/

        public IActionResult Create(int id)
        {
            ViewData["Productos"] = new SelectList(_context.Productos, "Id", "Nombre");
            ViewData["PedidoId"] = id;
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CantidadProducto")] Detalledepedido detalledepedido, int PedidosId, int ProductosId)
        {
            if (ModelState.IsValid)
            {

                // Obtener la categoría seleccionada por su Id
                detalledepedido.Pedido = _context.Pedidos.FirstOrDefault(c => c.Id == PedidosId);

                // Obtener el proveedor seleccionado por su Id
                detalledepedido.Producto = _context.Productos.FirstOrDefault(p => p.Id == ProductosId);

                _context.Add(detalledepedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = PedidosId });
            }
            return View(detalledepedido);
        }


    }

}