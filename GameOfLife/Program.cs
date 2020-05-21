using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an coordX coordY grid with randomly values of O(dead) or 1(alive) 
            int verticalResolution = 40;
            int horizontalResolution = 20;
            int[,] coordinates = new int[horizontalResolution + 1, verticalResolution +1] ; //x y array for the world
            int whileLoopInitator = 0;
            int animationFrames = 100; // total amount of frames the simulation runs
            int frameSpeed = 10000; //length of the simulation in frames of x milliseconds, depending on your CPU speed. I used Thread.Sleep(x)
            Random lifeOrDeath = new Random(); // used to generate a world of cells
            int counterLifeProximity = 0; 


            // create an coordX coordY grid with randomly values of O(dead) or 1(alive) 
            

            // build startergrid and fill randomly
            for (int x = 0;  x < horizontalResolution; x++) 
            {

                for (int y = 0; y < verticalResolution; y++)
                {
                    coordinates[x, y] = lifeOrDeath.Next(2); // or set all to 0; to test the glider
                }
                
            }

            //test forms 


            // block
            
            coordinates[2, 2] = 1;
            coordinates[2, 3] = 1;
            coordinates[3, 2] = 1;
            coordinates[3, 3] = 1;

            // block 
            coordinates[17, 12] = 1;
            coordinates[17, 13] = 1;
            coordinates[18, 12] = 1;
            coordinates[18, 13] = 1;


            //glider // only shows 3 live cells at first frame ?!
            coordinates[8, 13] = 1;
            coordinates[9, 14] = 1;
            coordinates[10, 12] = 1;
            coordinates[10, 13] = 1;
            coordinates[10, 14] = 1;
            

            //frame loop start
            while (whileLoopInitator < animationFrames)
            {
                // issue: the borders cannot be evaluated as that would give values outside the coordinates[x,y] array.
                for (int x = 1; x < horizontalResolution; x++)
                {

                    for (int y = 1; y < verticalResolution; y++)
                    {
                        // reset the life counter
                        counterLifeProximity = 0;

                        //check if it's a live cell, if it is live, start creating or terminating lives
                        if (coordinates[x, y] == 1)
                        {
                            // start counting life around you.
                            if (coordinates[x - 1, y] == 1) // life to the left
                                counterLifeProximity++;
                            if (coordinates[x + 1, y] == 1) //life to the right
                                counterLifeProximity++;
                            if (coordinates[x - 1, y - 1] == 1) // life above left
                                counterLifeProximity++;
                            if (coordinates[x, y - 1] == 1) // life above 
                                counterLifeProximity++;
                            if (coordinates[x + 1, y - 1] == 1) // life above right
                                counterLifeProximity++;
                            if (coordinates[x - 1, y + 1] == 1) // life below left
                                counterLifeProximity++;
                            if (coordinates[x, y + 1] == 1) // life below
                                counterLifeProximity++;
                            if (coordinates[x + 1, y + 1] == 1) // life below right
                                counterLifeProximity++;

                            // change state of life depending on life in proximity
                            switch (counterLifeProximity)
                            {
                                // Any live cell with fewer than two live neighbours dies, as if by underpopulation
                                case 0:
                                case 1:
                                case 2:
                                    coordinates[x, y] = 0;
                                    break;

                                //Any live cell with two or three live neighbours lives on to the next generation. <- no code needed

                                // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                                case 3:
                                    coordinates[x, y] = 1;
                                    break;

                                // Any live cell with more than three live neighbours dies, as if by overpopulation.
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                    coordinates[x, y] = 0;
                                    break;
                            }
                        }
                        // write the current cell
                        Console.Write($"{coordinates[x, y]}");
                    }
                    // newline at the end of each horizontal line of cells
                    Console.Write("\n");                  
                }
                whileLoopInitator++; // next frame <- needs clearer comment...
                Thread.Sleep(frameSpeed);
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
