using System;

namespace ArvaaLukua
{
    internal class Program
    {
        /// <summary>
        /// Luo satunnaislukugeneraattorin esiintymä
        /// </summary>
        static Random random = new Random();

        static void Main(string[] args)
        {
            //Aloita peli

            StartGame();
        }
        /// <summary>
        /// // Metodi pelin aloittamiseksi
        /// </summary>
        static void StartGame()
        {
            // Pyydä käyttäjää syöttämään lukuvälin yläraja
            Console.Write("Syötä lukualueen yläraja: ");
            int lukualue = int.Parse(Console.ReadLine());

            // Generoidaan satunnaisluku annetulla alueella
            int arvottuLuku = random.Next(1, lukualue + 1);

            // Kutsu PelaaPelia-metodia, joka käsittelee arvauslogiikan
            PlayGame(lukualue, arvottuLuku);

            // Kysy haluaako käyttäjä pelata uudelleen
            Console.Write("Haluatko arvata uuden luvun? K tai Ei: ");
            string vastaus = Console.ReadLine();
            if (vastaus == "K")
            {
                StartGame();
            }
        }
        
        // Metodi arvauslogiikan käsittelyyn
        static void PlayGame(int lukualue, int arvottuLuku)
        {
            int arvaus;
            do
            {
                // Pyydä käyttäjää arvaamaan numero
                Console.Write("Arvaa luku väliltä 1 ja {0}: ", lukualue);
                arvaus = int.Parse(Console.ReadLine());

                // Anna palautetta käyttäjän arvauksen perusteella
                if (arvaus == arvottuLuku)
                {
                    Console.WriteLine("Oikein! Arvioit oikein.");
                }
                else if (arvaus > arvottuLuku)
                {
                    Console.WriteLine("Arvauksesi oli liian suuri.");
                }
                else
                {
                    Console.WriteLine("Arvauksesi oli liian pieni.");
                }
            } while (arvaus != arvottuLuku);
        }
    }
}
