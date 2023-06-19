public class Program
{
    public static void Main(string[] args)
    {
        var board = new ConsoleBoardBuilder(3, 4)
            .Build();

        board.Display();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}