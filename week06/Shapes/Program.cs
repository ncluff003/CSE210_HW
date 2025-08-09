using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Gold", 5.00));
        shapes.Add(new Rectangle("Green", 5.00, 6.00));
        shapes.Add(new Circle("Blue", 10.50));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea()}");
        }
    }
}
