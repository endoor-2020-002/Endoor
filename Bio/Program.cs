using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opdracht 1.1
            Console.WriteLine("Govert Combée");
            Console.WriteLine("Fazantstraat 144");
            Console.WriteLine("7523EC Enschede");
            Console.WriteLine("42 jaar");

            // of op de moeilijke manier:
            string naamVoorNaam = "Govert";
            string naamAchternaam = "Combée";
            string adresStraatNaam = "Fazantstraat";
            string adresHuisNummer = "144"; // sommige huisnummers zijn met 144a of 135b, vandaar keuze voor string.
            string adresPostcode = "7523EC";
            string adresStad = "Enschede";
            int leeftijd = 42;
            Console.Write($@"
{naamVoorNaam} {naamAchternaam}
{adresStraatNaam} {adresHuisNummer}
{adresPostcode} {adresStad}
{leeftijd} jaar
            ");

            //Opdracht 1.2
            Console.Write($@"
********************
*** {naamVoorNaam} ***
********************
             ");
            Console.ReadKey();
        }
    }
}
