using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);

        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string userName, int SquareNumber)
        {
            Console.WriteLine($"Brother {userName}, the square of your number is {SquareNumber}");
        }
        Main();
    }
}