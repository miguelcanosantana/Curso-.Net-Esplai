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
        //Grid
        static List<List<string>> grid2D = new List<List<string>>();
        static int sideSize = 25;

        //Snake
        static List<Tuple<int, int>> snakeParts = new List<Tuple<int, int>>();
        static Vector2 inputDirection = Vector2.Zero;


        static void Main(string[] args)
        {
            SnakeAllLogic();
        }


        private static void SnakeAllLogic()
        {
            CreateGrid();
            CreateSnake();
            PrintGridAndSnake();

            GameLoop();
        }


        private static void GameLoop()
        {
            bool isPlayingGame = true;

            while (isPlayingGame)
            {

                isPlayingGame = SnakeControls();
                Thread.Sleep(500);
            }
        }


        private static bool SnakeControls()
        {
            //Read the press of the keys
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        inputDirection = -Vector2.UnitX;
                        break;

                    case ConsoleKey.RightArrow:
                        inputDirection = Vector2.UnitX;
                        break;

                    case ConsoleKey.UpArrow:
                        inputDirection = Vector2.UnitY;
                        break;

                    case ConsoleKey.DownArrow:
                        inputDirection = -Vector2.UnitY;
                        break;

                    case ConsoleKey.Escape:
                        return false;
                }
            }

            //Check if the snake can move, if so, move it automatically
            Tuple<int, int> headPosition; 


            return true;
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


        private static void PrintGridAndSnake()
        {
            for (int r = 0; r < grid2D.Count; r++)
            {
                Console.WriteLine("");

                for (int c = 0; c < grid2D[r].Count; c++)
                {

                    if (snakeParts.Contains(Tuple.Create(r, c)))
                    {
                        Console.Write("+");
                    }
                    else
                        Console.Write("·");
                    
                }
            }
        }

    }
}
