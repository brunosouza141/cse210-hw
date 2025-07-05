using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> inputsList = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            inputsList.Add(input);
        }
        while (input != 0);

        Console.WriteLine("The sum is: " + inputsList.Sum());
        Console.WriteLine("The average is: " + inputsList.Average());
        Console.WriteLine("The largest number is: " + inputsList.Max());
    }
}