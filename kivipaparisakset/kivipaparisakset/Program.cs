using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivipaparisakset
{
    internal class Program
    {
        /// <summary>
        /// Kone valitsee vaihtoehdot satunnaisesti
        /// </summary>
        static Random random = new Random();

        
        static void Main(string[] args)
        {
            //Näytetään pelin esittely ja säännöt
            Console.WriteLine("Tervetuloa Kivi, Paperi, Sakset peliin!");
            Console.WriteLine("Pelin säännot:");
            Console.WriteLine("Kivi voittaa Sakset, Sakset voittavat Paperin, ja Paperi voittaa Kiven.");
            Console.WriteLine("Valitse vain 1 tai 2 tai 3 jatkaaksesi peliä");
            Console.WriteLine("Paina Enter poistuaksesi pelistä");   


            int pelaajaValinta;
            int koneenValinta;
            string[] vaihtoehdot = { "kivi", "sakset", "paperi" };

            do
            {
                // Näytetään pelaajan valinnat
                Console.WriteLine("\nValinnat:");
                Console.WriteLine("Enter - lopeta");
                Console.WriteLine("1 - kivi");
                Console.WriteLine("2 - sakset");
                Console.WriteLine("3 - paperi");

                Console.Write("Mikä on valintasi: ");
                string input = Console.ReadLine();

                //// Poistutaan pelistä, jos syöte on tyhjä
                if (string.IsNullOrEmpty(input))
                    if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Kiitos pelaamisesta!");
                    break;
                }

                // Tarkistetaan ja käsitellään pelaajan syöte
                if (!int.TryParse(input, out pelaajaValinta) || pelaajaValinta < 1 || pelaajaValinta > 3)
                {
                    Console.WriteLine("Virheellinen valinta. Valitse 1, 2 tai 3.");
                    continue;
                }

                //Generoidaan satunnainen valinta tietokoneelle
                koneenValinta = random.Next(1, 4);
                Console.WriteLine($"kone valitsi {vaihtoehdot[koneenValinta - 1]}");

                // Määritellään pelitulos
                int tulos = TarkistaTulos(pelaajaValinta, koneenValinta);

                if (tulos == 0)
                    Console.WriteLine("Tasapeli!");
                else if (tulos == 1)
                    Console.WriteLine("Voitit!");
                else
                    Console.WriteLine("Kone voitti!");

            } while (true);

            Console.ReadLine();
        }

        /// <summary>
        /// Tarkistaa pelituloksen pelaajan ja koneen valintojen perusteella.
        /// </summary>
        /// <param name="pelaaja">Pelaajan valinta (1 = kivi, 2 = sakset, 3 = paperi).</param>
        /// <param name="kone">Koneen valinta (1 = kivi, 2 = sakset, 3 = paperi).</param>
        /// <returns>0 tasapeli, 1 pelaaja voittaa, -1 kone voittaa.</returns>
        static int TarkistaTulos(int pelaaja, int kone)
        {
            if (pelaaja == kone)
                return 0;
            if ((pelaaja == 1 && kone == 2) || (pelaaja == 2 && kone == 3) || (pelaaja == 3 && kone == 1))
                return 1;
            else
                return -1;
        }
    }
}






        
