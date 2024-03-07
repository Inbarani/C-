using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassakoneMain
{
    /// <summary>
    /// Ohjelma esittää kassakonetta.
    /// Jokaisen tavaran kohdalla huomioidaan alennus ja
    /// lopuksi voi saada kanta-asiakasalennuksen. </summary>
    internal class Program
    {
        // Pääohjelmassa pyöritetään kassakoneen runkoa.
        // Silmukassa voi antaa uuden ostoksen hinnan (u), siirtyä maksamaan (m)
        // ja lopettaa kesken (muut merkit).
        static void Main(string[] args)
        {
            //Kanta-asiakasalennus on kiinteä ja prosentteina. Oletus 5 %.
            double kantaAsAlennusPros = 5;
            //Tavarakohtainen alennusprosentti
            double alennusPros;
            double hinta, summa = 0.0, maksu, palautus;
            char toiminto, kantis;

            while (true)
            {
                toiminto = KysyToiminto();
                if (toiminto == 'u')
                {
                    hinta = LueHinta();
                    alennusPros = LueAlennus();
                    if (alennusPros > 0)
                    {
                        hinta = hinta - hinta * alennusPros;
                        Console.WriteLine("Alennettu hinta: {0:0.00}.", hinta);
                    }
                    summa += hinta;
                    
                    
                }
                else if (toiminto == 'm')
                {
                    Console.WriteLine("Ostokset yhteensä {0:0.00}", summa);
                    kantis = KysyKantis();
                    if (kantis == 'k')
                    {
                        summa *= 1 - kantaAsAlennusPros / 100;
                        Console.WriteLine("Kanta-asiakasalennuksella: {0:0.00}", summa);
                    }
                    maksu = KysyRaha(summa);
                    palautus = maksu - summa;
                    Console.WriteLine("Takaisin {0:0.00}", palautus);
                    break;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Seuraava asiakas.");
            Console.ReadLine();
           
        }
        static char KysyToiminto()
        {
            //Console.WriteLine("Valitse toiminto: (u) Uusi ostos, (m) Maksaminen, (muu) Lopeta");
            return  'm';

        }
        // Luetaan tavaran hinta
        static double LueHinta()
        {
            return 60.0;
            /*Console.WriteLine("Anna tavaran hinta: ");
            double hinta = double.Parse(Console.ReadLine());
            return hinta;*/
        }

        // Luetaan tavaran alennusprosentti
        static double LueAlennus()
        {
            return 0.2;
            /*Console.WriteLine("Anna tavaran alennusprosentti: ");
            double alennusPros = double.Parse(Console.ReadLine());
            return alennusPros;*/
        }

        // Kysytään, onko asiakas kanta-asiakas
        static char KysyKantis()
        {
            return 'k';
            /*Console.WriteLine("Onko asiakas kanta-asiakas (k/e)? ");
            char kantis = Console.ReadLine()[0];
            return kantis;*/
        }

        // Kysytään maksun summa
        static double KysyRaha(double summa)
        {
            /*Console.WriteLine("Anna maksun summa: ");
            double maksu = double.Parse(Console.ReadLine());
            return maksu;*/
            return summa;
        }
    }

}
    

