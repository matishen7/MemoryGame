using MemoryGame;
using System;

public class ConsoleBoardBuilder : IBoardBuilder
{
    private int m;
    private int n;
    private List<string> images = new List<string>() { };
    protected Board consoleBoard;

    public ConsoleBoardBuilder()
    {
    }

    private void InitializeImages()
    {
        for (int i = 0; i < (m * n) / 2; i++)
        {
            var imageTitle = string.Format("image{0}", i);
            images.Add(imageTitle);
            images.Add(imageTitle);
        }
    }

    private void SetImages()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var imageTitle = PickRandomImage(images);
                consoleBoard.cells[i][j].SetImage(imageTitle);
            }
        }
    }

    public IBoardBuilder WithDimensions(int m, int n)
    {
        this.m = m;
        this.n = n;
        InitializeImages();
        consoleBoard = new Board(m, n);
        return this;
    }

    public Board Build()
    {
        SetImages();
        return consoleBoard;
    }

    private T PickRandomImage<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("The list must not be null or empty.");
        }

        int randomIndex = new Random().Next(0, list.Count - 1);
        var element = list[randomIndex];
        list.RemoveAt(randomIndex);
        return element;
    }
}