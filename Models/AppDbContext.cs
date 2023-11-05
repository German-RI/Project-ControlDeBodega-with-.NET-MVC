using Microsoft.EntityFrameworkCore;

namespace ProjectControlBodega.Models {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<CompaniaDeEnvio> CompaniaDeEnvios { get; set; }
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Producto> Productos {get; set;}
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<Detalledepedido> Detalledepedidos {get; set;}

    }
}