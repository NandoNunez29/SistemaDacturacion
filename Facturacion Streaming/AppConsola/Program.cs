DateTime FechaActivacion;
FechaActivacion = DateTime.Now;
DateTime FechaCorte;
int MesesSuscripcion = 3;
FechaCorte = FechaActivacion.AddMonths(MesesSuscripcion);  
Console.WriteLine(FechaCorte.ToString());