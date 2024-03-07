using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasenrekisteri
{
    public class Maksu
    {
        public int Vuosi { get; set; }
        public DateTime Maksupaiva { get; set; }
        public decimal Maara { get; set; }
        public string Maksaja { get; set; }

        public Maksu(int vuosi, DateTime maksupaiva, decimal maara, string maksaja)
        {
            Vuosi = vuosi;
            Maksupaiva = maksupaiva;
            Maara = maara;
            Maksaja = maksaja;
        }
    }
}
