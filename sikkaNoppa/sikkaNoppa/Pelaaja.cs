using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikkaNoppa
{
    public class Pelaaja
    {
        public string Nimi { get; }
        public int Pisteet { get; private set; }

        public Pelaaja(string nimi)
        {
            Nimi = nimi;
            Pisteet = 0;
        }

        public void Vuoro()
        {
            Console.WriteLine($"{Nimi}, on vuorosi. Paina Enter heittaaksesi noppaa.");
            Console.ReadLine();
            Random random = new Random();
            int heitto = random.Next(1, 7);

            Console.WriteLine($"{Nimi} heitti {heitto}.");

            if (heitto == 1)
            {
                Console.WriteLine($"{Nimi} sai ykkösen ja menetti kierroksen pisteet.");
                Pisteet = 0;
            }
            else
            {
                Console.WriteLine($"{Nimi} voitti {heitto} pistettä!");
                Pisteet += heitto;
            }
        }
    }
}
