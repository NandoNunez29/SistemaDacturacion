namespace AppConsola;
using System;
public class Factura
{
    public DateTime FechaEmision { get; private set; }
    public string Id { get; private set; } = "";
    public decimal Subtotal { get; set;}    
    public decimal Total { get; set; }
    public decimal Descuento { get; set; }
    public Cliente Cliente { get; set; }  
    public List<DetalleFactura> Detalles {get; set;}  
    public decimal PorcentajeDescuento { get; set; } = 0;


    public Factura(Cliente cliente){ 
        Cliente = cliente;
        FechaEmision = DateTime.Now;
        SetId();

    }


    public void SetId(){
        var randon = new Random ();
        Id = Convert.ToString(randon.Next(0,999)); 
    }   
    

    public void AgregarDetalle(DetalleFactura detalle){
        Detalles.Add(detalle);
    }
   public void CalcularSubtotal(){
        foreach (var item in Detalles)
        {
            Subtotal += item.Total;
        }
    }

    public void CalcularDescuento(){
            if(Cliente.Tipo == "Mayorista"){
            Console.WriteLine("Porcentaje de Descuento: ");
            PorcentajeDescuento = Convert.ToDecimal(Console.ReadLine());
            Descuento = Subtotal*(PorcentajeDescuento/100);
        } else 
        Descuento = 0;        
    }

    public void CacularTotal(){
        Total = Subtotal - Descuento;
    }  

    
}
