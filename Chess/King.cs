using System;
namespace Chess
{
    public class King : Piece
    {
        public King(int xPos, int yPos, string color) : base(xPos, yPos, color)
        {
            Symbol = 'K';
        }
        public bool IsPossibleToMove(int x, int y)
        {
            if (Math.Abs(Xpos + 1 - (8 - y)) == 1 && Math.Abs(Ypos - (8 - x)) == 0
                || Math.Abs(Xpos + 1 - (8 - y)) == 1 && Math.Abs(Ypos - (8 - x)) == 1
                || Math.Abs(Xpos + 1 - (8 - y)) == 1 && Math.Abs(Ypos - (8 - x)) == 1
                || Math.Abs(Xpos + 1 - (8 - y)) == 0 && Math.Abs(Ypos - (8 - x)) == 1
                || Math.Abs(Xpos + 1 - (8 - y)) == 0 && Math.Abs(Ypos - (8 - x)) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}