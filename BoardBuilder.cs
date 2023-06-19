using MemoryGame;

internal class BoardBuilder : IBoardBuilder
{
    private int m;
    private int n;
    private List<string> images = new List<string>() { };

    public BoardBuilder(int m, int n)
    {
        this.m = m;
        this.n = n;
        GetImages();
    }

    private void GetImages()
    {
        for (int i = 0; i < (m * n)/2 ;i++)
        {
            var imageTitle = string.Format("image{0}", i);
            images.Add(imageTitle);
        }
    }
}