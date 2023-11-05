namespace ProjectControlBodega.Models;

public class Proveedor
{
    
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion {get; set; }
    public double Telefono { get; set; }
    public string? Direccion {get; set; }
    public List<Producto> Productos {get; set; }
    public Proveedor(){
        Productos = new List<Producto>();
    }

}