using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Määritelee luvut
            double luku1, luku2;
            //Kysy käyttäjältä luvut
            Console.WriteLine("Anna luku1:");
            luku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku2");
            luku2 = double.Parse(Console.ReadLine());

            //Kysy käyttäjältä Mitä haluat tehdä?
            Console.WriteLine("Mitä haluat tehdä?");
            Console.WriteLine("1 - Laske yhteen");
            Console.WriteLine("2 - Vähennä");
            Console.WriteLine("3 - Kerro");
            Console.WriteLine("4 - Jaa");

            Console.WriteLine("Anna valinta: ");
            int valinta =int.Parse(Console.ReadLine());

            // Tarkista, onko valinta laillinen.
            if (valinta <1 || valinta >4 ) {
                Console.WriteLine("Valinnan piti olla 1 - 4");
            
            }
            else
            {
                // Tee laskutoimitus käyttäjän valinnan mukaan.
                switch (valinta) 
                {
                    case 1:
                        Console.WriteLine(luku1 + luku2);
                        break;
                    case 2:
                        Console.WriteLine(luku1 - luku2);
                        break;
                    case 3:
                        Console.WriteLine(luku1 * luku2);
                        break;
                    case 4:
                        Console.WriteLine(luku1 / luku2);
                        break;


                    
                 }
            }


            Console.ReadLine();



        }
    }
}
