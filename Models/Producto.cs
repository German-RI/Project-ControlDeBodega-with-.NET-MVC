namespace ProjectControlBodega.Models;

public class Producto
{
    
    public int Id { get; set; }
    public string? Imagen { get; set;}
    public string? Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
    public string? Descripcion {get; set; }
    public Categoria? Categoria {get; set; }
    public Proveedor? Proveedor {get; set; }
    public List<Detalledepedido> Detalledepedidos {get; set; }
    public Producto(){
        Detalledepedidos = new List<Detalledepedido>();
    }

}