﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        enum CurrentPlayer
        {
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
            CurrentPlayer currentPlayer = CurrentPlayer.X;

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

                //Switch players
                if (currentPlayer == CurrentPlayer.X) currentPlayer = CurrentPlayer.O;
                else currentPlayer = CurrentPlayer.X;

            } while (true);
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
            ////GetLength(0) is the 1st dimension, GetLength(1) is the 2nd
            //for (int row = 0; row < grid2D.GetLength(0); row++)
            //{
            //    Console.WriteLine("");

            //    for (int column = 0; column < grid2D.GetLength(1); column++)
            //    {
            //        string printedChar = grid2D[row, column];
            //        Console.Write(printedChar);
            //    }
            //}

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
    }
}
