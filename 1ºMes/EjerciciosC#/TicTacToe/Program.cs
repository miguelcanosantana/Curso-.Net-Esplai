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

            RefreshScreen(grid2D);
        }


        private static void RefreshScreen(string[,] grid2D)
        {
            //GetLength(0) is the 1st dimension, GetLength(1) is the 2nd
            for (int row = 0; row < grid2D.GetLength(0); row++)
            {
                for (int column = 0; column < grid2D.GetLength(1); column++)
                {

                }
            }
                
        }
    }
}
