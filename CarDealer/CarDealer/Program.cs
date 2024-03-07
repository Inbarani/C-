using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto kauppa = new Auto();

            // Lisätään joitakin esimerkki-autoja kauppaan
            kauppa.LisaaAuto("Toyota", "Corolla", "ABC123", 20000);
            kauppa.LisaaAuto("Ford", "Focus", "XYZ789", 15000);
            kauppa.LisaaAuto("Honda", "Civic", "DEF456", 35000);
            kauppa.LisaaAuto("Nissan", "Sentra", "GHI789", 13000);
            kauppa.LisaaAuto("Volkswagan", "Golf", "JKL456", 22000);


            // Haetaan autot merkin perusteella
            string haettuMerkki = "Volkswagan";
            List<Tuple<string, string, string, double>> toyotaAutot = kauppa.HaeAutotMerkilla(haettuMerkki);

            Console.WriteLine($"Autot merkillä {haettuMerkki}:");
            foreach (var auto in toyotaAutot)
            {
                Console.WriteLine($"Merkki: {auto.Item1}, Malli: {auto.Item2}, Rekisterinumero: {auto.Item3}, Ajetut kilometrit: {auto.Item4}");
            }

            // Haetaan vähiten ajetut autot
            int maara = 2;
            List<Tuple<string, string, string, double>> vahitenAjettujenAutot = kauppa.HaeVahitenAjettujenAutot(maara);

            Console.WriteLine($"\nVähiten ajetut autot ({maara} kpl):");
            foreach (var auto in vahitenAjettujenAutot)
            {
                Console.WriteLine($"Merkki: {auto.Item1}, Malli: {auto.Item2}, Rekisterinumero: {auto.Item3}, Ajetut kilometrit: {auto.Item4}");
                Console.ReadLine();
            
            }
        }
    }
}
