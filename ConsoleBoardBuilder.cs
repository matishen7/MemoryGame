using MemoryGame;
using System;

internal class ConsoleBoardBuilder : IBoardBuilder
{
    private int m;
    private int n;
    private List<string> images = new List<string>() { };
    private List<int> imagesAssigned = new List<int>() { };
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
            imagesAssigned.Add(0);
        }
    }

    private void GetBoard()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var imageTitle = PickRandomElement(images, imagesAssigned);
                consoleBoard.cells[i][j].SetImage(imageTitle);
            }
        }
    }


    public Board Build()
    {
        GetBoard();
        return consoleBoard;
    }

    public T PickRandomElement<T>(List<T> list, List<int> times)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("The list must not be null or empty.");
        }

        int randomIndex = new Random().Next(0, list.Count - 1);
        var element = list[randomIndex];
        times[randomIndex]++;
        if (times[randomIndex] == 2)
        {
            list.RemoveAt(randomIndex);
            times.RemoveAt(randomIndex);
        };
        return element;
    }
}