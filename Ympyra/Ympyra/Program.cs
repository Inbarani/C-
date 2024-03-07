using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ympyra ympyra = new Ympyra(10,20,5);

           ympyra.X = 10;
            ympyra.Y = 20;
            ympyra.Sade = 5;

            Console.WriteLine("Pinta ala: {0:0.00}" , ympyra.PintaAla());
            Console.ReadLine();
        }
    }
}
