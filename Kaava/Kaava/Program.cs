using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ohjelma, joka laskee tuloksen kaavan mukaan.

            Double a, b, c, d, tulos;
            
            //Numerot kysytään käyttäjältä.
            Console.WriteLine("Anna a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Anna b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Anna c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Anna d: ");
            d = Convert.ToDouble(Console.ReadLine());
            
            //tulostetaan kaavaa
            tulos =  (a - b) / (c * d);
            Console.WriteLine("Tulos on "+ tulos);

            Console.ReadLine();

        }
    }
}
