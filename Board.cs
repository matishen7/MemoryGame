namespace MemoryGame
{
    public class Board
    {
        private int n, m;
        public Cell[][] cells;
        public Board(int m, int n)
        {
            this.m = m;
            this.n = n;
            cells = new Cell[m][];
            for (int i = 0; i < m; i++)
            {
                cells[i] = new Cell[n];
                for (int j = 0; j < n; j++)
                    cells[i][j] = new Cell();
            }
        }

        public void Display()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(string.Format("{0}\t", cells[i][j].GetImage()));
                Console.WriteLine();
            }    
        }

    }

    public class Cell
    {
        private string Image { get; set; }
        public Cell()
        {
        }

        public string GetImage()
        {
            return this.Image;
        }

        public void SetImage(string image)
        {
            Image = image;
        }
    }
}
