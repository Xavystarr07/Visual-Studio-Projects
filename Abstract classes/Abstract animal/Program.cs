using System;

// Define an abstract class with properties and abstract methods
public abstract class Animal
{
	// Properties
	public string Name { get; set; }
	public int Age { get; set; }
	public string Gender { get; set; } // Added Gender property

	// Abstract method (does not have a body)
	public abstract void MakeSound();

	// Abstract method to get details
	public abstract void GetDetails();
}

// Define a derived class
public class Dog : Animal
{
	// Provide implementation for the abstract method
	public override void MakeSound()
	{
		Console.WriteLine("Woof!");
	}

	// Provide implementation for GetDetails
	public override void GetDetails()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Type: Dog");
	}
}

// Define another derived class
public class Cat : Animal
{
	// Provide implementation for the abstract method
	public override void MakeSound()
	{
		Console.WriteLine("Meow!");
	}

	// Provide implementation for GetDetails
	public override void GetDetails()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Type: Cat");
	}
}

class Program
{
	static void Main()
	{
		// Create instances of derived classes
		Animal myDog = new Dog { Name = "Rex", Age = 5, Gender = "Male" };
		Animal myCat = new Cat { Name = "Whiskers", Age = 3, Gender = "Female" };

		// Call the implemented methods
		myDog.MakeSound(); // Output: Woof!
		myDog.GetDetails(); // Output: Name: Rex, Age: 5, Gender: Male, Type: Dog

		myCat.MakeSound(); // Output: Meow!
		myCat.GetDetails(); // Output: Name: Whiskers, Age: 3, Gender: Female, Type: Cat
	}
}
