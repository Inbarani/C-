using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListanPerusjuttu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lukuLista;
            lukuLista = new List<int>();

            // Lisätään viisi kokonaislukua listaan
            lukuLista.Add(11);
            lukuLista.Add(22);
            lukuLista.Add(5);
            lukuLista.Add(8);
            lukuLista.Add(55);

            Console.WriteLine("Lisätään viisi kokonaislukua listaan:");

            foreach (int luku in lukuLista)
            {
                Console.WriteLine(luku);
            }


            //Tulostetaan listan pituus
            Console.WriteLine("Listan pituus:" + lukuLista.Count);

            //Tulostetaan kohdassa 2 oleva arvo
            Console.WriteLine("Kohdassa 2 oleva arvo:" + lukuLista[1]);

            //Korvataan vimeinan arvo arvolla 100
            lukuLista[lukuLista.Count - 1]=100;
            Console.WriteLine("Korvataan vimeinan arvo arvolla 100:");
            foreach (int luku in lukuLista)
            {
                Console.WriteLine(luku);
            }

            //Lisätään luvut 32 ja 0 listan loppuun
            lukuLista.AddRange(new int[] { 32, 0 });
            Console.WriteLine("Lisätään luvut 32,0 listan loppuun");
            foreach (int luku in lukuLista)
            {
                Console.WriteLine(luku);
            }
            

            //Tarkistetaan, löytyykö listasta luku 5
            Console.WriteLine("Löytyykö listasta luku 5: " + lukuLista.Contains(5));

            //Haetaan ensimmäinen luku, joka on pienempi kuin 10
            int lukuAlle10 = lukuLista.First(x => x < 10);
            Console.WriteLine("Ensin pienempi kuin 10: " + lukuAlle10);

            // Haetaan luvut, jotka ovat suurempia kuin 20
            Console.WriteLine("Luvut, jotka ovat suurempia kuin 20: ");
            List<int> suuremmatLuvut = lukuLista.Where(x => x > 20).ToList();
            foreach (int luku in suuremmatLuvut) { 
                Console.WriteLine(luku); 
            }

            //Lisää kohtaan 0 luvun 7 ja tulostaa listan tämän jälkeen.
            lukuLista.Insert(0, 7);
            Console.WriteLine("Lisää kohtaan 0 luvun 7: ");
            foreach (int luku in lukuLista)
            {
                Console.WriteLine(luku);
                
            }


            //Poistaa kaikki kymmentä suuremmat luvut ja tulostaa listan tämän jälkeen.
            lukuLista.RemoveAll(x => x > 10);
            Console.WriteLine("Poistaa kaikki kymmentä suuremmat luvut listasta: ");
            foreach (int luku in lukuLista)
            {
                Console.WriteLine(luku);
            }


            //Poistaa luvun kohdasta 1 ja tulostaa listan.
            lukuLista.RemoveAt(1);
            Console.WriteLine("Poistaa luvun kohdasta 1 listasta: ");
            foreach (int luku in lukuLista)
            {
                Console.Write(luku);
            }

            Console.ReadLine();




        }
    }
}

