using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();
            board.ShowChessBoard();

            while (true)
            {
                board.Play();
            }
        }
    }
}

