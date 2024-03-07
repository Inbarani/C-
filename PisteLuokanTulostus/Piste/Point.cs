using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piste
{
    public class Point
    {
        public int X { get; set; } // Ominaisuus x:lle
        public int Y { get; set; } // Ominaisuus y:lle

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
           return $"({this.X}, {this.Y})";
            
        }



    }
}
