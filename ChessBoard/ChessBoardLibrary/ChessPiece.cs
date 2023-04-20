using ChessBoardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardLibrary
{
    public class ChessPiece : GameObjects
    {
        public EnChessColour Colour { get; set; }
        public EnChessName PieceName { get; set; }


        public ChessPiece()
        {

        }

        public ChessPiece(EnChessName name, EnChessColour colour)
        {
            Colour = colour;
            PieceName = name;

            switch (name)
            {
                case EnChessName.King:
                    Name = Colour == EnChessColour.White ? "\u2654" : "\u265A";
                    break;
                case EnChessName.Queen:
                    Name = Colour == EnChessColour.White ? "\u2655" : "\u265B";
                    break;
                case EnChessName.Castle:
                    Name = Colour == EnChessColour.White ? "\u2656" : "\u265C";
                    break;
                case EnChessName.Bishop:
                    Name = Colour == EnChessColour.White ? "\u2657" : "\u265D";
                    break;
                case EnChessName.Knight:
                    Name = Colour == EnChessColour.White ? "\u2658" : "\u265E";
                    break;
                case EnChessName.Pawn:
                    Name = Colour == EnChessColour.White ? "\u2659" : "\u265F";
                    break;
            }
        }


        public override string ToString()
        {
            return $"{PieceName} - {Colour}";
        }
    }
}
