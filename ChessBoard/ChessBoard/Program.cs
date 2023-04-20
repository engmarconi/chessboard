using ChessBoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            ChessBoard instance = new ChessBoard();
            instance.ShowBoard();
        }
    }
}
