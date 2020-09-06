using System;
namespace Chess
{
    public abstract class Piece
    {
        public char Symbol { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public string Color { get; set; }

        public Piece(int x, int y, string color)
        {
            Xpos = x;
            Ypos = y;
            Color = color;
        }
        //public abstract bool IsPossibleToMove(int x1, int y1, int x2, int y2);
    }
}
