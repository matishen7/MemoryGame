using MemoryGame;

public class Program
{
    public static void Main(string[] args)
    {

        string? restart = "Y";
        while (restart.Equals("Y"))
        {
            Console.Clear();
            Console.WriteLine("Enter M(height):");
            string input1 = Console.ReadLine();
            int m = int.Parse(input1);

            Console.WriteLine("Enter N(width):");
            string input2 = Console.ReadLine();
            int n = int.Parse(input2);
            var board = new ConsoleBoardBuilder()
                .WithDimensions(m, n)
                .Build();
            //board.RevealAllCards();
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
            Console.WriteLine("Congratulations! You won! Do you want to restart the game? Y/N?");
            restart = Console.ReadLine();
        }
    }

    private static (int x, int y) GetCardCoordinates(int m, int n)
    {
        Console.WriteLine("Enter the X and Y values separated by a space:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int x = 0, y = 0;
        while (parts.Length != 2 || !int.TryParse(parts[0], out x) || !int.TryParse(parts[1], out y) || x >= m || y >= n)
        {
            Console.WriteLine("Enter the X and Y values separated by a space:");
            input = Console.ReadLine();
            parts = input.Split(' ');
        }

        return (x, y);
    }
}