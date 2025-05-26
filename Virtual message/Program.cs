// Base class Message
class Message
{
    // Virtual method Send
    public virtual void Send()
    {
        Console.WriteLine("Sending a message...");
    }
}

// Derived class Email inheriting from Message
class Email : Message
{
    // Override the Send method
    public override void Send()
    {
        Console.WriteLine("Sending an email...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Email
        Email email = new Email();

        // Call the Send method
        email.Send(); // Output: Sending an email...
    }
}