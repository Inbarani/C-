using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatJarjestys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ensimmäinenTiedosto = "sanoja.txt";
            string toinenTiedosto = "jarjestysSanat.txt";

            string[] lines = File.ReadAllLines(ensimmäinenTiedosto);
            //string[] sanat = File.ReadAllLines(ensimmäinenTiedosto);
            string[] sortedWords = lines
                .SelectMany(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .OrderBy(word => word)
                .ToArray();
            File.WriteAllLines(toinenTiedosto, sortedWords);
                        
            Console.WriteLine("Sanat on kirjoitettu: " + toinenTiedosto);

            Console.ReadLine();
        }
        
    }
}

