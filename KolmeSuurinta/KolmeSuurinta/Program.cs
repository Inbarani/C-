using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolmeSuurinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan lista
            List<int> lukuLista = new List<int>();
            Console.WriteLine("Anna kokonaislukuja. Lopeta antamalla -1 ");
            while (true)
            {
                int luku;
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());

                if (luku == -1)
                {
                    break;
                } lukuLista.Add(luku);

            }
           
            Console.Write("Lukulista : ");
            
            // Tulostetaan syötetyt luvut
            foreach (int luku in lukuLista) {
                
                Console.Write(luku +" "); 
            }
            Console.WriteLine();


            // Tulostetaan kolme suurinta lukua
            List<int> suuremmatLuvut = lukuLista.OrderByDescending(x => x).Take(3).ToList();
            Console.Write("Kolme suurinta ovat: ");

            foreach (int luku in suuremmatLuvut)
            {
                Console.Write(luku + " ");

            }

            Console.ReadLine();

            
            

        }
    }
}
