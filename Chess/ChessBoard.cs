using System;
namespace Chess
{
    public class ChessBoard
    {
        private const int size = 8;
        public string[,] board = new string[size, size];
        private string horizontalSymbol = "+---";
        private string verticalSymbol = "|";
        private char[] lettersArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        King king1 = new King(0, 4, "white");
        King king2 = new King(7, 4, "black");
        Rook rook1 = new Rook(0, 0, "white");
        Rook rook2 = new Rook(0, 7, "white");
        Queen queen = new Queen(0, 3, "white");

        public ChessBoard()
        {
            CleanChessBoard();
            Update(king1, king2, rook1, rook2, queen);
            PrintBoard();
        }
        public void CleanChessBoard()
        {
            board = new string[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board[i, j] = "*";
                    }
                    else
                    {
                        board[i, j] = "#";
                    }
                }
            }
        }
        public void ShowChessBoard()
        {
            board = Update(king1, king2, rook1, rook2, queen); //set main pieces

            PrintBoard();
        }

        private void PrintBoard()
        {
            //writing letters in the top of board
            Console.Write("    ");
            for (int l = 0; l < size; l++)
            {
                Console.Write(lettersArray[l] + "   ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write("  ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(horizontalSymbol);
                }
                Console.Write("+\n");

                Console.Write(size - i + " ");
                for (int k = 0; k < size; k++)
                {
                    Console.Write($"{verticalSymbol} { board[i, k]} ");
                }
                Console.Write("|\n");
            }
            //the bottom part of board
            Console.Write("  ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(horizontalSymbol);
            }
            Console.Write("+\n");
        }

        public string[,] Update(King k1, King k2, Rook r1, Rook r2, Queen q)
        {
            CleanChessBoard();

            board[k1.Xpos, k1.Ypos] = k1.Symbol.ToString();
            board[k2.Xpos, k2.Ypos] = k2.Symbol.ToString();
            board[r1.Xpos, r1.Ypos] = r1.Symbol.ToString();
            board[r2.Xpos, r2.Ypos] = r2.Symbol.ToString();
            board[q.Xpos, q.Ypos] = q.Symbol.ToString();

            PrintBoard();

            return board;
        }

        public void Play()
        {
            //getting coordinates from player             
            Console.WriteLine("Please write King's coordinates");
            Console.Write("Input letter: ");

            char input = char.Parse(Console.ReadLine().ToUpper());
            //king2.Ypos = Array.IndexOf(lettersArray, input);  
            int x = Array.IndexOf(lettersArray, input); //secondCoordinate

            Console.Write("Input number: ");
            //king2.Xpos = 8 - int.Parse(Console.ReadLine());  
            int y = 8 - int.Parse(Console.ReadLine()); //firstCoordinate

            Console.Clear();

            if (king1.IsPossibleToMove(x, y))
            {
                king1.Xpos = y;
                king1.Ypos = x;
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("Wrong Coordinates!");
            }
            Update(king1, king2, rook1, rook2, queen);
        }
    }
}
