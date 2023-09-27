using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{

    internal class Program
    {
        //Game
        static bool isPlayingGame = false;

        //Grid
        static List<List<string>> grid2D = new List<List<string>>();
        static int sideSize = 25;

        //Snake
        static List<Tuple<int, int>> snakeParts = new List<Tuple<int, int>>();
        static Vector2 inputDirection = Vector2.Zero;
        static ConsoleKey previousKey;


        static void Main(string[] args)
        {
            SnakeAllLogic();
        }


        private static void SnakeAllLogic()
        {
            CreateGrid();
            CreateSnake();
            PrintBoard();

            GameLoop();
        }


        private static void GameLoop()
        {
            isPlayingGame = true;

            while (isPlayingGame)
            {

                SnakeControls();
                PrintBoard();
                Thread.Sleep(100);
            }
        }


        private static void SnakeControls()
        {
            //Read the press of the keys
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    isPlayingGame = false;
                    return;
                }

                if (key.Key == ConsoleKey.LeftArrow && previousKey != ConsoleKey.RightArrow)
                {
                    inputDirection = -Vector2.UnitX;
                    previousKey = key.Key;
                }
                else if (key.Key == ConsoleKey.RightArrow && previousKey != ConsoleKey.LeftArrow)
                {
                    inputDirection = Vector2.UnitX;
                    previousKey = key.Key;
                }
                else if (key.Key == ConsoleKey.UpArrow && previousKey != ConsoleKey.DownArrow)
                {
                    inputDirection = -Vector2.UnitY;
                    previousKey = key.Key;
                }
                else if (key.Key == ConsoleKey.DownArrow && previousKey != ConsoleKey.UpArrow)
                {
                    inputDirection = Vector2.UnitY;
                    previousKey = key.Key;
                }

            }

            //Check if the snake can move, if so, move it automatically
            Tuple<int, int> headPosition = snakeParts[0];
            
            int newPositionY = (int) (snakeParts[0].Item1 + inputDirection.Y);
            int newPositionX = (int) (snakeParts[0].Item2 + inputDirection.X);

            snakeParts[0] = Tuple.Create(newPositionY, newPositionX);
        }


        private static void CreateGrid()
        {
            grid2D.Clear();

            //Create for the first time
            for (int i = 0; i < sideSize; i++)
            {
                grid2D.Add(new List<string>());

                for (int k = 0; k < sideSize; k++)
                    grid2D[i].Add("·");
            }
        }


        private static void CreateSnake()
        {
            snakeParts.Clear();

            //Create the first part (the head)
            int midGrid = sideSize / 2;

            snakeParts.Add(Tuple.Create(midGrid, midGrid));
        }


        private static void PrintBoard()
        {
            Console.Clear();

            for (int r = 0; r < grid2D.Count; r++)
            {
                Console.WriteLine("");

                for (int c = 0; c < grid2D[r].Count; c++)
                {

                    if (snakeParts.Contains(Tuple.Create(r, c)))
                    {
                        //Check if it's the head or a body part
                        if (grid2D[r][c] == grid2D[0][0])
                            Console.Write("X");
                        else
                            Console.Write("+");
                    }
                    else
                        Console.Write("·");
                }
            }
        }

    }
}
