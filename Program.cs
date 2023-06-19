public class Program
{
    public static void Main(string[] args)
    {
        var board = new ConsoleBoardBuilder(10, 10)
            .Build();

        board.Display();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}