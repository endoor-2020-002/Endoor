using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an coordX coordY grid with randomly values of O(dead) or 1(alive).
            int verticalResolution = 60;
            int horizontalResolution = 30;

            //x y array for the world.
            int[,] coordinates = new int[horizontalResolution + 1, verticalResolution +1];
            
            // temporary array that functions as framebuffer
            int[,] nextFrameCoordinates = new int[horizontalResolution + 1, verticalResolution + 1];

            int whileLoopInitator = 0;

            // total amount of frames the simulation runs.
            int animationFrames = 100;

            //length of the simulation in frames of x milliseconds, depending on your CPU speed. I used Thread.Sleep(x).
            int frameSpeed = 4000;

            // used to generate a random world of cells.
            Random lifeOrDeath = new Random(); 

            // used to evaluate if a cell should live or die.
            int counterLifeProximity = 0; 


            // create an coordX coordY grid with randomly values of O(dead) or 1(alive).
            

            // build startergrid and fill randomly.
            for (int x = 0;  x < horizontalResolution; x++) 
            {

                for (int y = 0; y < verticalResolution; y++)
                {
                    coordinates[x, y] = 0; // lifeOrDeath.Next(2); // or set all to 0; to test the glider.
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

            //glider // is not working and I have no idea why.
            coordinates[8, 13] = 1;
            coordinates[9, 14] = 1;
            coordinates[10, 12] = 1;
            coordinates[10, 13] = 1;
            coordinates[10, 14] = 1;
            

            //frame loop start
            while (whileLoopInitator < animationFrames)
            {
                //show the current frame
                for (int x = 1; x < horizontalResolution; x++)
                {

                    for (int y = 1; y < verticalResolution; y++)
                    {
                        Console.Write($"{coordinates[x, y]}");
                    }
                    //next line on screen
                    Console.Write("\n");
                }
                // wait a bit and clear the console
                Thread.Sleep(frameSpeed);
                Console.Clear();

                // calculate status of cell and change it when needed.
                // issue: the borders cannot be evaluated as that would give values outside the coordinates[x,y] array.
                for (int x = 1; x < horizontalResolution; x++)
                {

                    for (int y = 1; y < verticalResolution; y++)
                    {
                        // reset the life counter
                        counterLifeProximity = 0;

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

                        // change state of life depending on life in proximity.
                        switch (counterLifeProximity)
                        {
                            // Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                            case 0:
                            case 1:
                                nextFrameCoordinates[x, y] = 0;
                                break;

                            // Any live cell with two or three live neighbours lives on to the next generation.
                            case 2:
                                if (coordinates[x, y] == 1)
                                {
                                    nextFrameCoordinates[x, y] = 1;
                                    break;
                                }
                                else
                                { 
                                    nextFrameCoordinates[x, y] = 0;
                                    break;
                                }
                            // Any live cell with two or three live neighbours lives on to the next generation.
                            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                            case 3:
                                nextFrameCoordinates[x, y] = 1;
                                break;

                            // Any live cell with more than three live neighbours dies, as if by overpopulation.
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                nextFrameCoordinates[x, y] = 0;
                                break;
                        }
                        
                    }                                 
                }
                whileLoopInitator++; // next frame counter <- might need clearer comment...

                // write the current modified cell array frame buffer back to the array to be modified
                coordinates = nextFrameCoordinates;
                
            }
            Console.ReadKey();
        }
    }
}
