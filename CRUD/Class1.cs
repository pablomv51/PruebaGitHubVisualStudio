using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileHelper
{
    private string filePath = "personas.txt";

    public void Create(Persona persona)
    {
        using (StreamWriter sw = File.AppendText(filePath))
        { 
            sw.WriteLine(persona.ToString());
        }
    }
    public List<Persona> ReadAll()
    {
        var personas = new List<Persona>();
        if (File.Exists(filePath))
        {
            var lineas = File.ReadAllLines(filePath);
            foreach (var linea in lineas)
            {
                personas.Add(Persona.FromString(linea));
            }
        }
        return personas;
    }
    public void Delete(string DNI)
    {
        var personas = ReadAll();
        personas.RemoveAll ( s => s.DNI == DNI );
        File.WriteAllLines(filePath, personas.Select( s => s.ToString()));
    }

    public void Update(Persona persona)
    {
        var personas = ReadAll();
        var indicePersona = personas.FindIndex( s => s.DNI == persona.DNI );
        if (indicePersona != -1)
        {
            personas[indicePersona] = persona;
            File.WriteAllLines(filePath, personas.Select( s => s.ToString()));
        }
    }

}