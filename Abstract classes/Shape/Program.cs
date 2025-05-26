using System;

// Define an abstract class for shapes
public abstract class Shape
{
	// Abstract methods to be implemented by derived classes
	public abstract double CalculateArea();
	public abstract double CalculatePerimeter();

	// Regular method to get shape details
	public void GetShapeDetails()
	{
		Console.WriteLine($"Area: {CalculateArea()}");
		Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
	}
}

// Define a derived class for Rectangle
public class Rectangle : Shape
{
	public double Width { get; set; }
	public double Height { get; set; }

	// Provide implementation for CalculateArea
	public override double CalculateArea()
	{
		return Width * Height;
	}

	// Provide implementation for CalculatePerimeter
	public override double CalculatePerimeter()
	{
		return 2 * (Width + Height);
	}
}

// Define a derived class for Circle
public class Circle : Shape
{
	public double Radius { get; set; }

	// Provide implementation for CalculateArea
	public override double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}

	// Provide implementation for CalculatePerimeter
	public override double CalculatePerimeter()
	{
		return 2 * Math.PI * Radius;
	}
}

class Program
{
	static void Main()
	{
		// Create instances of derived classes
		Shape myRectangle = new Rectangle { Width = 4, Height = 5 };
		Shape myCircle = new Circle { Radius = 3 };

		// Get details for the Rectangle
		Console.WriteLine("Rectangle Details:");
		myRectangle.GetShapeDetails(); // Output: Area: 20, Perimeter: 18

		// Get details for the Circle
		Console.WriteLine("\nCircle Details:");
		myCircle.GetShapeDetails(); // Output: Area: 28.27..., Perimeter: 18.85...
	}
}
