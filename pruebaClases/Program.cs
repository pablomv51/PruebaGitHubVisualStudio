using pruebaClases;
 class Program
{
    private static void Main(string[] args)
    {

        Persona p = new Persona("Pablo", 19);

        Console.WriteLine("Mi nombre es " + p.Nombre);
        Console.WriteLine("Tengo " + p.Edad + " años");

    }
}