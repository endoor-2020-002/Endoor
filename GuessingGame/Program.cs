using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{ 
    class Program
    {
        static void Main(string[] args)
        {

            //generate random number
            Random rand = new Random();
            int answer = rand.Next(1, 101);

            // greet the user and ask to make a guess
            Init();
            Play(answer);
            Console.ReadKey();


        }

        private static void Init()
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Guess a number between 1 and 100!");
        }

        //Accepts user guesses untill the guess matches the answer.
        private static void Play(int answer)
        {
            bool won = false;
            int guess;

            do
            {
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == answer)
                    {
                        Console.WriteLine("Yes that is the correct number");
                        won = true;
                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine("No, lower!");
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("No, higher!");
                    }
                }
            } while (won != true);
            
        }
    }
}
