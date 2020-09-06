using System;
namespace Chess
{
    public class Queen : Piece
    {
        public Queen(int xPos, int yPos, string color) : base(xPos, yPos, color)
        {
            Symbol = 'Q';
        }
        //public override bool IsPossibleToMove(int x1, int y1, int x2, int y2)
        //{
        //    return true;
        //}

    }
}
