public class Equipo
{
    public string Nombre { get; set; }

    public string Conferencia { get; set; }

    public string Estado { get; set; }

    public int Posicion { get; set; }

    public int Jugadores_plantilla { get; set; }

    public int Titulos { get; set; }

    public int Presupuesto { get; set; }

    

    public override string ToString()
    {
        return $"{Nombre};{Conferencia};{Estado};{Posicion};{Jugadores_plantilla};{Titulos};{Presupuesto};"; ;
    }


    public static Equipo FromString(string datoCSV)
    {
        //string [] partes = datoCSV.Split(';');
        var partes = datoCSV.Split(';');
        return new Equipo
        {
            Nombre = partes[0],
            Conferencia = partes[1],
            Estado = partes[2],
            Posicion = int.Parse(partes[3]),
            Jugadores_plantilla = int.Parse(partes[4]),
            Titulos = int.Parse(partes[5]),
            Presupuesto = int.Parse(partes[6])
         
        };
    }
}