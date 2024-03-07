using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskuKone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jatketaanko = true;
            while (jatketaanko)
            {
                int luku1, luku2;


                Console.Write("Anna luku1: ");
                luku1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Anna luku2: ");
                luku2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Valitse laskutoimitus : ");
                Console.WriteLine("1. Summa");
                Console.WriteLine("2. Erotus");
                Console.WriteLine("3. kertolasku ");
                Console.WriteLine("4. jako");

                int valinta;
                double tulos = 0;
                    
                while (!int.TryParse(Console.ReadLine(), out valinta) || valinta < 1 || valinta > 4)
                {
                    Console.WriteLine("Valitse 1- 4");
                }


                switch (valinta)
                {
                    case 1:
                        tulos = luku1 + luku2;
                        break;
                    case 2:
                        tulos = luku1 - luku2;
                        break;
                    case 3:
                        tulos = luku1 * luku2;
                        break;
                    case 4:
                        if (luku1 != 0)
                        {
                            tulos = (double)luku1 / luku2;
                        }
                        else
                        {
                            Console.WriteLine("virhe");
                            return;
                        }
                        break;

                }
                Console.WriteLine("Tulos: " + tulos);

                Console.Write("Jatketaanko k/e : ");
                string vastaus = Console.ReadLine();
                if (vastaus == "e" || vastaus =="E")

                {
                    jatketaanko = false;
                }
                

            }


        }
    }
}
