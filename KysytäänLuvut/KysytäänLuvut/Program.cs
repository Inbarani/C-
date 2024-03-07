using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KysytäänLuvut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pyydä käyttäjältä kaksi numeroa
            int luku1, luku2;
            Console.WriteLine("Anna 1. luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. luku: ");
            luku2 = int.Parse(Console.ReadLine());
            // Laske lukujen summa, erotus, tulo ja osamäärä
            int summa = luku1 + luku2;
            int ero = luku1 - luku2;
            int tulo = luku1 * luku2;
            double jako = (double)luku1 / luku2;  // Luku1:n heittäminen kaksinkertaiseksi ennen jakoa            // Tulosta tulokset
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, summa);
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, ero);
            Console.WriteLine("{0} * {1} = {2}", luku1, luku2, tulo);
            Console.WriteLine("{0} / {1} = {2}", luku1, luku2, jako);

            Console.ReadLine();

        }
    }
}
