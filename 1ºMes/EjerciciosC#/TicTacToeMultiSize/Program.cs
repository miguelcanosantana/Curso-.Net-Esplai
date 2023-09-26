﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMultiSize
{
    internal class Program
    {
        enum Player
        {
            None,
            X,
            O
        }


        static void Main(string[] args)
        {
            Logic();
        }


        private static void Logic()
        {
            string selectedOption = null;

            do
            {
                selectedOption = SelectOptionMenu();

                if (selectedOption.Equals("1")) TicTacToeMatch();

            } while (!selectedOption.Equals("x"));
        }


        private static string SelectOptionMenu()
        {
            Console.Clear();

            //http://patorjk.com/software/taag/#p=display&f=Big&t=TIC-TAC-TOE
            Console.WriteLine(@"  
                  _______ _____ _____   _______        _____  ______ ____  _______
                 |__   __|_   _/ ____| |__   __|/\   / ____| |__   _|/ __ \|  ____|
                    | |    | || |   ______| |  /  \ | |   _____| |   | | | | |__   
                    | |    | || |  |______| | / /\ \| |  |_____| |   | | | |  __|  
                    | |   _| || |_____    | |/ ____ \ |____    | |   | | | |  |___
                    |_|  |_____\\_____|   |_/_/    \_\_____|   |_|   \____/|______|");

            Console.WriteLine("Press 1 to Play!");
            Console.WriteLine("Press X to exit");
            Console.Write("Input: ");

            return Console.ReadLine();
        }


        private static void TicTacToeMatch()
        {
            Player currentPlayer = Player.X;
            Player? winnerPlayer = null;

            int size = 2;
            bool result = false;

            do
            {
                Console.Write("Input the grid size: ");
                result = int.TryParse(Console.ReadLine(), out size);
            } while (!result || size < 2);

            //https://www.delftstack.com/howto/csharp/declare-a-multidimensional-list-in-csharp/
            List<List<string>> grid2D = new List<List<string>>();

            for (int i = 0; i < size; i++)
            {
                grid2D.Add(new List<string>());

                for (int k = 0; k < size; k++)
                {
                    grid2D[i].Add(".");
                }
            }



            do
            {
                bool canPutMove = false;
                Tuple<int, int> boxNumber;

                do
                {
                    RefreshGrid(grid2D);
                    Console.WriteLine("It's player " + currentPlayer.ToString() + " turn. \n");

                    //https://www.codeproject.com/Questions/336952/Two-Dimensional-List
                    boxNumber = AskForNumber("Input the number (1 - 9): ");
                    canPutMove = CanPutMove(grid2D[boxNumber.Item1][boxNumber.Item2]);

                    if (!canPutMove)
                    {
                        Console.WriteLine("That box is already taken!\n");
                        Console.ReadKey();
                    }

                } while (!canPutMove);

                grid2D[boxNumber.Item1][boxNumber.Item2] = currentPlayer.ToString();

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


        private static void RefreshGrid(List<List<string>> grid2D)
        {
            Console.Clear();

            for (int i = 0; i < grid2D.Count; i++)
            {
                Console.WriteLine("");

                for (int k = 0; k < grid2D[i].Count; k++)
                {
                    Console.Write(grid2D[i][k].ToString());
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }


        private static Player? CheckTheWinner(Player currentPlayer, List<List<string>> grid2D)
        {
            string playerName = currentPlayer.ToString();

            ////Rows
            //if ((grid2D[0, 0] == playerName && grid2D[0, 1] == playerName && grid2D[0, 2] == playerName) ||
            //    (grid2D[1, 0] == playerName && grid2D[1, 1] == playerName && grid2D[1, 2] == playerName) ||
            //    (grid2D[2, 0] == playerName && grid2D[2, 1] == playerName && grid2D[2, 2] == playerName))
            //    return currentPlayer;

            ////Columns
            //if ((grid2D[0, 0] == playerName && grid2D[1, 0] == playerName && grid2D[2, 0] == playerName) ||
            //    (grid2D[0, 1] == playerName && grid2D[1, 1] == playerName && grid2D[2, 1] == playerName) ||
            //    (grid2D[0, 2] == playerName && grid2D[1, 2] == playerName && grid2D[2, 2] == playerName))
            //    return currentPlayer;

            ////Diagonals
            //if ((grid2D[0, 0] == playerName && grid2D[1, 1] == playerName && grid2D[2, 2] == playerName) ||
            //    (grid2D[0, 2] == playerName && grid2D[1, 1] == playerName && grid2D[2, 0] == playerName))
            //    return currentPlayer;

            //Check if the board is full to declare no winners
            //https://stackoverflow.com/questions/8184306/iterate-through-2-dimensional-array-c-sharp

            int emptySpacesCount = 0;

            //for (int k = 0; k < grid2D.GetLength(0); k++)
            //{
            //    for (int l = 0; l < grid2D.GetLength(1); l++)
            //    {
            //        if (grid2D[k, l].Equals(".")) emptySpacesCount++;
            //    }
            //}

            if (emptySpacesCount == 0) return Player.None;

            return null;
        }


        private static void ShowWinningScreen(Player? winnerPlayer)
        {
            if (winnerPlayer != Player.None)
            {
                Console.WriteLine(winnerPlayer.ToString() + " won!");
                Console.WriteLine("Congratulations!!!");
            }
            else
            {
                Console.WriteLine("No one won!");
                Console.WriteLine("Congratulations?");
            }

            Console.WriteLine("\nPress any key to go back to the menu");
            Console.ReadKey();
        }
    }
}
