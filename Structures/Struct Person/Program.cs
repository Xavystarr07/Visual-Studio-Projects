using System;

struct Person
{
    // Variables
    public string Name;
    public string Race;
    public int IdNumber;
    public string Gender;

    // Method to print a Person
    public void PrintPerson()
    {
        Console.WriteLine($"Name: {Name}, Race: {Race}, ID Number: {IdNumber}, Gender: {Gender}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creates a Person object and print its details
        Person person = new Person
        {
            Name = "Xavier Chetty",
            Race = "Human",
            IdNumber = 123456,
            Gender = "Male"
        };
        person.PrintPerson();
    }
}
