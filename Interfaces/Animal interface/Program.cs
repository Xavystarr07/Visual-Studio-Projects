using System;

// Define the IAnimal interface
public interface IAnimal
{
	// Property to store the animal's name
	string Name { get; set; }

	// Property to store the animal's age
	int Age { get; set; }

	// Method to simulate the animal eating
	void Eat();
}

// Define the abstract base class AnimalBase that implements the IAnimal interface
public abstract class AnimalBase : IAnimal
{
	// Implement the Name and Age properties from the IAnimal interface
	public string Name { get; set; }
	public int Age { get; set; }

	// Additional property to store the species of the animal
	public string Species { get; set; }

	// Constructor to initialize common properties (Name, Age, and Species)
	public AnimalBase(string name, int age, string species)
	{
		Name = name;
		Age = age;
		Species = species;
	}

	// Implement the Eat method from the IAnimal interface
	public void Eat()
	{
		Console.WriteLine($"{Name} is eating.");
	}

	// Abstract method to be implemented by derived classes for making sounds
	public abstract void MakeSound();
}

// Define the Lion class that inherits from AnimalBase
public class Lion : AnimalBase
{
	// Constructor for Lion that sets the name, age, and species
	public Lion(string name, int age)
		: base(name, age, "Panthera leo") // Set the species to "Panthera leo"
	{
	}

	// Implement the abstract method MakeSound to simulate the lion's roar
	public override void MakeSound()
	{
		Console.WriteLine($"{Name} (a lion) roars: Rooooar!");
	}
}

// Define the Elephant class that inherits from AnimalBase
public class Elephant : AnimalBase
{
	// Constructor for Elephant that sets the name, age, and species
	public Elephant(string name, int age)
		: base(name, age, "Loxodonta africana") // Set the species to "Loxodonta africana"
	{
	}

	// Implement the abstract method MakeSound to simulate the elephant's trumpet
	public override void MakeSound()
	{
		Console.WriteLine($"{Name} (an elephant) trumpets: Prrrrrrrrr!");
	}
}

// Main program to test the functionality of the animal classes
public class Program
{
	public static void Main(string[] args)
	{
		// Create an instance of Lion
		Lion lion = new Lion("Simba", 5);

		// Display the lion's information, make it eat and make a sound
		Console.WriteLine($"Animal: {lion.Name}, Age: {lion.Age}, Species: {lion.Species}");
		lion.Eat();
		lion.MakeSound();

		Console.WriteLine(); // Blank line for better readability

		// Create an instance of Elephant
		Elephant elephant = new Elephant("Dumbo", 10);

		// Display the elephant's information, make it eat and make a sound
		Console.WriteLine($"Animal: {elephant.Name}, Age: {elephant.Age}, Species: {elephant.Species}");
		elephant.Eat();
		elephant.MakeSound();
	}
}
