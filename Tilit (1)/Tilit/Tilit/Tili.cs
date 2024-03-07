using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilit
{
    /// <summary>
    /// Yksinkertaisen pankkijärjestelmän tiliä esittävä luokka.
    /// </summary>
    public class Tili
    {
        // Tilin saldo.
        private double saldo; 
        private Asiakas tilinOmistaja;

        /// <summary>
        /// Luo uuden tiliolion asiakkaalle
        /// </summary>
        /// <param name="omistaja">asiakas, jolle tili kuuluu.</param>
        public Tili(Asiakas omistaja)
        {
            tilinOmistaja = omistaja;
            saldo = 0;
        }


        public Asiakas Omistaja
        {
            get
            {
                return tilinOmistaja;
            }
        }


        public double Saldo
        {
            get
            {
                return saldo;
            }
        }


        public void Talleta(double maara)
        {
            saldo = saldo + maara;
        }


        public double Nosta(double maara)
        {
            if (maara > 0 && maara <= saldo)
            {
                saldo = saldo - maara;
                return maara;

            }
            else
            {
                Console.WriteLine("Nosto epäonnistui: Tilillä ei ole tarpeeksi rahaa.");
                return 0;

            }
                
        }


        public void SiirraTilille(Tili toinenTili, double maara)
        {
            Nosta(maara);
            toinenTili.Talleta(maara);
        }
    }
}