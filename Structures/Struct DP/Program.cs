using System;

// Struct Point with properties X and Y
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Method to calculate distance between two points
    public double DistanceTo(Point other)
    {
        int deltaX = X - other.X;
        int deltaY = Y - other.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create two Point objects
        Point point1 = new Point { X = 3, Y = 4 };
        Point point2 = new Point { X = 6, Y = 8 };

        // Calculate and output distance between points
        double distance = point1.DistanceTo(point2);
        Console.WriteLine($"Distance between points: {distance}");
    }
}