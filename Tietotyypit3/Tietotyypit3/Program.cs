using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietotyypit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //määrittää kokonaislukuarvot
            int luku1 = 357;
            //määrittää liukulukuarvot
            double luku2 = 3.56;
            //määrittää merkkejä
            char kirjain = 'F';
            //määrittää tekstiä
            string sana = "Joulupukki";
           
            Console.WriteLine("Kokonaisluku on " + luku1);
            Console.WriteLine("Liukuluku on " + luku2);
            Console.WriteLine("Merkkijono on " + sana);
            Console.WriteLine("Merkki on " + kirjain);

            Console.ReadLine();
        }
    }
}
