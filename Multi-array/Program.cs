using System;

class Array
{
    static void Main(string[] args)
    {
        // Defines the array for the supermarket
        string[,] inventory = new string[4, 4]
        {

            { "Item ID: 1", "Item Name: Orange", "Quantity available: 10", "Price per unit: 3" },
            { "Item ID: 2", "Item Name: Apple", "Quantity available: 20", "Price per unit: 6" },
            { "Item ID: 3", "Item Name:  Banana", "Quantity available: 30", "Price per unit: 9" },
            { "Item ID: 4", "Item Name: Juice", "Quantity available: 40", "Price per unit: 12" },
        };

        // Print the supermarket inventory
        Console.WriteLine("Supermarket inventory:");
        PrintArray(inventory);

        // Adding to the inventory to inventory
        Console.WriteLine("Item ID: 5", "Item Name: CoolDrink", "Quantity available: 50", "Price per unit: 20");
        PrintArray(inventory);

        // Removing item from inventory
        inventory[1, 2] = "Item Name: Null";
        PrintArray(inventory);

        // Updating the quantity 
        inventory[0, 2] = "Quantity available: 9 ";

        // Print the array after updating the quantity
        Console.WriteLine("Supermarket inventory after quantity update:");
        PrintArray(inventory);

        // Updating the price 
        inventory[0, 3] = "Price per unit: 4";

        // Print the array after updating the price
        Console.WriteLine("Supermarket inventory after price update:");
        PrintArray(inventory);

    }
                         
    // Method to print the array
    static void PrintArray(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();   
    }
}
                           