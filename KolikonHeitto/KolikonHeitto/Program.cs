using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolikonHeitto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tulokset = { 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1 };

            Kolikko kolikko = new Kolikko(tulokset);
            kolikko.PaivitaHeitot();

            Console.WriteLine(kolikko.PalautaTiedotTekstina());
            Console.ReadLine();
        }
    }
}
