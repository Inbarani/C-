using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KolikonHeitto
{
    public class Kolikko
    {
        private int[] heitot;

        public Kolikko(int[] alustus)
        {
            heitot = alustus;
        }

        public void PaivitaHeitot()
        {
            // Päivitä kruunujen ja klaavojen lukumäärät
            int kruunut = 0;
            int klaavat = 0;

            foreach (int tulos in heitot)
            {
                if (tulos == 1)
                    kruunut++;
                else if (tulos == 0)
                    klaavat++;
            }

            
        }

        public string PalautaTiedotTekstina()
        {
            // Palauta tiedot tekstinä
            return "Kolikkoa heitetty " + heitot.Length+ " kertaa" + "\nKruunujen määrä: " + KruunujenMaara() + "\nKlaavojen määrä: " + KlaavojenMaara();
        }

        public int KruunujenMaara()
        {
            // Laske kruunujen määrä
            int kruunut = 0;

            foreach (int tulos in heitot)
            {
                if (tulos == 1)
                    kruunut++;
            }

            return kruunut;
        }

        public int KlaavojenMaara()
        {
            // Laske klaavojen määrä
            int klaavat = 0;

            foreach (int tulos in heitot)
            {
                if (tulos == 0)
                    klaavat++;
            }

            return klaavat;
        }
    }
}