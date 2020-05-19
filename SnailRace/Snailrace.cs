using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int tracklength = 330;
          
            var snailOne = new Snail(3, 4);
            var snailTwo = new Snail(2, 6);

            /*
            while (positionSnailOne < tracklength && positionSnailTwo < tracklength)
            {
                movedSnailOne = move.positionSnailOne();
                Console.WriteLine($"Snail One moved by {movedSnailOne} is now at {positionSnailOne}");
                movedSnai5lTwo = move.positionSnailTwo();
                Console.WriteLine($"Snail Two moved by {movedSnailTwo} is now at {positionSnailTwo}");
            }

            if (positionSnailOne > tracklength)
            {
                Console.WriteLine("Snail One won!");
            }
            else if (positionSnailTwo > tracklength)
            {
                Console.WriteLine("Snail Two won!");
            }
            */


        }
    }
}
