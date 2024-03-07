using System;


namespace Papukaija
{
    class PapukaijaTesti
    {
        static void Main()
        {
            Papukaija eka = new Papukaija("Polli", "kirjava");
            Console.WriteLine(eka);
            Console.WriteLine(eka.Puhu());
            eka.OpiLause("Silliä pöytään");

            //ToDo: Luo lisää papukaijoja ja opeta niitä puhumaan

            Papukaija toka = new Papukaija("Kippari", "punainen");
            Console.WriteLine(toka);
            Console.WriteLine(toka.Puhu());
            toka.OpiLause("Hei, maailma!");
            

            Papukaija kolmas = new Papukaija("Nöpö", "sininen");
            Console.WriteLine(kolmas);
            Console.WriteLine(kolmas.Puhu());
            kolmas.OpiLause("Minä olen papukaija");
            
            Console.ReadLine();

            
        }

    }
}
