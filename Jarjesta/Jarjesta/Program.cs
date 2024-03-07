using System;


namespace Jarjesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paivamaara, lampo;
            String viikonpaiva, kuu;
            lampo = 17;
            viikonpaiva = "Tiistai";
            paivamaara = 16;
            kuu = "elo";

            Console.Write("Tänään on " + viikonpaiva + " ");
            Console.WriteLine("{0}. {1}kuuta.", paivamaara, kuu);
            Console.WriteLine();
            Console.WriteLine("Lämmintä on " + lampo + " astetta.");
            

            Console.ReadKey();
        }
    }
}
