using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeMatch();
        }


        private static void TicTacToeMatch()
        {
            //https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array
            string[,] grid2D = new string[3, 3]{
                {".", ".", "."},
                {".", ".", "."},
                {".", ".", "."},
            };
        }
    }
}
