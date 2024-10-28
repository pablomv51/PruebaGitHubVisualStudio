using System;
using System.Collections.Generic;

class CashMachine
{
    private Dictionary<string, int> cantidades;
    private static readonly HashSet<string> indicesValidos = new HashSet<string>
    {
        "50e", "20e", "10e", "5e", "2e", "1e", "50c", "20c", "10c", "5c", "2c", "1c"
    };

    // Constructor que inicializa el diccionario con las cantidades indicadas
    public CashMachine(Dictionary<string, int> cantidadesIniciales)
    {
        cantidades = new Dictionary<string, int>();

        foreach (var item in cantidadesIniciales)
        {
            if (!indicesValidos.Contains(item.Key))
            {
                throw new ArgumentException($"Índice no válido: {item.Key}");
            }
            cantidades[item.Key] = item.Value;
        }
    }

    // Método para insertar una cantidad de billetes/monedas
    public bool Insertar(string tipo, int cantidad)
    {
       
        if (!indicesValidos.Contains(tipo)) {
            Console.WriteLine("El tipo de moneda/billete no es válido");
            return false;
        }
        else if (cantidades.ContainsKey(tipo))
            cantidades[tipo] += cantidad;
        else
            cantidades[tipo] = cantidad;
        return true;
    

}


    // Método para retirar una cantidad de billetes/monedas
    public bool Retirar(string tipo, int cantidad)
    {
        if (!indicesValidos.Contains(tipo))
        {
            Console.WriteLine("El tipo de moneda/billete no es válido");
            return false;
        }
        else if (cantidades.ContainsKey(tipo) && cantidades[tipo] < cantidad)
        {
            Console.WriteLine("No hay cantidad suficiente para retirar.");
            return false;
        }
        else
        {
            cantidades[tipo] -= cantidad;
            return true;
        }
    }
    // Método para contabilizar la cantidad total de dinero
    public float ContabilizarTotal()
    {
        float total = 0;

        foreach (var item in cantidades)
        {
            string tipo = item.Key;
            int cantidad = item.Value;

            // Convertir cada tipo a su valor en euros
            float valorEnEuros = 0;
            switch (tipo)
            {
                case "50e":
                    valorEnEuros = 50;
                    break;
                case "20e":
                    valorEnEuros = 20;
                    break;
                case "10e":
                    valorEnEuros = 10;
                    break;
                case "5e":
                    valorEnEuros = 5;
                    break;
                case "2e":
                    valorEnEuros = 2;
                    break;
                case "1e":
                    valorEnEuros = 1;
                    break;
                case "50c":
                    valorEnEuros = 0.5f;
                    break;
                case "20c":
                    valorEnEuros = 0.20f;
                    break;
                case "10c":
                    valorEnEuros = 0.10f;
                    break;
                case "5c":
                    valorEnEuros = 0.05f;
                    break;
                case "2c":
                    valorEnEuros = 0.02f;
                    break;
                case "1c":
                    valorEnEuros = 0.01f;
                    break;
            }
            // Sumar el total de este tipo 
            total += valorEnEuros * cantidad;
        }

        return total;
    }

    // Método Paga: devuelve el cambio o el diccionario original si no hay suficiente
    public string Paga(decimal importe, decimal precio)
    {   
        
        decimal resto = importe - precio;
        int cincuentaE = 0;
        int veinteE = 0;
        int diezE = 0;
        int cincoE = 0;
        int dosE = 0;
        int unE =0;
        int cincuentaC = 0;
        int veinteC=0;
        int diezC = 0;
        int cincoC = 0;
        int dosC = 0;
        int unC = 0;
        string final= "";
 
        while (resto > 0)
        {
            if(resto >= 50)
            {
                resto -= 50;
                cincuentaE++;
            }
            else if(resto >= 20)
            {
                resto -= 20;
                veinteE++;
            }
            else if (resto >= 10)
            {
                resto -= 10;
                diezE++;
            }
            else if (resto >= 5)
            {
                resto -= 5;
                cincoE++;
            }
            else if (resto >= 2)
            {
                resto -= 2;
                dosE++;
            }
            else if (resto >= 1)
            {
                resto -= 1;
                unE++;
            }
            else if (resto >= 0.50M)
            {
                resto -= 0.50M;
                cincuentaC++;
            }
            else if (resto >= 0.20M)
            {
                resto -= 0.20M;
                veinteC++;
            }
            else if (resto >= 0.10M)
            {
                resto -= 0.10M;
                diezC++;
            }
            else if (resto >= 0.05M)
            {
                resto -= 0.05M;
                cincoC++;
            }
            else if (resto >= 0.02M)
            {
                resto -= 0.02M;
                dosC++;
            }
            else if (resto >= 0.01M)
            {
                resto -= 0.01M;
                unC++;
            }
            
        }
        final = "Vuelta Final: \n" +
            "Billetes de 50 euros: " + cincuentaE + "\n" +
            "Billetes de 20 euros: " + veinteE + "\n" +
            "Billetes de 10 euros: " + diezE + "\n" +
            "Billetes de 5 euros: " + cincoE + "\n" +
            "Monedas de 2 euros: " + dosE + "\n" +
            "Monedas de 1 euro: " + unE + "\n" +
            "Monedas de 50 centimos: " + cincuentaC + "\n" +
            "Monedas de 20 centimos: " + veinteC + "\n" +
            "Monedas de 10 centimos: " + diezC + "\n" +
            "Monedas de 5 centimos: " + cincoC + "\n" +
            "Monedas de 2 centimos: " + dosC + "\n" +
            "Monedas de 1 centimo: " + unC + "\n";

        return final;
    }
}

class Program
{
    static void Main()
    {
        // Inicializar el diccionario con algunas cantidades
        Dictionary<string, int> cantidadesIniciales = new Dictionary<string, int>
    {
        { "50e", 2 },
        { "20e", 5 },
        { "1e", 10 },
        { "50c", 20 }
    };

        try
        {
            CashMachine miDinero = new CashMachine(cantidadesIniciales);
            if(miDinero.Insertar("50e", 3))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("20e", 3))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("10e", 4))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("5e", 7))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("1e", 10))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("50c", 12))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("20c", 15))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("10c", 10))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("5c", 12))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("2c", 6))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("1c", 8))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Insertar("5000c", 10))
            {
                Console.WriteLine("Se ha introducido correctamente la cantidad");
            }
            else
            {
                Console.WriteLine("Introduzca un tipo válido, este no es correcto");
            }
            if (miDinero.Retirar("50e", 1))
            {
                Console.WriteLine("Se retiro la cantidad correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la operación");
            }
            if (miDinero.Retirar("10e", 2))
            {
                Console.WriteLine("Se retiro la cantidad correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la operación");
            }
            Console.WriteLine("Actualmente tengo "+ miDinero.ContabilizarTotal() + " euros");
            
            Console.WriteLine(miDinero.Paga(2.15M,0.75M));
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}

