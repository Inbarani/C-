using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmpyranPintaAla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ympyrän säde: ");
            double sade = double.Parse(Console.ReadLine());

            double pintaAla = 3.14 * (sade*sade);

            Console.WriteLine("Ala on: " + pintaAla.ToString("0.00")); // Tulostaa pinta-alan kahdella desimaalilla
            Console.ReadLine();
        }
    }
}
