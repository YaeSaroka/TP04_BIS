public static class Info
{
    private static List <Pais> ListaPaises= new List<Pais>();
    
//Metodos
    private static void IniciarLista()
    {
        DateTime fecha_argentina= new DateTime (1816,07,09);
        DateTime fecha_israel= new DateTime(1948,05,14);
        DateTime fecha_irlanda= new DateTime(1921,07,11);
        DateTime fecha_chile= new DateTime(1818,02,12);
        DateTime fecha_italia= new DateTime(1849,08,22);
        Pais Argentina=new Pais("Argentina","bandera_argentina.png",6000000,fecha_argentina,"obelisco");
        Pais Israel= new Pais("Israel","bandera_israel.png",2000000,fecha_israel,"kotel");
        Pais Irlanda= new Pais("Irlanda","bandera_irlanda.png",5033000, fecha_irlanda, "acantilados_de_mother");
        Pais Chile= new Pais("Chile","bandera_chile.png",19000000, fecha_chile, "valle_del_elqui");
        Pais Italia= new Pais("Japon","bandera_italia.png",59000000, fecha_italia, "coliseo");
        ListaPaises.Add(Argentina);   
        ListaPaises.Add(Israel);   
        ListaPaises.Add(Irlanda);   
        ListaPaises.Add(Chile);     
        ListaPaises.Add(Italia);   
    }
    public static List<Pais> ListarPaises()
    {
        if(ListaPaises.Count==0)
        {
            IniciarLista();
        }
        return ListaPaises;
    } 
    public static Pais DetallePais(string Nombre)
    {
        Pais pais_Devolver=null;
        foreach(Pais pais in ListaPaises)
        {
            if(pais.Nombre == Nombre)
            {
               pais_Devolver=pais;
            }
        }
        return pais_Devolver;
        
    }
}