namespace ProjectControlBodega.Models;

public class Pedido
{
    
    public int Id { get; set; }
    public DateTime Fecha {get; set;}
    public Cliente? Cliente {get; set; }
    public CompaniaDeEnvio? Compdeenvio {get; set; }
    public Empleado? Empleado {get; set; }
    public List<Detalledepedido> Detalledepedidos {get; set; }
    public Pedido(){
        Detalledepedidos = new List<Detalledepedido>();
    }
}