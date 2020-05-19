using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an coordX coordY grid with randomly values of O(dead) or 1(alive) 
            // something like an array of coord(int x, int y, int "state") for each coordinate?
            // possibly with a setting for the ratios of 0s to 1s


            //frame loop start
            //show the grid for a set amount of time
            // where a string "[ ]" for 0 and a string "[*]" for 1. -> Maybe look for better suited characters if it looks ugly.

            //for loop start
            //for each coord(x,y) check if the 8 adjacent coords are 1 or 0 and count them

            //Make cases:
            //if one 1 is found: turn into a 0
            //if two to three 1s are found, no change <- possible issue see ** below
            //if four or more 1s are found turn into 0
            //if the cell is 0 and has three 1s found, turn into 1 <- possible issue see ** above

            //for loop end
            
            //frame loop end if keypressed.

            //Stretch goal: make the grid loop on itself

        }
    }
}
