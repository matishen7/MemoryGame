﻿namespace MemoryGame
{
    public class Board : IBoard
    {
        private int n, m;
        public Cell[][] cells;
        public static int matchedCells = 0;
        public Board(int m, int n)
        {
            this.m = m;
            this.n = n;
            CellsBuild();
        }

        private void CellsBuild()
        {
            cells = new Cell[m][];
            for (int i = 0; i < m; i++)
            {
                cells[i] = new Cell[n];
                for (int j = 0; j < n; j++)
                    cells[i][j] = new Cell();
            }
        }

        public void RevealAllCards()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(string.Format("{0}\t", cells[i][j].GetImage()));
                Console.WriteLine();
            }
        }

        public void Display(int x, int y)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    if (cells[i][j].IsFound()) Console.Write("* \t");
                    else if (i == x && j == y) Console.Write(string.Format("{0}\t", cells[i][j].GetImage()));
                    else Console.Write(string.Format("? \t"));
                Console.WriteLine();
            }
        }

        public bool EndGame()
        {
            return (matchedCells == m * n); 
        }

        public bool CheckIfCardsMatch(int x, int y, int a, int b)
        {
            if (cells[x][y].GetImage().Equals(cells[a][b].GetImage()))
            {
                cells[x][y].SetAsFound();
                cells[a][b].SetAsFound();
                matchedCells += 2;
                return true;
            }
            return false;
        }

    }
}
