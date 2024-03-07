using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //määrittää kokonaislukuarvot
            int luku1;            
            //määrittää liukulukuarvot
            double luku2;
            //määrittää merkkejä
            char kirjain;
            //määrittää tekstiä
            string sana;
            luku1 = 357;
            luku2 = 3.56; 
            kirjain = "F"; 
            sana = "Joulupukki";

            Console.WriteLine("Kokonaisluku on " + luku1);
            Console.WriteLine("Liukuluku on " + luku2);
            Console.WriteLine("Merkkijono on " + sana);
            Console.WriteLine("Merkki on " + kirjain);

            Console.ReadLine();
        }
    }
}
