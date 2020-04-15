using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel euro's wenst u te wisselen naar munten?");
            string geldInvoer = Console.ReadLine();
            decimal geld = Convert.ToDecimal(geldInvoer);

            /**
            //decimal.TryParse();
            // var munten[] = new[] { 2m, 1m, 0.5m, 0.2m, 0.1m, 0.05m, 0.02m, 0.01m };
            while (munt in munten[], geld !=0 )
            {
                AantalMunten[munt] = (int)geld / munt;
                geld -= AantalMunten[munt];
            }
            **/

            // Na het weekeinde: ik had ook alles in centen kunnen berekenen, DO'H.

            // denk code:
            //even de centen en de hele euro's van mekaar halen dat maakt % berekeningen makkelijker
            int geldMunten = (int)geld; // Even de munten in een makellijke vorm die te verwerken met % is
            int geldCenten = (int)((geld - geldMunten) * 100); // Event de centen in een makellijke vorm die te verwerken met % is




            // munten berekening omzetten naar for loop
            int aantal2EuroMunten = geldMunten / 2;      
            int geldNa2Euro = geldMunten % 2;
            
            int aantal1EuroMunten = geldNa2Euro / 1;

            // centen berekening omzetten naar for loop
            int aantal50cent = geldCenten / 50;
            int geldNa50cent = geldCenten % 50;

            int aantal20cent = geldNa50cent / 20;
            int geldNa20cent = geldNa50cent % 20;

            int aantal10cent = geldNa20cent / 10;
            int geldNa10cent = geldNa20cent % 10;

            int aantal5cent = geldNa10cent / 5;
            int geldNa5cent = geldNa10cent % 5;

            int aantal2cent = geldNa5cent / 2;
            int geldNa2cent = geldNa5cent % 2;

            int aantal1cent = geldNa2cent;

            Console.WriteLine($"er zijn {geldCenten} centen te verdelen");
            Console.WriteLine($"{geld} is te verdelen in {aantal2EuroMunten} stukken van 2 euro");
            Console.WriteLine($"en {aantal1EuroMunten} stukken van 1 euro");
            Console.WriteLine($"en {aantal50cent} stukken van 50 cent");
            Console.WriteLine($"en {aantal20cent} stukken van 20 cent");
            Console.WriteLine($"en {aantal10cent} stukken van 10 cent");
            Console.WriteLine($"en {aantal5cent} stukken van 5 cent");
            Console.WriteLine($"en {aantal2cent} stukken van 2 cent");
            Console.WriteLine($"en {aantal1cent} stukken van 1 cent");
            Console.ReadKey();

        }
    }
}
