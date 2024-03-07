using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasenrekisteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jasenrekisteri rekisteri = new Jasenrekisteri();

            // Lisää jäsenet
            rekisteri.LisaaJasen(1, "Mäkinen", "Matti", "Käyntikatu 12", "10100", "Helsinki", 2022);
            rekisteri.LisaaJasen(2, "Laitinen", "Maija", "Rantakatu 34", "20200", "Turku", 2022);
            rekisteri.LisaaJasen(3, "Nieminen", "Antti", "Pohjoiskatu 56", "30300", "Tampere", 2022);
            // Print the list of added members in a single line
            Console.WriteLine("Lisää jäsenet: ");
            foreach (Jasen jasen in rekisteri.jasenet)
            {
                string jasenetTiedot = $"Jasennumero: {jasen.Jasennumero}, Sukunimi: {jasen.Sukunimi}, Etunimi: {jasen.Etunimi}, Osoite: {jasen.Osoite}, Postinumero: {jasen.Postinumero}, Postitoimipaikka: {jasen.Postitoimipaikka}, Liittymisvuosi: {jasen.Liittymisvuosi}";
                Console.WriteLine(jasenetTiedot);
              
            }
            Console.WriteLine() ;
            // Lisää maksut
            rekisteri.LisaaMaksu(new Maksu() { Vuosi = 2022, Maksupäivä = new DateTime(2022, 7, 20), Maara = 50.00, Maksaja = rekisteri.jasenet[0] });
            rekisteri.LisaaMaksu(new Maksu() { Vuosi = 2022, Maksupäivä = new DateTime(2022, 8, 10), Maara = 40.00, Maksaja = rekisteri.jasenet[1] });
            
            // tulostaa lisää maksut
            Console.WriteLine("List of Payments:");
            foreach (Maksu maksu in rekisteri.maksut)
            {
                Console.WriteLine($"Vuosi: {maksu.Vuosi}, Maksupäivä: {maksu.Maksupäivä}, Maara: {maksu.Maara}, Maksaja: {maksu.Maksaja.Sukunimi}, {maksu.Maksaja.Etunimi}");
            }
            Console.WriteLine();

            // Tulosta maksamattomat
            List<Jasen> maksamattomat = rekisteri.HaeMaksaamattomat(2022);
            foreach (Jasen jasen in maksamattomat)
            {
                Console.WriteLine("Maksamattomat jasenet: "+ jasen.Sukunimi + " " + jasen.Etunimi);
            }
            Console.WriteLine();

            // Tulosta vuoden maksut
            double summa = rekisteri.HaeVuodenMaksut(2022);
            Console.WriteLine("Vuoden 2022 maksut: {0}", summa);
            Console.WriteLine();    
            
            // Poista jäsen rekisteristä
            rekisteri.PoistaJasen(rekisteri.jasenet[0]);
            
            // Tulosta poistettu jäsen
            Console.WriteLine("Poistettu jäsen:");
            Console.WriteLine(rekisteri.jasenet[0].Sukunimi + " " + rekisteri.jasenet[0].Etunimi);


            Console.ReadLine();
        }
    }
    
}
