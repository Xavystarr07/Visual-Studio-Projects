using System;
class Program
{
	// Define a delegate for the calculator operations 
	public delegate double CalculatorDelegate(double a, double b);

	// Methods for calculator operations 
	static double Add(double a, double b)
	{
		return a + b;
	}

	static double Subtract(double a, double b)
	{
		return a - b;
	}

	static double Multiply(double a, double b)
	{
		return a * b;
	}

	static double Divide(double a, double b)
	{
		if (b != 0)
			return a / b;
		else
		{
			Console.WriteLine("Cannot divide by zero!");
			return 0;
		}
	}

	static void Main(string[] args)
	{
		// Take input from the user 
		Console.WriteLine("Enter the first number:");
		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter the second number:");
		double num2 = Convert.ToDouble(Console.ReadLine());

		// Ask the user to choose an operation 
		Console.WriteLine("Choose an operation: +, -, *, /");
		string operation = Console.ReadLine();

		// Declare a delegate variable 
		CalculatorDelegate calc = null;

		// Assign the appropriate method to the delegate based on user input 
		switch (operation)
		{
			case "+":
				calc = Add;
				break;
			case "-":
				calc = Subtract;
				break;
			case "*":
				calc = Multiply;
				break;
			case "/":
				calc = Divide;
				break;
			default:
				Console.WriteLine("Invalid operation.");
				return;
		}

		// Perform the calculation using the delegate 
		double result = calc(num1, num2);
		Console.WriteLine($"Result: {result}");
	}
}