public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");

        // Read input from the user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        int m = Console.Read();
        int n = Console.Read();

        var board = new BoardBuilder(m, n);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}