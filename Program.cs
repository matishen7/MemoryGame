using MemoryGame;

public class Program
{
    public static void Main(string[] args)
    {
        
        string? restart = "Y";
        while (restart.Equals("Y"))
        {
            Console.Clear();
            Console.WriteLine("Enter M(width):");
            string input1 = Console.ReadLine();
            int m = int.Parse(input1);

            Console.WriteLine("Enter N(height):");
            string input2 = Console.ReadLine();
            int n = int.Parse(input2);
            var board = new ConsoleBoardBuilder()
                .WithDimensions(m, n)
                .Build();

            while (!board.AllCardsFound())
            {
                board.Display();
                var firstCard = GetCardCoordinates(m, n);
                board.Display(firstCard.x, firstCard.y);
                var secondCard = GetCardCoordinates(m, n);
                Console.Clear();
                board.Display(firstCard.x, firstCard.y, secondCard.x, secondCard.y);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
            board.RevealAllCards();
            Console.WriteLine("Do you want to restart the game? Y/N?");
            restart = Console.ReadLine();
        }
    }

    private static (int x, int y) GetCardCoordinates(int m, int n)
    {
        Console.WriteLine("Enter x to reveal the card:");
        var input1 = Console.ReadLine();
        int x = int.Parse(input1);
        while (x >= m)
        {
            Console.WriteLine("Enter x to reveal the card:");
            input1 = Console.ReadLine();
            x = int.Parse(input1);
        }

        Console.WriteLine("Enter y to reveal the card:");
        var input2 = Console.ReadLine();
        int y = int.Parse(input2);

        while (y >= n)
        {
            Console.WriteLine("Enter y to reveal the card:");
            input2 = Console.ReadLine();
            y = int.Parse(input2);
        }

        return (x, y);
    }
}