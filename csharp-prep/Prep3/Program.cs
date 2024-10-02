using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);

        int guess;
        int count = 0;

        do
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());
            count ++;
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {count} tries!");

                
            }


        }while (guess != magicNumber);

    }
}