namespace ProjectControlBodega.Models;

public class CompaniaDeEnvio{

    public int Id{get;set;}
    public string? Nombre {get;set;}
    public double Precio {get;set;}
    public string? Correo {get;set;}
    public string? Numero {get;set;}
    public List<Pedido> Pedidos {get; set;}
    public CompaniaDeEnvio(){
        Pedidos = new List<Pedido>();
    }

}