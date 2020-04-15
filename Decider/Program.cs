﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decider
{
    class Program
    {
        static void Main(string[] args)
        {
            // Give a random answer to a question
            Random diceRoll = new Random();


            START:
            int rollD6 = diceRoll.Next(1, 7); //in role playing games and boardgames "D6" stands for "six sided dice". 

            Console.WriteLine("> Do you want to go and do the thing?");
            Console.ReadLine();
            
            switch (rollD6) 
            {
                case 1:
                    Console.WriteLine("> I wouldn't even think of even trying... but you're doing it already aren't you?");
                    break;
                case 2:
                    Console.WriteLine("> We would advise against that.");
                    break;
                case 3:
                    Console.WriteLine("> ... eeeeeh. It mighta be a yes, it mighta be a noe.");
                    break;
                case 4:
                    Console.WriteLine("> Things are looking good.");
                    break;
                case 5:
                    Console.WriteLine("> Today is your lucky day: go for it!");
                    break;
                case 6:
                    Console.WriteLine("> What are you waiting for?! GOGOGOGOGO!");
                    break;
                default:
                    Console.WriteLine("> Somehow the dice are stuck!"); // this never happens on a table in reality either.
                    break;
            }

            Console.ReadKey();
            Console.WriteLine("");
            goto START;
        }
    }
}
