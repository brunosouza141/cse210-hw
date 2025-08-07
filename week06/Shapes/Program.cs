using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Blue", 2.0);
        shapes.Add(square);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Red", 3.0, 2.0);
        shapes.Add(rectangle);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Blue", 5.0);
        shapes.Add(circle);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        
    }
}