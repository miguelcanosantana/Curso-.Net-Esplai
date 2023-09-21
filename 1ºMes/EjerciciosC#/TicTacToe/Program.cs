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
                bool canPutMove = false;
                Tuple<int, int> boxNumber;

                do
                {
                    RefreshGrid(grid2D);
                    Console.WriteLine("It's player " + currentPlayer.ToString() + " turn. \n");

                    boxNumber = AskForNumber("Input the number (1 - 9): ");
                    canPutMove = CanPutMove(grid2D[boxNumber.Item1, boxNumber.Item2]);

                    if (!canPutMove)
                    {
                        Console.WriteLine("That box is already taken!\n");
                        Console.ReadKey();
                    }

                } while (!canPutMove);

                grid2D[boxNumber.Item1, boxNumber.Item2] = currentPlayer.ToString();

                winnerPlayer = CheckTheWinner(currentPlayer, grid2D);

                //Switch players
                if (currentPlayer == Player.X) currentPlayer = Player.O;
                else currentPlayer = Player.X;

            } while (winnerPlayer == null);

            RefreshGrid(grid2D);
            ShowWinningScreen(winnerPlayer);
        }


        private static bool CanPutMove(string positionSymbol)
        {
            if (positionSymbol == ".") return true;
            else return false;
        }


        //https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller
        private static Tuple<int, int> AskForNumber(string message)
        {
            int number = 0;
            bool result;

            do
            {
                Console.Write(message);
                result = Int32.TryParse(Console.ReadLine(), out number);

            } while (!result || number > 9 || number < 1);

            int row = 0;
            int column = 0;

            //Convert from a number to a multiple index
            switch (number)
            {
                case 1:
                    row = 0;
                    column = 0;
                    break; 
                case 2:
                    row = 0;
                    column = 1;
                    break; 
                case 3:
                    row = 0;
                    column = 2;
                    break; 
                case 4:
                    row = 1;
                    column = 0;
                    break; 
                case 5:
                    row = 1;
                    column = 1;
                    break; 
                case 6:
                    row = 1;
                    column = 2;
                    break; 
                case 7:
                    row = 2;
                    column = 0;
                    break; 
                case 8:
                    row = 2;
                    column = 1;
                    break; 
                case 9:
                    row = 2;
                    column = 2;
                    break; 
            }

            return Tuple.Create(row, column);
        }

        
        private static void RefreshGrid(string[,] grid2D)
        {
            Console.Clear();

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


        private static void ShowWinningScreen(Player? winnerPlayer)
        {
            Console.WriteLine("Winner Player is: " + winnerPlayer.ToString());
            Console.WriteLine("Congratulations!!!");
        }
    }
}
