using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            double correctCount = 0;

            Console.Write("Guess which will have more: heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine();

            Console.Write("How many times shall we flip a coin? ");
            double numberOfFlips = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Random rando = new Random();
            for (int x = 1; x <= numberOfFlips; x++)
            {
                int flip = rando.Next(1, 3);
                if (flip == 1)
                {
                    Console.WriteLine($"heads");
                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount++;
                    }
                }
                else
                {
                    Console.WriteLine($"tails");
                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }
            }
            double percentageResult = correctCount / numberOfFlips * 100;
            Console.WriteLine();
            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} time(s).");
            Console.WriteLine($"That's {percentageResult}%");

        }
    }
}
