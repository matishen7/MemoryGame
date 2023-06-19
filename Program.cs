public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter M(width):");
        string input1 = Console.ReadLine();
        int m = int.Parse(input1);

        Console.WriteLine("Enter N(height):");
        string input2 = Console.ReadLine();
        int n = int.Parse(input2);
        var board = new ConsoleBoardBuilder(m, n)
            .Build();

        while (true)
        {
            board.Display();
            Console.WriteLine("Enter x to reveal the card:");
            input1 = Console.ReadLine();
            int x = int.Parse(input1);

            Console.WriteLine("Enter y to reveal the card:");
            input2 = Console.ReadLine();
            int y = int.Parse(input2);

            board.Display(x, y);
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}