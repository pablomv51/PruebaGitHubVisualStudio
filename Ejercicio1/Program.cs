//Crear un proyecto con una clase QUEBRADO y un fichero de código en donde se instancien y prueben operaciones sobre varios quebrados. (Más adelante un Menú)
//Clase quebrado con dos propiedades: numerador y denominador.
//En el constructor se pueden establecer los valores de numerador y denominador. Controlar que no se tiene den=0
//numerador y denominador son propiedades accesibles y asignables mediante get, set (comporobar lo miso del 0 en el denominador)

using Ejercicio1;

class Program
{


    public static void Main(string[] args)
    {

        Quebrado q1 = new Quebrado(1, 6);
        Quebrado q2 = new Quebrado(2, 6);

        while (true)
        {
            Console.WriteLine("\nMenú de operaciones con quebrados:");
            Console.WriteLine("1. Mostrar valor real del primer quebrado");
            Console.WriteLine("2. Comprobar si el primer quebrado es entero");
            Console.WriteLine("3. Sumar quebrados");
            Console.WriteLine("4. Restar quebrados");
            Console.WriteLine("5. Multiplicar quebrados");
            Console.WriteLine("6. Dividir quebrados");
            Console.WriteLine("7. Comparar si el primer quebrado es mayor que el segundo");
            Console.WriteLine("8. Comparar si el primer quebrado es menor que el segundo");
            Console.WriteLine("9. Comprobar si los quebrados son iguales");
            Console.WriteLine("10. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Valor real del quebrado: {Quebrado.ValorReal(q1)}");
                    break;
                case "2":
                    Console.WriteLine($"¿Es entero? {Quebrado.EsEntero(q1)}");
                    break;
                case "3":
                    Console.WriteLine($"Suma: {Quebrado.Suma(q1, q2)}");
                    break;
                case "4":
                    Console.WriteLine($"Resta: {Quebrado.Resta(q1, q2)}");
                    break;
                case "5":
                    Console.WriteLine($"Multiplicación: {Quebrado.Multiplicacion(q1, q2)}");
                    break;
                case "6":
                    Console.WriteLine($"División: {Quebrado.Division(q1, q2)}");
                    break;
                case "7":
                    Console.WriteLine($"¿El primer quebrado es mayor que el segundo? {Quebrado.MayorQue(q1, q2)}");
                    break;
                case "8":
                    Console.WriteLine($"¿El primer quebrado es menor que el segundo? {Quebrado.MenorQue(q1, q2)}");
                    break;
                case "9":
                    Console.WriteLine($"¿Los quebrados son iguales? {Quebrado.EsIgual(q1, q2)}");
                    break;
                case "10":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    

    }
 }