using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasenrekisteri
{
    public class Jasenrekisteri
    {
        private List<Jasen> jasenet = new List<Jasen>();
        private List<Maksu> maksut = new List<Maksu>();
        public void LisaaJasen(Jasen jasen)
        {
            jasenet.Add(jasen);
        }

        public void PoistaJasen(string sukunimi, string etunimi)
        {
            jasenet.RemoveAll(j => j.Sukunimi == sukunimi && j.Etunimi == etunimi);
        }

        public void LisaaMaksu(string sukunimi, string etunimi, int vuosi, DateTime maksupaiva, decimal maara, string maksaja)
        {
            Jasen jasen = jasenet.FirstOrDefault(j => j.Sukunimi == sukunimi && j.Etunimi == etunimi);
            if (jasen != null)
            {
                Maksu maksu = new Maksu(vuosi, maksupaiva, maara, maksaja);
                jasen.Maksut.Add(maksu);
            }
        }

        public List<Jasen> HaeMaksuttomatJasenet(int vuosi)
        {
            return jasenet.Where(j => !j.Maksut.Any(m => m.Vuosi == vuosi)).ToList();
        }
    }
}

