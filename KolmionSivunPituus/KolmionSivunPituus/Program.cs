using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolmionSivunPituus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pyydä käyttäjää antamaan suorakulmaisen kolmion sivujen pituudet
            Console.Write("Anna 1. sivun pituus: ");
            double pituus1 = double.Parse(Console.ReadLine());
            Console.Write("Anna 2. sivun pituus: ");
            double pituus2 = double.Parse(Console.ReadLine());

            // Laske hypotenuusan pituus
            double hypotenuusa = Math.Sqrt((pituus1 * pituus1) + (pituus2 * pituus2));

            // Tulosta hypotenuusan pituus
            Console.WriteLine("Pitkän sivun pituus on {0}", hypotenuusa);
            Console.ReadLine();
        }
    }
}
