namespace AppConsola;

public class DetalleFactura
{
    public string Id { get; set; } = "";
    public decimal Subtotal { get; set; }
    public decimal Total { get; set; }
    public int Cantidad { get; set; }   
    public DateTime FechaActivacion { get; set; }
    public DateTime FechaCorte { get; set; }
    public int MesesSuscripcion { get; set; }
    public decimal Descuento { get; set; }
    public Servicio Servicio { get; set; }


    public DetalleFactura(Servicio servicio,int cantidad, int mesesSuscripcion){
        Servicio = servicio;
        Cantidad = cantidad;
        MesesSuscripcion = mesesSuscripcion;
        FechaActivacion = DateTime.Now;
        SetId();
    }

    public void SetId(){
        Id += 1;
    }

    public void CalcularFechaCorte(){
        FechaCorte = FechaActivacion.AddMonths(MesesSuscripcion);      
    }

    public void CalcularSubtotal(Cliente cliente){
        if(cliente.Tipo == "Mayorista"){
            Subtotal = Servicio.PrecioMayorista * Cantidad;
        }   
    }
    public void CalcularTotal(){
        Total = Subtotal - Descuento;
    }

    public void CacularDescuento (){
        if(MesesSuscripcion >= 3) {
            decimal Porcentaje = 15;
            Descuento = Subtotal * Porcentaje/100;
        }
        if(Cantidad >= 3) {
            decimal Porcentaje = 10;
            Descuento += Subtotal * Porcentaje/100;
        } 
    }

}
