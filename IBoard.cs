﻿namespace MemoryGame
{
    public interface IBoard
    {
        bool EndGame();
        bool CheckIfCardsMatch(int x, int y, int a, int b);
        void Display(int x, int y);
        void RevealAllCards();
    }
}