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
            Console.WriteLine("2. feladat: kész");
            //2
            List<Nobel> nobelLista = new List<Nobel>();
            foreach (var sor in File.ReadAllLines("nobel.csv").Skip(1))
            {
                nobelLista.Add(new Nobel(sor));
            }

            //3
            Console.WriteLine($"\n3. feladat:\n\tArthur B. McDonald ilyen típusú díjat kapott: {nobelLista.Where(n=>n.TeljesNev== "Arthur B. McDonald").First().Tipus}");

            //4
            Console.WriteLine($"\n4. feladat:\n\t2017 irodalmi nobelíjasa: {nobelLista.Where(n => n.Ev == 2017 && n.Tipus == "irodalmi").First().TeljesNev}");

            //5
            Console.WriteLine("\n5. feladat:");
            nobelLista.Where(n => n.Tipus == "béke" && n.VezetekNev == "" && n.Ev >= 1990).ToList().ForEach(n => Console.WriteLine($"\t{n.Ev}: {n.KeresztNev}"));

            //6
            Console.WriteLine("\n6. feladat:");
            nobelLista.Where(n => n.VezetekNev.Contains("Curie")).ToList().ForEach(n => Console.WriteLine($"\tÉv: {n.Ev}, Név: {n.TeljesNev}, Kategória: {n.Tipus}"));

            //7
            Console.WriteLine("\n7. feladat:");
            nobelLista.GroupBy(n => n.Tipus).ToList().ForEach(n => Console.WriteLine($"\t{n.Key}: {n.Count()}"));

            //8
            Console.WriteLine("\n8. feladat: kész");
            File.WriteAllLines("orvosi.txt", nobelLista.Where(n=>n.Tipus=="orvosi").OrderBy(n=>n.Ev).Select(n=>n.Fajlba));
        }
    }
}
