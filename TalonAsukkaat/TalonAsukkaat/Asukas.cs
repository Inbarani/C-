using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalonAsukkaat
{
    public class Asukas
    {
        private string nimi;
        private bool omaHuone;

        public Asukas(string nimi, bool omaHuone)
        {
            this.nimi = nimi;
            this.omaHuone = omaHuone;
        }
        public string HaeNimi()
        {
            return nimi;
        }
        public bool OnkoOmaHuone() 
        {
            return omaHuone;
        }

    }
}
