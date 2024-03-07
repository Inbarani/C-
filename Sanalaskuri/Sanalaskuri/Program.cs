using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

    namespace Sanalaskuri
    {
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give the name of the file:");
            string tiedostonNimi = Console.ReadLine();

            if (!File.Exists(tiedostonNimi))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] rivit = File.ReadAllLines(tiedostonNimi);

            int sanaLaskuri = 0;
            int merkkiLaskuri = 0;

            Dictionary<string, int> sananEsiintymat = new Dictionary<string, int>();

            foreach (string rivi in rivit)
            {
                string[] sanat = rivi.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                sanaLaskuri += sanat.Length;
                merkkiLaskuri += rivi.Length;

                foreach (string sana in sanat)
                {
                    string pudistettuSana = PoistaErimielisetMerkkeja(sana);
                    if (!string.IsNullOrEmpty(pudistettuSana))
                    {
                        string pienetKirjaimet = pudistettuSana.ToLower();
                        if (sananEsiintymat.ContainsKey(pienetKirjaimet))
                        {
                            sananEsiintymat[pienetKirjaimet]++;
                        }
                        else
                        {
                            sananEsiintymat[pienetKirjaimet] = 1;
                        }
                    }
                }
            }

            Console.WriteLine($"Words in file: {sanaLaskuri}");
            Console.WriteLine($"Characters in file: {merkkiLaskuri}");

            while (true)
            {
                Console.Write("Give a word (empty word ends): ");
                string haettavaSana = Console.ReadLine();

                if (string.IsNullOrEmpty(haettavaSana))
                    break;

                string puhdistettuHaettavaSana = PoistaErimielisetMerkkeja(haettavaSana);
                string pienetKirjaimetHaettavaSana = puhdistettuHaettavaSana.ToLower();

                if (sananEsiintymat.ContainsKey(pienetKirjaimetHaettavaSana))
                {
                    int esiintymienMaara = sananEsiintymat[pienetKirjaimetHaettavaSana];
                    Console.WriteLine($"Word {haettavaSana} occurs {esiintymienMaara} times.");
                }
                else
                {
                    Console.WriteLine($"Word {haettavaSana} occurs 0 times.");
                }
            }
        }

        static string PoistaErimielisetMerkkeja(string syote)
        {
            return new string(syote.Where(char.IsLetterOrDigit).ToArray());
        }
    }
}

