using System;

// Define a delegate (signature of methods that can handle the event)
public delegate void MyEventHandler(string message);

// Define a class that will raise the event
public class Publisher
{
	// Declare the event using the delegate
	public event MyEventHandler Notify;

	// Method to raise the event
	public void RaiseEvent(string message)
	{
		// Check if there are any subscribers
		Notify?.Invoke(message);
	}
}

// Define a class that will handle the event
public class Subscriber
{
	// Event handler method that matches the delegate signature
	public void OnNotify(string message)
	{
		Console.WriteLine("Event received: " + message);
	}
}

class Program
{
	static void Main()
	{
		// Create instances of Publisher and Subscriber
		Publisher publisher = new Publisher();
		Subscriber subscriber = new Subscriber();

		// Subscribe to the event
		publisher.Notify += subscriber.OnNotify;

		// Raise the event
		publisher.RaiseEvent("Hello, World!");

		// Unsubscribe from the event (if needed)
		publisher.Notify -= subscriber.OnNotify;
	}
}
