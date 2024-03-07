using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyra
{
    public class Ympyra
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Sade { get; set; }

        public Ympyra(double x,double y, double sade)
        {
            X = x;
            Y = y;
            Sade = sade;
        }

        public double PintaAla()
        {
            return Math.PI * Sade * Sade;
        }

    }
}
