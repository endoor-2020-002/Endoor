using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunday
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Sunday!");
                else if (i % 3 == 0)
                    Console.WriteLine("Sun!");
                else if (i % 5 == 0)
                    Console.WriteLine("Day!");
                else
                    Console.WriteLine($"{i}");
            }
            Console.ReadKey();
        }
    }
}
