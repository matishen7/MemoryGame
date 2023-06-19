public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");

        // Read input from the user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        // Perform other console operations
        // ...

        // Wait for user input before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}