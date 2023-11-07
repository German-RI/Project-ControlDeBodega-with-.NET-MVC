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
    public class PedidoController : Controller
    {
        private readonly AppDbContext _context;

        public PedidoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Pedidos != null ?
                        View(await _context.Pedidos.Include(p => p.Cliente).Include(p => p.Compdeenvio).Include(p => p.Empleado).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Proveedors'  is null.");
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

        public IActionResult Create()
        {
            ViewData["Clientes"] = new SelectList(_context.Clientes, "Id", "Nombres");
            ViewData["Empleados"] = new SelectList(_context.Empleados, "Id", "Nombres");
            ViewData["CompaniaDeEnvios"] = new SelectList(_context.CompaniaDeEnvios, "Id", "Nombre");
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha")] Pedido pedido, int ClientesId, int EmpleadosId, int CompaniaDeEnviosId)
        {
            if (ModelState.IsValid)
            {

                // Obtener la categoría seleccionada por su Id
                pedido.Cliente = _context.Clientes.FirstOrDefault(c => c.Id == ClientesId);

                // Obtener el proveedor seleccionado por su Id
                pedido.Empleado = _context.Empleados.FirstOrDefault(p => p.Id == EmpleadosId);

                // Obtener el proveedor seleccionado por su Id
                pedido.Compdeenvio = _context.CompaniaDeEnvios.FirstOrDefault(p => p.Id == CompaniaDeEnviosId);

                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }


    }

}