using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikkaNoppa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Noppapeliin!");

            Pelaaja pelaaja1 = new Pelaaja("Pelaaja 1");
            Pelaaja pelaaja2 = new Pelaaja("Pelaaja 2");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{pelaaja1.Nimi}: {pelaaja1.Pisteet} pistettä");
                Console.WriteLine($"{pelaaja2.Nimi}: {pelaaja2.Pisteet} pistettä");

                if (pelaaja1.Pisteet >= 100 || pelaaja2.Pisteet >= 100)
                {
                    Console.WriteLine("Peli päättyi!");
                    Pelaaja voittaja = (pelaaja1.Pisteet >= 100) ? pelaaja1 : pelaaja2;
                    Console.WriteLine($"{voittaja.Nimi} voitti pelin!");
                    break;
                }

                pelaaja1.Vuoro();
                if (pelaaja1.Pisteet >= 100)
                    continue;

                pelaaja2.Vuoro();
                Console.ReadLine();
            }
        }
    }

   
}