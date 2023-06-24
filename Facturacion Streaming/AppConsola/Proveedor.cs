namespace AppConsola;

public class Proveedor : Persona
{
    public string LinkPagina { get; set; } = "";
    public Proveedor(string linkPagina) : base("", "", "", "")
    {
        LinkPagina = linkPagina;
    }
    public void ActualizarLink(string linkPagina){
        LinkPagina = linkPagina;
    }
}
