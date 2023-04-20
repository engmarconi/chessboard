using ChessBoardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardLibrary
{
    public class ChessBoard
    {
        const int rows = 8;
        const int columns = 8;
        private List<List<GameObjects>> Board;
        
        public ChessBoard()
        {
            //init board
            Board = new List<List<GameObjects>>();

            //Prepear blanks rows
            var blanks = new List<GameObjects>();
            for (int j = 0; j < columns; j++)
                blanks.Add(new BlankSpace());

            //Add blanks rows to board
            for (int i = 0; i < rows - 4; i++)
                Board.Add(blanks);
            
            //Prepare pawn white and black lists
            var whitePawnList = new List<GameObjects>();
            var blackPawnList = new List<GameObjects>();
            for (int i = 0; i < columns; i++)
            {
                whitePawnList.Add(new ChessPiece(EnChessName.Pawn, EnChessColour.White));
                blackPawnList.Add(new ChessPiece(EnChessName.Pawn, EnChessColour.Black));
            }

            //Inset black row in first line
            Board.Insert(0, new List<GameObjects>
            {
               new ChessPiece(EnChessName.Castle, EnChessColour.Black),
               new ChessPiece(EnChessName.Knight, EnChessColour.Black),
               new ChessPiece(EnChessName.Bishop, EnChessColour.Black),
               new ChessPiece(EnChessName.Queen, EnChessColour.Black),
               new ChessPiece(EnChessName.King, EnChessColour.Black),
               new ChessPiece(EnChessName.Bishop, EnChessColour.Black),
               new ChessPiece(EnChessName.Knight, EnChessColour.Black),
               new ChessPiece(EnChessName.Castle, EnChessColour.Black),
            });
            //inset black pawn in 2nd line
            Board.Insert(1, blackPawnList);

            //Push white pawn list 
            Board.Add(whitePawnList);
            //Push white row in last line
            Board.Add(new List<GameObjects>
            {
               new ChessPiece(EnChessName.Castle, EnChessColour.White),
               new ChessPiece(EnChessName.Knight, EnChessColour.White),
               new ChessPiece(EnChessName.Bishop, EnChessColour.White),
               new ChessPiece(EnChessName.Queen, EnChessColour.White),
               new ChessPiece(EnChessName.King, EnChessColour.White),
               new ChessPiece(EnChessName.Bishop, EnChessColour.White),
               new ChessPiece(EnChessName.Knight, EnChessColour.White),
               new ChessPiece(EnChessName.Castle, EnChessColour.White),
            });
        }

        /// <summary>
        /// Print Board
        /// </summary>
        public void ShowBoard()
        {
            foreach (var line in Board)
            {
                foreach (var piece in line)
                    Console.Write(piece.Name);
                Console.WriteLine();
            }
        }
    }
}
