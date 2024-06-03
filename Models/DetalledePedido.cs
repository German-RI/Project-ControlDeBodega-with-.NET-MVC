namespace ProjectControlBodega.Models;

public class Detalledepedido{
    
    public int Id {get; set; }
    public double CantidadProducto {get; set; }
    public double PrecioTot {get; set; }
    public Producto? Producto{get; set; }
    public Pedido? Pedido {get; set; }
}