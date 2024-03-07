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

            Jasen jasen1 = new Jasen("Jakala", "Heini", "Osoite1", "Postitoimipaikka1", "00100", 2020);
            Jasen jasen2 = new Jasen("Kaarna", "Laura", "Osoite2", "Postitoimipaikka2", "00200", 2021);

            rekisteri.LisaaJasen(jasen1);
            rekisteri.LisaaJasen(jasen2);

            rekisteri.LisaaMaksu("Jakala", "Heini", 2020, DateTime.Now, 50.0m, "Maksaja1");
            rekisteri.LisaaMaksu("Kaarna", "Laura", 2021, DateTime.Now, 60.0m, "Maksaja2");

            List<Jasen> maksuttomat = rekisteri.HaeMaksuttomatJasenet(2021);
            foreach (Jasen jasen in maksuttomat)
            {
                Console.WriteLine($"{jasen.Etunimi} {jasen.Sukunimi} ei ole maksanut jäsenmaksua vuonna 2021.");
            }

            Console.ReadLine();
        }
    }
}



