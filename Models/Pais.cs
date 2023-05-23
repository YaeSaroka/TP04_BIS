public class Pais
{
    public string Nombre{get;private set;}
    public string imgBandera{get;private set;}
    public int Poblacion{get;private set;}
    public DateTime FechaIndependecia{get;private set;}
    public string AtractivosTuristicos{get;private set;}

    public Pais(string nombre, string bandera, int poblacion, DateTime fecha_ind, string atractivos)
    {
        Nombre=nombre;
        imgBandera=bandera;
        Poblacion=poblacion;
        FechaIndependecia=fecha_ind;
        AtractivosTuristicos=atractivos;

    }
}