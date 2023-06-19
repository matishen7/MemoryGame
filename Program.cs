public class Program
{
    public static void Main(string[] args)
    {
        var board = new BoardBuilder(3, 2);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}