using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Decimal> arvot;
            string arvotTekstina;

            arvot = LueArvot();
            Console.WriteLine(arvot.Count);
            arvotTekstina = MuunnaListaTekstiksi(arvot);
            Console.WriteLine(arvotTekstina);
            Console.WriteLine(arvot[arvot.Count - 1]);
            decimal keskiarvo = LaskeKeskiarvo(arvot);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
            Console.WriteLine("Suurin on paikassa " + HaeSuurimmanSijainti(arvot));
            Console.WriteLine("Haettu löytyy kohdasta " + HaeValilta(arvot, 5, 1));

            Console.ReadKey();
        }

        static List<decimal> LueArvot()
        {
            char[] erottimet = new char[] { ' ' };
            string luettu;
            string[] arvotTekstina;
            List<decimal> mittausarvot = new List<decimal>();

            Console.WriteLine("Anna arvot välilyönnillä erotettuina");
            luettu = Console.ReadLine();
            arvotTekstina = luettu.Split(erottimet);

            foreach (string arvoTekstina in arvotTekstina)
            {
                string muokattuArvoTekstina = arvoTekstina.Replace(',', '.');
                decimal arvo = Convert.ToDecimal(muokattuArvoTekstina, CultureInfo.InvariantCulture);
                mittausarvot.Add(arvo);
                
            }

            return mittausarvot;
        }

        static decimal LaskeKeskiarvo(List<decimal> arvot)
        {
            decimal summa = 0, keskiarvo;

            foreach (decimal arvo in arvot)
            {
                summa = summa + arvo;
            }
            keskiarvo = summa / arvot.Count;

            return keskiarvo;
        }

        static string MuunnaListaTekstiksi(List<decimal> arvot)
        {
            string listaTekstina;

            listaTekstina = arvot.Count.ToString() + " arvoa: ";

            foreach (decimal arvo in arvot)
            {
                listaTekstina = listaTekstina + " " + arvo.ToString();
            }

            return listaTekstina;
        }

        static int HaeSuurimmanSijainti(List<decimal> arvot)
        {
            decimal suurin = arvot[0];
            int suurimmanIndeksi = 0;

            for (int i = 1; i < arvot.Count; i++)
            {
                if (arvot[i] > suurin)
                {
                    suurin = arvot[i];
                    suurimmanIndeksi = i;
                }
            }

            return suurimmanIndeksi;
        }

        static int HaeValilta(List<decimal> arvot, decimal haettava, int vali)
        {
            for (int i = 0; i < arvot.Count; i++)
            {
                if (Math.Abs(arvot[i] - haettava) <= vali)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}