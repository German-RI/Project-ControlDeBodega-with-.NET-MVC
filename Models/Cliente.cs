namespace ProjectControlBodega.Models;


public class Cliente{

    public int Id {get; set; }
    public string? Cedula {get; set; }
    public string? Nombres {get; set; }
    public string? Apellidos {get; set; }
    public string? Sexo {get; set; }
    public int Edad {get; set; }
    public List<Pedido> Pedidos {get; set;}
    public Cliente(){
        Pedidos = new List<Pedido>();
    }

}