using MemoryGame;

internal class ConsoleBoardBuilder : IBoardBuilder
{
    private int m;
    private int n;
    private List<string> images = new List<string>() { };
    protected Board consoleBoard;

    public ConsoleBoardBuilder(int m, int n)
    {
        this.m = m;
        this.n = n;
        GetImages();
        consoleBoard = new Board(m, n);
    }

    private void GetImages()
    {
        for (int i = 0; i < (m * n) / 2; i++)
        {
            var imageTitle = string.Format("image{0}", i);
            images.Add(imageTitle);
        }
    }

    public Board Build()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var index = new Random().Next(0, (m * n) / 2);
                consoleBoard.cells[i][j].SetImage(images[index]);
            }
        }
        return consoleBoard;
    }
}