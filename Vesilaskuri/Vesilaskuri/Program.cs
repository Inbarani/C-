using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vesilaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vesivarasto = SyotaDoubleArvo("Paljonko vettä on jäljellä? ");
            double vedenkulutusTunnissa = SyotaDoubleArvo("Monta litraa vettä kuluu tunnissa? ");
            double matkanopeusKmTunnissa = SyotaDoubleArvo("Monta kilometriä tunnissa etenet? ");
            double jaljellaOlevaMatkaKm = SyotaDoubleArvo("Monta kilometriä on jäljellä? ");

            double tarvittavaAikaTunnissa = jaljellaOlevaMatkaKm / matkanopeusKmTunnissa;
            double tarvittavavesi = tarvittavaAikaTunnissa * vedenkulutusTunnissa;
            double tarvitaanLisaaVetta = tarvittavavesi - vesivarasto;


            TimeSpan aika = TimeSpan.FromHours(tarvittavaAikaTunnissa);

            Console.WriteLine($"Matkaan menee aikaa noin {aika.Hours} tuntia {aika.Minutes} minuuttia.");


            if (tarvitaanLisaaVetta < 0)
            {
                Console.WriteLine($"Vesi riittää, yli jää {Math.Abs(tarvitaanLisaaVetta):F1} litraa.");
            }
            else if (tarvitaanLisaaVetta > 0)
            {
                Console.WriteLine($"Etsi jostakin {tarvitaanLisaaVetta:F1} litraa vettä.");
            }
            else
            {
                Console.WriteLine("Vesi riittää täydellisesti.");
            }
            Console.ReadLine();
        }

        static double SyotaDoubleArvo(string kysymys)
        {
            double arvo;
            bool syoteOnKelvollinen = false;

            do
            {
                Console.Write(kysymys);
                string syote = Console.ReadLine().Replace(',', '.'); // Mahdollistaa desimaalipilkun tai -pisteen käytön
                syoteOnKelvollinen = double.TryParse(syote, out arvo);

                if (!syoteOnKelvollinen)
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
                }
            } while (!syoteOnKelvollinen);

            return arvo;
        }
    }
}

