using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilit
{
    public class PankkiTesti
    {
        static void Main()
        {
            Console.WriteLine("Luodaan testiasiakas.");

            // Luo asiakasolio
            Asiakas asiakas = new Asiakas(54321, "Teemu Datanomi");

            Console.WriteLine("Luodaan tili. Sen saldo on nyt: ");

            //Luo tiliolio
            Tili asiakkaanTili = new Tili(asiakas);

            // Kysy tilin saldon ja tulosta se
            double saldo = asiakkaanTili.Saldo;
            Console.WriteLine("Tilin saldo on: " + saldo);

            Console.WriteLine("Talletetaan vähän rahaa tilille. Saldo on nyt: ");

            // tallentaa 4000 euroa tilille-metodikutsu
            asiakkaanTili.Talleta(4000);

            //tulostaa tilin saldon uudelleen
            saldo = asiakkaanTili.Saldo;
            Console.WriteLine("Tilin saldo on: " + saldo);

            Console.WriteLine("Otetaan 2500€ rahaa tililtä. Saldo on nyt: ");

            //Ottaa 2500 euroa tililtä
            asiakkaanTili.Nosta(2500);

            //Tulosta tilin saldon vielä kerran
            saldo =asiakkaanTili.Saldo;
            Console.WriteLine("Tilin saldo on:" + saldo);

            Console.WriteLine("Otetaan 2000€ rahaa. Saldo on nyt: ");

            // ottaa 2000 euroa tililtä.
            asiakkaanTili.Nosta(2000);

            //Tulosta tilin saldon vielä kerran(tilillä ei ole riittävästi rahaa)
            saldo = asiakkaanTili.Saldo;
            Console.WriteLine("Tilin saldo on:" + saldo);

            Console.WriteLine("Luodaan toinen tili samalle asiakkaalle. Sen saldo on nyt: ");

            //Luo toinen tili samalle asiakkalle
            Tili toinenTili = new Tili(asiakas);

            // Kysy tilin saldon ja tulosta se
            double toisenTilinSaldo = toinenTili.Saldo;
            Console.WriteLine("Tilin saldo on: " + toisenTilinSaldo);

            Console.WriteLine("Siirretään rahaa tokalta tililtä ekalle. Tilien saldot ovat nyt:");

            // Siirrä 1800 euroa toiselta tililtä ensimmäiselle
            asiakkaanTili.SiirraTilille(toinenTili, 1800);

            // Kysy tilien saldot uudelleen ja tulosta ne
            saldo = asiakkaanTili.Saldo;
            Console.WriteLine("Ensimmäisen tilin saldo on: " + saldo);

            toisenTilinSaldo = toinenTili.Saldo;
            Console.WriteLine("Toisen tilin saldo on: " + toisenTilinSaldo);







            Console.ReadLine();



        }
    }

}
