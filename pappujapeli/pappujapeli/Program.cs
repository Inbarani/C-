﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// <summary>
/// Luokka esittää papupeliä, jossa  on kasa papuja,
/// joista jokainen pelaaja ottaa vuorollaan 1, 2, tai 3 papua.
/// Pelin häviää se, joka joutuu ottamaan viimeisen pavun.
/// Ohjelmasta puuttuvat funktiot papujen ottamiselle.
/// </summary>

namespace pappujapeli
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //pelaajat ja niiden nimet
            string pelaaja1 = "Pelaaja1";
            string pelaaja2 = "Pelaaja2";
            //vuoronumerot peliin: 0 ja 1
            //pelaaja 1 aloittaa, vuoronumero on 0
            int vuoro = 0;
            //hävinneen pelaajan vuoronumero
            int haviaja;
            //papujen määrä pelin alussa, voi muuttaa
            int papuja = 10;
            //kuinka monta papua pelaaja otti
            int otettu;

            //Pelin silmukka. Kutsutaan kummankin pelaajan ottamisfunktiota.
            //Ottamisen jälkeen tutkitaan jäikö käteen viimeinen papu,
            //jolloin pelaaja hävisi ja toito loppuu.
            while (true)
            {
                //kutsutaan funktiota, joka kysyy otettavien papujen määrän
                otettu = Pelaaja1Ottaa(papuja);
                //vähentää papujen määrää otetuilla
                papuja = papuja - otettu;
                Console.WriteLine("{0} otti {1}: jäljellä {2}.", pelaaja1, otettu, papuja);
                //ottiko pelaaja viimeisen pavun
                if (papuja == 0)
                {
                    //otetaan talteen häviäjän vuoronumero
                    haviaja = vuoro;
                    break;
                }
                //Vaihdetaan vuoro
                vuoro = 1;
                //Kutsutaan toisen pelaajan ottamisfunktiota
                otettu = Pelaaja2Ottaa(papuja);
                //Vähennetään papujen kokonaismäärää otetuilla
                papuja = papuja - otettu;
                Console.WriteLine("{0} otti {1}: jäljellä {2}.", pelaaja2, otettu, papuja);
                //Jäikö käteen viimeinen
                if (papuja == 0)
                {
                    //otetaan talteen häviäjän vuoronumero
                    haviaja = vuoro;
                    break;
                }
                //Vuoro vaihtuu pelaajalle 1
                vuoro = 0;
            }

            //Pelaaja1 hävisi
            if (vuoro == 0)
            {
                Console.WriteLine("{0} hävisi.", pelaaja1);
            }
            //Pelaaja 2 hävisi
            else
            {
                Console.WriteLine("{0} hävisi.", pelaaja2);
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Funktio pelaajan 1 ottamiselle.
        /// </summary>
        /// <param name="jäljelläPapus">Papujen jäljellä oleva kokonaismäärä.</param>
        /// <returns>Palauttaa pelaajan 1 ottamien papujen määrän (1-3).</returns>
        static int Pelaaja1Ottaa(int jäljelläPapus)
        {
            int otettuPapus = 0;
            bool tulos;
            while (otettuPapus < 1 || otettuPapus > 3 || otettuPapus > jäljelläPapus)
            {
                Console.Write("Syötä pelaajan 1 otettavien papujen määrä (1-3): ");
                
                tulos = int.TryParse(Console.ReadLine(), out otettuPapus);
                if (tulos ==true && otettuPapus >= 1 && otettuPapus <= 3 && otettuPapus <= jäljelläPapus)
                {
                    break;
                }
                Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
            }
            return otettuPapus;
        }

        /// <summary>
        /// Funktio pelaajan 2 ottamiselle.
        /// </summary>
        /// <param name="jäljelläPapus">Papujen jäljellä oleva kokonaismäärä.</param>
        /// <returns>Palauttaa pelaajan 2 ottaman papujen määrän (aina 1).</returns>
        static int Pelaaja2Ottaa(int jäljelläPapus)
        {
            return 1; // Kone ottaa aina yhden pavun
        }
    }
    }

