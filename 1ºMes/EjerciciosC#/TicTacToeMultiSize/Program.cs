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

            int sideSize = 2;
            int totalSize;
            bool result = false;

            do
            {
                Console.Write("Input the grid size: ");
                result = int.TryParse(Console.ReadLine(), out sideSize);
            } while (!result || sideSize < 2);

            totalSize = sideSize * sideSize;

            //https://www.delftstack.com/howto/csharp/declare-a-multidimensional-list-in-csharp/
            List<List<string>> grid2D = new List<List<string>>();

            //Create for the first time
            for (int i = 0; i < sideSize; i++)
            {
                grid2D.Add(new List<string>());

                for (int k = 0; k < sideSize; k++)
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
                    boxNumber = AskForNumber("Input the number (1 - " + totalSize + "): ", grid2D);
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
        private static Tuple<int, int> AskForNumber(string message, List<List<string>> grid2D)
        {
            int number = 0;
            bool result;

            do
            {
                Console.Write(message);
                result = Int32.TryParse(Console.ReadLine(), out number);

            } while (!result || number > grid2D.Count * grid2D.Count || number < 1);

            int count = 0;            

            for (int i = 0; i < grid2D.Count; i++)
            {
                for (int k = 0; k < grid2D[i].Count; k++)
                {
                    count++;

                    if (number == count)
                    {
                        return Tuple.Create(i, k);
                    }
                }
            }

            return null;
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

            int symbolsCount = 0;

            //Rows
            for (int r = 0; r < grid2D.Count; r++)
            {
                symbolsCount = 0;

                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    if (grid2D[r][c].ToString().Equals(playerName)) symbolsCount++;
                }

                if (symbolsCount == grid2D.Count)
                    return currentPlayer;
            }

            //Don't reset the counter each column iteration
            symbolsCount = 0;

            //Columns
            for (int r = 0; r < grid2D.Count; r++)
            {
                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    if (grid2D[r][c].ToString().Equals(playerName)) symbolsCount++;
                }

                if (symbolsCount == grid2D.Count)
                    return currentPlayer;
            }

            //Diagonals
            for (int r = 0; r < grid2D.Count; r++)
            {
                symbolsCount = 0;
                if (grid2D[r][r].ToString().Equals(playerName)) symbolsCount++;

                if (symbolsCount == grid2D.Count)
                    return currentPlayer;
            }


            //Check for empty spaces left
            int emptySpacesCount = 0;

            for (int r = 0; r < grid2D.Count; r++)
            {

                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    if (grid2D[r][c].ToString().Equals(".")) emptySpacesCount++;
                }
            }

            if (emptySpacesCount == 0) 
                return Player.None;

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
