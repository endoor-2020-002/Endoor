using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            //greeting();
            //travelTimeBudget();
            //timeDifference();
            areaUnitConversion();
            Console.ReadKey();
        }

        public static void greeting()
        {
            string fullName;
            string travelDestination;
            Console.WriteLine("Welcome to trip planner!");
            Console.WriteLine("What is your full name?");
            fullName = Console.ReadLine();
            Console.WriteLine($"Hello, {fullName}!");
            Console.WriteLine("What is your travel destination?");
            travelDestination = Console.ReadLine();
            Console.WriteLine($"{travelDestination} sounds great this time of year!");
        
        }
        public static void travelTimeBudget()
        {
            int tripLength;
            decimal tripBudgetEUR;
            string tripBudgetCurrency;
            decimal tripBudgetCurrencyToEuro;



           
            Console.WriteLine("How many days is your trip?");
            while(!Int32.TryParse(Console.ReadLine(), out tripLength))
            {
                Console.WriteLine(">That was not a number try again");
            }
            
            Console.WriteLine("How much are you going to spend, in EUR, on the trip?");
            while (!Decimal.TryParse(Console.ReadLine(), out tripBudgetEUR))
            {
                Console.WriteLine(">That was not a number try again");
            }


            Console.WriteLine("What is the three-letter currency symbol for your destination?");
            tripBudgetCurrency = Console.ReadLine();

            Console.WriteLine($"How many {tripBudgetCurrency} are there in 1 euro?");
            while (!Decimal.TryParse(Console.ReadLine(), out tripBudgetCurrencyToEuro))
            {
                Console.WriteLine(">That was not a number try again");
            }


            Console.WriteLine($"If you are traveling for {tripLength} days that is the same as {tripLength * 24} hours or {tripLength * 24 * 60} minutes");

            Console.WriteLine($"If you are going to spend {tripBudgetEUR.ToString("C")} Euro that means daily you can spend up to {(tripBudgetEUR / tripLength).ToString("C")} in Euros");

            Console.WriteLine($"Your total budget in {tripBudgetCurrency} is {(tripBudgetEUR * tripBudgetCurrencyToEuro).ToString("C")} which per day is {(tripBudgetEUR * tripBudgetCurrencyToEuro / tripLength).ToString("C")}.");

        }

        public static void timeDifference()
        {
            /*
            double timeDifference;
            double timeDifferenceAtNoon;
            
            Console.WriteLine("What is the time difference in hours, between your home and your destination?");
            while (!Double.TryParse(Console.ReadLine(), out timeDifference))
            {
                Console.WriteLine("Please enter the value in numbers");
            }

            // check if the time difference doesn't loop around a day
            
            if (timeDifference % 12)
            {
                timeDifferenceAtNoon = timeDifference % 12;
            }
            else
            {
                timeDifferenceAtNoon = 12 + timeDifference % 12;
            }
           
            
           
            Console.WriteLine($"That means that when it is midnight at home it will me {timeDifference} in your travel destination and when it is noon at home it will be {timeDifferenceAtNoon}");
            */
        }

        public static void areaUnitConversion()
        {
            decimal destinationArea;
            decimal beep;
            string destinationAreaInMiles;

            Console.WriteLine("What is the area of your destination country/region in square kilometers?");
            while (!Decimal.TryParse(Console.ReadLine(), out destinationArea))
            {
                Console.WriteLine("Please enter the value in numbers");
            }
            
            beep = (destinationArea * (decimal)(0,621371));

            destinationAreaInMiles = String.Format("{0, n2}", beep);

            Console.WriteLine($"In miles that is {destinationAreaInMiles}");
        }

    }
}
