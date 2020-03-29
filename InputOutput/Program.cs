using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            // BMI calculator
            string gewichtInput;
            string lengteInput;
            double gewicht; // in kg
            double lengteCM;
            double lengteM;
            double bmi;

            Console.WriteLine("Hoeveel weeg je? (in kg) ");
            gewichtInput = Console.ReadLine();
            gewicht = Convert.ToDouble(gewichtInput);

            Console.WriteLine("Hoe lang ben je? (in cm)");
            lengteInput = Console.ReadLine();
            lengteCM = Convert.ToDouble(lengteInput);
            lengteM = lengteCM * 0.01;

            bmi = gewicht / (lengteM * lengteM);

            Console.WriteLine($"Je BMI is {bmi}");

        }
    }
}
