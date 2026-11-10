using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);

        Rectangle rectangle = new Rectangle("purple", 2, 4);

        Circle circle = new Circle("green", 3);

        Console.WriteLine("Shape Information:");
        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape} ({shape.GetColor()}) - Area: {Math.Round(shape.GetArea(), 3)}");
        }
        
    }
}