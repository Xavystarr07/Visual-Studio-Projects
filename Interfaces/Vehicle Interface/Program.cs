using System;

// Define the IVehicle interface
interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}

// Implement the Car class
class Car : IVehicle
{
    private int gasoline;

    // Constructor to initialize the car's gasoline amount
    public Car(int initialGasoline)
    {
        gasoline = initialGasoline;
    }

    // Implement the Drive method
    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("The car is driving.");
        }
        else
        {
            Console.WriteLine("The car has no gasoline to drive.");
        }
    }

    // Implement the Refuel method
    public bool Refuel(int amount)
    {
        gasoline += amount;
        Console.WriteLine($"Refueled {amount} units of gasoline. Current gasoline level: {gasoline}");
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Car object with 0 gasoline
        Car car = new Car(0);

        // Ask the user for the amount of gasoline to refuel
        Console.Write("Enter the amount of gasoline to refuel: ");
        int refuelAmount = int.Parse(Console.ReadLine());

        // Refuel the car
        car.Refuel(refuelAmount);

        // Execute the Drive method of the car
        car.Drive();
    }
}
