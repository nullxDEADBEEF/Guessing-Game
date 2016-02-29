using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a guessing game you will have to guess a number between 1 and 10 and you will have 5 tries to get the correct answer!\n\n");

            Random random = new Random();
            int guessesTaken = 0;
            int randomNumber = random.Next(1, 10);

            while (guessesTaken < 5)
            {
                Console.WriteLine("try to guess the correct number!: ");
                string guess = Console.ReadLine();
                int guessInt;
                try
                {
                    guessInt = int.Parse(guess);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad input.");
                    continue;
                }

                guessesTaken++;
                if (guessInt < randomNumber)
                {
                    Console.WriteLine("The number is too low!");
                }
                if (guessInt > randomNumber)
                {
                    Console.WriteLine("The number is too high!");
                }
                if (guessInt == randomNumber)
                {
                    Console.WriteLine("Congratulation you guessed the correct number!");
                }
            }
        }
        }
    }
