using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalonAsukkaat
{
    class Talo
    {
        string osoite;
        int asukkaita;
        List<Asukas> asukkaat;

        public Talo(string osoite)
        {
            this.osoite = osoite;
            asukkaat = new List<Asukas>();
            asukkaita = 0;
        }

        public void LisaaAsukas(Asukas asukas)
        {
            asukkaat.Add(asukas);
            asukkaita = asukkaita + 1;
        }

        public List<Asukas> HaeAsukkaat()
        {
            return asukkaat;
        }

        public int HaeAsukasmaara()
        {
            return asukkaita;
        }
    }
}
