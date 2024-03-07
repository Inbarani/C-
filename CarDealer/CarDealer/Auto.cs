using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Auto
    {
        private List<Tuple<string, string, string, double>> autot = new List<Tuple<string, string, string, double>>();
        
        
        public void LisaaAuto(string merkki, string malli, string rekisterinumero, double ajetutKilometrit)
        {
           
            var auto = Tuple.Create(merkki, malli, rekisterinumero, ajetutKilometrit);
            autot.Add(auto);
        }

        public List<Tuple<string, string, string, double>> HaeAutotMerkilla(string merkki)
        {
            return autot.Where(auto => auto.Item1.Equals(merkki, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Tuple<string, string, string, double>> HaeVahitenAjettujenAutot(int maara)
        {
            return autot.OrderBy(auto => auto.Item4).Take(maara).ToList();
        }

    }
}
