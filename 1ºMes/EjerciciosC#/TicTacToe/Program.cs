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
        enum Player
        {   None,
            X,
            O
        }


        static void Main(string[] args)
        {
            TicTacToeMatch();
            Console.ReadKey();
        }


        private static void TicTacToeMatch()
        {
            Player currentPlayer = Player.X;
            Player? winnerPlayer = null;

            //https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array
            string[,] grid2D = new string[3, 3]{
                    {".", ".", "."},
                    {".", ".", "."},
                    {".", ".", "."},
            };

            do
            {
                bool canMove = false;

                int row;
                int column;

                do
                {
                    Console.Clear();
                    RefreshGrid(grid2D);
                    Console.WriteLine("It's player " + currentPlayer.ToString() + " turn. \n");

                    row = AskForNumber("Input the row: ");
                    column = AskForNumber("Input the column: ");
                    canMove = CanPutMove(grid2D[row - 1, column - 1]);

                    if (!canMove)
                    {
                        Console.WriteLine("That box is already taken!\n");
                        Console.ReadKey();
                    }

                } while (!canMove);

                grid2D[row - 1, column - 1] = currentPlayer.ToString();

                winnerPlayer = CheckTheWinner(currentPlayer, grid2D);

                //Switch players
                if (currentPlayer == Player.X) currentPlayer = Player.O;
                else currentPlayer = Player.X;

            } while (winnerPlayer == null);


            RefreshGrid(grid2D);
            Console.WriteLine("Winner Player is: " + winnerPlayer.ToString());
            Console.WriteLine("Congratulations!!!");
        }


        private static bool CanPutMove(string positionSymbol)
        {
            if (positionSymbol == ".") return true;
            else return false;
        }


        private static int AskForNumber(string message)
        {
            int number = 0;
            bool result;

            do
            {
                Console.Write(message);
                result = Int32.TryParse(Console.ReadLine(), out number);

            } while (!result || number > 3 || number < 1);

            return number;
        }

        
        private static void RefreshGrid(string[,] grid2D)
        {

            Console.WriteLine(" _______________________\n" +
                                "|       |       |       |\n" +
                                "|   {0}   |   {1}   |   {2}   |\n" +
                                "|_______|_______|_______|\n" +
                                "|       |       |       |\n" +
                                "|   {3}   |   {4}   |   {5}   |\n" +
                                "|_______|_______|_______|\n" +
                                "|       |       |       |\n" +
                                "|   {6}   |   {7}   |   {8}   |\n" +
                                "|_______|_______|_______|\n",
                                grid2D[0, 0], grid2D[0, 1], grid2D[0, 2],
                                grid2D[1, 0], grid2D[1, 1], grid2D[1, 2],
                                grid2D[2, 0], grid2D[2, 1], grid2D[2, 2]);

            Console.WriteLine("");
            Console.WriteLine("");
        }


        private static Player? CheckTheWinner(Player currentPlayer, string[,] grid2D)
        {
            string playerName = currentPlayer.ToString();

            //Rows
            if (grid2D[0, 0] == playerName && grid2D[0, 1] == playerName && grid2D[0, 2] == playerName) return currentPlayer;
            if (grid2D[1, 0] == playerName && grid2D[1, 1] == playerName && grid2D[1, 2] == playerName) return currentPlayer;
            if (grid2D[2, 0] == playerName && grid2D[2, 1] == playerName && grid2D[2, 2] == playerName) return currentPlayer;

            //Columns
            if (grid2D[0, 0] == playerName && grid2D[1, 0] == playerName && grid2D[2, 0] == playerName) return currentPlayer;
            if (grid2D[0, 1] == playerName && grid2D[1, 1] == playerName && grid2D[2, 1] == playerName) return currentPlayer;
            if (grid2D[0, 2] == playerName && grid2D[1, 2] == playerName && grid2D[2, 2] == playerName) return currentPlayer;

            //Diagonals
            if (grid2D[0, 0] == playerName && grid2D[1, 1] == playerName && grid2D[2, 2] == playerName) return currentPlayer;
            if (grid2D[0, 2] == playerName && grid2D[1, 1] == playerName && grid2D[2, 0] == playerName) return currentPlayer;

            return null;
        }


        private static void ShowWinningScreen(Player currentPlayer)
        {

        }
    }
}
