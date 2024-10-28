public class Persona
{
    public string DNI { get; set; }
    public string Name { get; set; }

    public int Edad { get; set; }

    public override string ToString()
    {
        return $"{DNI}; {Name}; {Edad}";
    }


    public static Persona FromString (string datoCSV)
    {
        //string [] partes = datoCSV.Split(';');
        var partes = datoCSV.Split(';');
        return new Persona
        {
            DNI = partes[0],
            Name = partes[1],
            Edad = int.Parse(partes[2])
        };
    }
}

