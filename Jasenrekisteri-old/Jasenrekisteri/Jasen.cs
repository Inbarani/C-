using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasenrekisteri
{
    public class Jasen
    {
        public string Sukunimi { get; set; }
        public string Etunimi { get; set; }
        public string Osoite { get; set; }
        public string Postitoimipaikka { get; set; }
        public string Postinumero { get; set; }
        public int Liittymisvuosi { get; set; }
        public List<Maksu> Maksut { get; set; }

        public Jasen(string sukunimi, string etunimi, string osoite, string postitoimipaikka, string postinumero, int liittymisvuosi)
        {
            Sukunimi = sukunimi;
            Etunimi = etunimi;
            Osoite = osoite;
            Postitoimipaikka = postitoimipaikka;
            Postinumero = postinumero;
            Liittymisvuosi = liittymisvuosi;
            Maksut = new List<Maksu>();
        }
       
            
          
            
                
    }
}



