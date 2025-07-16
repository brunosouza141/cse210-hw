using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3, 4);
        Fraction fraction3 = new Fraction(1, 3);
        Console.WriteLine(fraction.GetTop() + "/" + fraction.GetBottom());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction1.GetTop() + "/" + fraction1.GetBottom());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetTop() + "/" + fraction2.GetBottom());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetTop() + "/" + fraction3.GetBottom());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}