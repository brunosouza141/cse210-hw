using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0;
        int guessNumber = 0;
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guessNumber != magicNumber);
        
    }
}