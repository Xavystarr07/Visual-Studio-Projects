using System;

// Define the interface
public interface IShape
{
    double GetArea();
    double GetPerimeter();
}

// Implement the interface in a class for Circle
public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Implement the interface in a class for Rectangle
public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }

    public double GetPerimeter()
    {
        return 2 * (width + height);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose a shape to calculate the area and perimeter:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the radius of the circle:");
                double radius = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine($"Area: {circle.GetArea()}");
                Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");
                break;

            case 2:
                Console.WriteLine("Enter the width of the rectangle:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the rectangle:");
                double height = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine($"Area: {rectangle.GetArea()}");
                Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
                break;
        }
    }
}
