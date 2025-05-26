using System;
class Program
{
    static void Main(string[] args)
    {
        // User input for strings

        Console.WriteLine("Enter a word:");
        string userWord = Console.ReadLine();

        Console.WriteLine("You entered the word: " + userWord);
        // User input for two numbers
        // Use double for decimals

        int num1;
        while (true)
        {
            Console.WriteLine("Enter the first number:");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Number 1: " + num1);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid first number.");
            }
        }

        int num2;
        while (true)
        {
            Console.WriteLine("Enter the second number:");
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Number 2: " + num2);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid second number.");
            }
        }

        // Asks user to choose an arithmetic operation

        string operation;
        while (true)
        {
            Console.WriteLine("Choose an operation: +, -, *, /");
            operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter one of +, -, *, /.");
            }
        }

        // Performs arithmetic operation

        if (operation == "+")
        {
            Console.WriteLine("Addition: " + (num1 + num2));
        }
        else if (operation == "-")
        {
            Console.WriteLine("Subtraction: " + (num1 - num2));
        }
        else if (operation == "*")
        {
            Console.WriteLine("Multiplication: " + (num1 * num2));
        }
        else if (operation == "/")
        {
            while (num1 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero first number.");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    if (num1 != 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            while (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero second number.");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    if (num2 != 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            Console.WriteLine("Division: " + ((double)num1 / num2));
        }

        // Wait for user to press a key before exiting program
        Console.ReadKey();
    }
}
