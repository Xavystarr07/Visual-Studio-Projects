using System;
class Program
{
	// Define a delegate for string manipulation 
	public delegate string StringManipulation(string input);

	// Method to convert string to uppercase 
	static string ToUpperCase(string input)
	{
		return input.ToUpper();
	}

	// Method to convert string to lowercase 
	static string ToLowerCase(string input)
	{
		return input.ToLower();
	}

	// Method to trim whitespace from string 
	static string TrimString(string input)
	{
		return input.Trim();
	}

	// Method to reverse the string 
	static string ReverseString(string input)
	{
		char[] charArray = input.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}

	static void Main(string[] args)
	{
		// Get input string from the user 
		Console.WriteLine("Enter a string:");
		string userInput = Console.ReadLine();

		// Ask the user to choose a manipulation operation 
		Console.WriteLine("Choose an operation: \n1. Uppercase \n2. Lowercase \n3. Trim \n4.Reverse"); 

		int choice = Convert.ToInt32(Console.ReadLine());

		// Declare a delegate variable 
		StringManipulation manipulate = null;

		// Assign the appropriate method to the delegate based on the user's choice 
		switch (choice)
		{
			case 1:
				manipulate = ToUpperCase;
				break;
			case 2:
				manipulate = ToLowerCase;
				break;
			case 3:
				manipulate = TrimString;
				break;
			case 4:
				manipulate = ReverseString;
				break;
			default:
				Console.WriteLine("Invalid choice.");
				return;
		}

		// Perform the chosen string manipulation using the delegate 
		string result = manipulate(userInput);
		Console.WriteLine($"Result: {result}");
	}
}