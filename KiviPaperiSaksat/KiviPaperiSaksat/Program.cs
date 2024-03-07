using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiviPaperiSaksat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Kivi-Paperi-Sakset -peliin!");
            Console.WriteLine("Säännöt:");
            Console.WriteLine("Kivi voittaa Sakset, Sakset voittavat Paperin, ja Paperi voittaa Kiven.");

            while (true)
            {
                Console.Write("Valitse (K)ivi, (P)aperi tai (S)akset (Lopeta lopettaaksesi): ");
                string pelaajanValinta = Console.ReadLine().ToUpper();

                if (pelaajanValinta == "LOPETA")
                {
                    Console.WriteLine("Kiitos pelaamisesta!");
                    break;
                }

                string koneenValinta = GeneroiKoneenValinta();
                Console.WriteLine($"Kone valitsi: {koneenValinta}");

                string tulos = LaskeTulos(pelaajanValinta, koneenValinta);
                Console.WriteLine(tulos);
            }
        }

        // Generoi koneen valinta satunnaisesti
        static string GeneroiKoneenValinta()
        {
            Random random = new Random();
            int satunnainenLuku = random.Next(1, 4);

            switch (satunnainenLuku)
            {
                case 1:
                    return "Kivi";
                case 2:
                    return "Paperi";
                case 3:
                    return "Sakset";
                default:
                    return "Kivi"; // Oletus, jos jotain menee pieleen
            }
        }

        // Laske pelitulos
        static string LaskeTulos(string pelaaja, string kone)
        {
            if (pelaaja == kone)
            {
                return "Tasapeli!";
            }
            else if ((pelaaja == "K" && kone == "Sakset") ||
                     (pelaaja == "P" && kone == "Kivi") ||
                     (pelaaja == "S" && kone == "Paperi"))
            {
                return "Voitit!";
            }
            else
            {
                return "Kone voitti!";
            }
        }
    }
}
