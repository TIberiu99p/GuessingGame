using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 99;
            Random random = new Random();
            int randomNumber = random.Next(min, max + 1);
            Console.WriteLine(randomNumber);
            int numberOfTries = 5;
            while (numberOfTries > 0)
            {
                Console.WriteLine("Enter a guess: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int guessNumUser))
                {
                    if (guessNumUser == randomNumber)
                    {
                        Console.WriteLine("You guessed the number!");
                        Console.WriteLine($"The correct number was {randomNumber}");
                        break;
                    }
                    else if (guessNumUser < randomNumber)
                    {
                        Console.WriteLine($"The guess is HIGHER than the correct number");
                        numberOfTries -= 1;
                        Console.WriteLine($"You have {numberOfTries} left");
                    }
                    else
                    {
                        Console.WriteLine($"The guess is LOWER than the correct number");
                        numberOfTries -= 1;
                        Console.WriteLine($"You have {numberOfTries} left");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }
    }
}
