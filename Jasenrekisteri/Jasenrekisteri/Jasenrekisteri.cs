using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasenrekisteri
{
    public class Jasenrekisteri
    {
        public List<Jasen> jasenet;
        public List<Maksu> maksut;

        public Jasenrekisteri()
        {
            jasenet = new List<Jasen>();
            maksut = new List<Maksu>();
        }

        public void LisaaJasen(int jasennumero, string sukunimi, string etunimi, string osoite, string postinumero, string postitoimipaikka, int liittymisvuosi)
        {
            Jasen jasen = new Jasen();
            jasen.Jasennumero = jasennumero;
            jasen.Sukunimi = sukunimi;
            jasen.Etunimi = etunimi;
            jasen.Osoite = osoite;
            jasen.Postinumero = postinumero;
            jasen.Postitoimipaikka = postitoimipaikka;
            jasen.Liittymisvuosi = liittymisvuosi;
            jasenet.Add(jasen);
        }

        public void PoistaJasen(Jasen jasen)
        {
            jasenet.Remove(jasen);
        }


        public void LisaaMaksu(Maksu maksu)
        
        {
            maksut.Add(maksu);
        }

        public List<Jasen> HaeMaksaamattomat(int vuosi)
        {
            List<Jasen> maksamattomat = new List<Jasen>();
            foreach (Jasen jasen in jasenet)
            {
                if (!OnMaksannut(jasen, vuosi))
                {
                    maksamattomat.Add(jasen);
                }
            }
            return maksamattomat;
        }

        public double HaeVuodenMaksut(int vuosi)
        {
            double summa = 0;
            foreach (Maksu maksu in maksut)
            {
                if (maksu.Vuosi == vuosi)
                {
                    summa += maksu.Maara;
                }
            }
            return summa;
        }

        private bool OnMaksannut(Jasen jasen, int vuosi)
        {
            foreach (Maksu maksu in maksut)
            {
                if (maksu.Maksaja.Jasennumero == jasen.Jasennumero && maksu.Vuosi == vuosi)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
