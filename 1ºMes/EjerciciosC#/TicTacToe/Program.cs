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
            Console.ReadKey();
        }


        private static void TicTacToeMatch()
        {
            //https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array
            string[,] grid2D = new string[3, 3]{
                {".", ".", "."},
                {".", ".", "."},
                {".", ".", "."},
            };

            do
            {
                RefreshScreen(grid2D);

                int row = AskForNumber("Input the row: ");
                int column = AskForNumber("Input the column: ");

                Console.WriteLine(row);
                Console.WriteLine(column);

            } while (true);
        }


        private static int AskForNumber(string message)
        {
            int number = 0;
            bool result;

            do
            {
                Console.Write(message);
                result = Int32.TryParse(Console.ReadLine(), out number);

            } while (!result);

            return number;
        }

        
        private static void RefreshScreen(string[,] grid2D)
        {
            //GetLength(0) is the 1st dimension, GetLength(1) is the 2nd
            for (int row = 0; row < grid2D.GetLength(0); row++)
            {
                Console.WriteLine("");

                for (int column = 0; column < grid2D.GetLength(1); column++)
                {
                    string printedChar = grid2D[row, column];
                    Console.Write(printedChar);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
