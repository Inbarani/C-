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


        /* int x;
         int y;

         public Point(int x, int y)
         {
             this.x = x;
             this.y = y;
         }

         public int GetX()
         {
             return x;
         }

         public int GetY()
         {
             return y;
         }
         public void SetX(int X)
         {
             x = X;           
         }
         public void SetY(int Y)
         {
             y = Y;
         }*/

    }
}
