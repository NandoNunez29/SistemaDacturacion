namespace AppConsola;

public class Persona
{
    public string Nombre { get; set;} ="";
    public String Cedula { get; set; } 
    public string Email { get; set;} ="";
    public string Telefono { get; set; } ="";


    public Persona( string nombre, string cedula, string email, string telefono){
        Nombre = nombre;
        Cedula = cedula;
        Email = email;
        Telefono = telefono;     
    }

   
   public void ActualizarEmail(string email){
    Email = email;
   }

   public void ActualizarTelefono(string telefono){
    Telefono = telefono;
   }
}
