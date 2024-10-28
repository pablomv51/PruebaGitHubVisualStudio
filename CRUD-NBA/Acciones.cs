using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileHelper
{
    private string filePath = "equipos.txt";

    public void Create(Equipo equipo)
    {
        using (StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine(equipo.ToString());
        }

    }
    public List<Equipo> ReadAll()
    {
        var equipos = new List<Equipo>();
        if (File.Exists(filePath))
        {
            var lineas = File.ReadAllLines(filePath);
            foreach (var linea in lineas)
            {
                equipos.Add(Equipo.FromString(linea));
            }
        }
        return equipos;
    }
    public void Delete(string Nombre)
    {
        var equipos = ReadAll();
        equipos.RemoveAll(s => s.Nombre == Nombre);
        File.WriteAllLines(filePath, equipos.Select(s => s.ToString()));
    }

    public void Update(Equipo equipo)
    {
        var equipos = ReadAll();
        var indiceEquipo = equipos.FindIndex(s => s.Nombre == equipo.Nombre);
        if (indiceEquipo != -1)
        {
            equipos[indiceEquipo] = equipo;
            File.WriteAllLines(filePath, equipos.Select(s => s.ToString()));
        }
    }

}