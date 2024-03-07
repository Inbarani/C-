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
        public DateTime Maksupäivä { get; set; }
        public double Maara { get; set; }
        public Jasen Maksaja { get; set; }
    }
}
