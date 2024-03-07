using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopanHeitto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            do
            {
                int nopanSilmaluku = random.Next(1, 7);
                Console.WriteLine("Heitit" + nopanSilmaluku);

                char vastaus;
                do
                {
                    Console.Write("Jatketaanko? (K/k/E/e): ");
                } while (!char.TryParse(Console.ReadLine(), out vastaus) || (vastaus != 'K' && vastaus != 'k' && vastaus != 'E' && vastaus != 'e'));

                if (vastaus == 'E' || vastaus == 'e')
                {
                    break;
                }
                else if (vastaus != 'K' && vastaus != 'k')
                {
                    Console.WriteLine("Anna K/k/E/e");
                }

            } while (true);

            Console.WriteLine("Kiitos pelaamisesta!");
        }
    }
}

