namespace MemoryGame
{
    public class Board
    {
        Cell[][] cells = new Cell[][] {};
        public Board()
        {
        }

    }

    public class Cell
    {
        public string Image { get; set; }
        public Cell(string image)
        {
            this.Image = image;
        }

        public string GetImage()
        {
            return this.Image;
        }
    }
}
