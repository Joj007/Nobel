using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Nobel> nobelLista = new List<Nobel>();
            foreach (var sor in File.ReadAllLines("nobel.csv").Skip(1))
            {
                nobelLista.Add(new Nobel(sor));
            }

            //4
            Console.WriteLine($"2017 irodalmi nobelíjasa: {nobelLista.Where(n => n.Ev == 2017 && n.Tipus == "irodalmi").First().TeljesNev}");

            //5
            //nobelLista.Where(n => n.VezetekNev == "" && n.Ev >= 1990).ToList().ForEach();

            //6
            nobelLista.Where(n => n.VezetekNev.Contains("Curie")).ToList().ForEach(n => Console.WriteLine($"Év: {n.Ev}, Név: {n.TeljesNev}, Kategória: {n.Tipus}"));

            //7
            nobelLista.GroupBy(n => n.Tipus).ToList().ForEach(n => Console.WriteLine($"{n.Key}: {n.Count()}"));

            //8
            File.WriteAllLines("orvosi.txt", nobelLista.Where(n=>n.Tipus=="orvosi").OrderBy(n=>n.Ev).Select(n=>n.Fajlba));
        }
    }
}
