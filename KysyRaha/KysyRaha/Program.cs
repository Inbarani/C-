using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KysyRaha
{
    internal class Program
    {
       static void Main(string[] args)
        {

            // Aseta loppusumma
            double loppusumma = 10.0;

            // Kysy rahamäärä
            double maksettu = KysyRaha(loppusumma);

            // Tulosta maksettu rahamäärä
           Console.WriteLine("Maksettu summa: {0}", maksettu);
            Console.ReadLine();


        }
        ///<summary>Funktio kysyy käyttäjältä annettua rahamäärää
        ///kunnes käyttäjä antaa lukuarvon. Funktio varmistaa,että 
        /// annettu rahamäärä riittää maksamiseen.</summary>
        ///<returns>Funktio palauttaa annetun rahamäärän liukulukuna (double)</returns>
        static double KysyRaha(double loppusumma)
        {
            string luettu;
            double maksettu;
            bool onnistuiko;

            do
            {
                Console.WriteLine("Anna rahamäärä: ");
                luettu = Console.ReadLine();
                onnistuiko = double.TryParse(luettu, out maksettu);
                if (onnistuiko == false)
                {
                    Console.WriteLine("Rahamäärän pitää olla lukuarvo. Yritä uudelleen.");
                }
                else
                {
                    break;
                }
            } while (true);

            return maksettu;
        }
    }
}
