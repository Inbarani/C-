using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KriitikkoTeksti
{
    class KriitikkoTeksti
    {
        static void Main(string[] args)
        {
            // Luo uuden kriitikon, jolla ei ole vielä arvosteluja
            Kriitikko pena = new Kriitikko();

            // Luo uuden leffan. Parametrit: nimi, kommentti, kesto, arvostelu 0-10.
            Leffa leffa1 = new Leffa("Oblivion", "kiva", new TimeSpan(2, 36, 00), 9);
            Leffa leffa2 = new Leffa("Edge of Tomorrow", "paras", new TimeSpan(1, 53, 00), 8);
            Leffa leffa3 = new Leffa("Jack Reacher ", "huono", new TimeSpan(2, 58, 00), 6);
            Leffa leffa4 = new Leffa("Robot", "hyvä", new TimeSpan(1, 55, 00), 7);

            // Lisää leffat kriitikon arvosteluihin.
            pena.LisaaLeffa(leffa1);
            pena.LisaaLeffa(leffa2);
            pena.LisaaLeffa(leffa3);
            pena.LisaaLeffa(leffa4);
            

            // Tulosta arvostellut leffat
            Console.WriteLine("Arvostellut leffat: ");
            foreach (Leffa leffa in pena.Leffat)
            {
                Console.WriteLine($"Nimi: {leffa.Nimi}, Kommentti: {leffa.Kuvaus}, Kesto: {leffa.Pituus}, Arvestelu: {leffa.Arvosana} \n");
            }

            // Hae kriitikon suosikkileffa ja tulosta leffan nimi sekä pituus
           Console.WriteLine(pena.Suosikki.Nimi);
           Console.WriteLine(pena.Suosikki.Pituus);
           Console.WriteLine() ;

            //Tulosta kaikki arvioidut elokuvat ja tarkista, ovatko ne katsomisen arvoisia

            Leffa[] arvostellutLeffat = pena.Leffat;
           int kannattakatso = 0;

           foreach (Leffa leffa in arvostellutLeffat) {
               Console.WriteLine(leffa.Nimi);
               Console.WriteLine(leffa.Arvosana);
               Console.WriteLine(leffa.Pituus);

               if (leffa.KannattaakoKatsoa())
               {
                   Console.WriteLine("Leffa on Kannattakatso!");
                   kannattakatso++;
               } else
               {
                    Console.WriteLine("Leffa Ei ole Kannattakatso!");
               }
                Console.WriteLine();
               
           }

           Console.WriteLine(kannattakatso);

            //Kokeile verrata kahta leffaa keskenään ja tulosta vertailutulos

            
            if (leffa3.OnkoParempi(leffa4))
            {
                Console.WriteLine($"{leffa3.Nimi} on parempi kuin {leffa4.Nimi}");
            }
            else
            {
                Console.WriteLine($"{leffa4.Nimi} on parempi kuin {leffa3.Nimi}");
            }


            
            Console.ReadKey();
        }
    }
}
