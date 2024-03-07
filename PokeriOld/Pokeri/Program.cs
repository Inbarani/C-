using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luo uusi peli
            Poker pokerPeli = new Poker();

            //Lisää pelaajille kädet
            pokerPeli.LisaaTyhjaKasi("Mikki");
            pokerPeli.LisaaTyhjaKasi("Hessu");

            //jaa peliin kortit
            pokerPeli.JaaKortit();

            //Hae pelin kädet
            List<Kasi> kadet = pokerPeli.Kadet;
            string luettu;
            string[] tekstina;
            List<Kortti> poistettavat;

            foreach (Kasi kasi in kadet)
            {
                Console.WriteLine(kasi.Pelaaja);
                Console.WriteLine(kasi);
                Console.WriteLine("Anna poistettavien korttien numerot (välilyönti välissä):");
                luettu = Console.ReadLine();
                tekstina = luettu.Split(',');
                poistettavat = new List<Kortti>();
                Kortti pois;

                foreach (string tekstiluku in tekstina)
                {
                    pois = kasi.HaeKorttiPaikasta(int.Parse(tekstiluku));
                    poistettavat.Add(pois);
                }
                foreach(Kortti poistettava in poistettavat)
                {
                    kasi.PoistaKortti(poistettava);
                }
                

                
            }
            pokerPeli.JaaKortit();
            foreach (Kasi kasi in kadet)
                {
                    Console.WriteLine(kasi.Pelaaja);
                    Console.WriteLine(kasi);
                }

            Console.ReadLine();

        }
    }
}
  



