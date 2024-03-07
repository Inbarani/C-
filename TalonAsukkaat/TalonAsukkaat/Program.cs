using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalonAsukkaat
{
    class TaloTesti
    {
        static void Main(string[] args)
        {
            Talo talo = new Talo("Kierniemenraitti 2");
            Asukas kalleAsukas = new Asukas("Kalle", true);
            Asukas iska = new Asukas("Pekka", false);
            talo.LisaaAsukas(kalleAsukas);
            talo.LisaaAsukas(iska);

            Console.WriteLine(talo.HaeAsukasmaara());
            List<Asukas> asukaslista = talo.HaeAsukkaat();

            Console.WriteLine("Talossa on {0} asukasta.", talo.HaeAsukasmaara());
            foreach(Asukas asukas in asukaslista)
            {
                Console.Write(asukas.HaeNimi());
                if(asukas.OnkoOmaHuone() == true)
                {
                    Console.WriteLine(" asuu omassa huoneessa.");
                }
                else
                {
                    Console.WriteLine(":lla ei ole omaa huonetta.");
                }
                Console.ReadLine();
            }
        }
    }
}
