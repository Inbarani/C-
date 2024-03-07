using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Luo kaksi ympyrää
            Ympyra ympyra1 = new Ympyra(10, 20, 9);
            Ympyra ympyra2 = new Ympyra(10, 20, 15);

            // Tarkista ympyröiden sijainti suhteessa toisiinsa
            double etaisyys = Math.Sqrt(Math.Pow(ympyra2.X - ympyra1.X, 2) + Math.Pow(ympyra2.Y - ympyra1.Y, 2));

            if (etaisyys >= ympyra1.Sade + ympyra2.Sade)
            {
                Console.WriteLine("Ympyrät ovat täysin erillään.");
            }
            else if (etaisyys < ympyra1.Sade + ympyra2.Sade && etaisyys > Math.Abs(ympyra1.Sade - ympyra2.Sade))
            {
                Console.WriteLine("Ympyrät ovat osittain toistensa päällä.");

                if (ympyra1.Sade > ympyra2.Sade)
                {
                    Console.WriteLine("Ympyra1 on suurempi.");
                }
                else if (ympyra1.Sade < ympyra2.Sade)
                {
                    Console.WriteLine("Ympyra2 on suurempi.");
                }
                else
                {
                    Console.WriteLine("Ympyröiden säteet ovat yhtä suuret.");
                }
            }
            else
            {
                Console.WriteLine("Ympyrät ovat päällekkäin.");

                if (ympyra1.Sade > ympyra2.Sade)
                {
                    Console.WriteLine("Ympyra1 on suurempi.");
                }
                else if (ympyra1.Sade < ympyra2.Sade)
                {
                    Console.WriteLine("Ympyra2 on suurempi.");
                }
                else
                {
                    Console.WriteLine("Ympyröiden säteet ovat yhtä suuret.");
                }
            }

            Console.ReadLine();
        }
    }
}