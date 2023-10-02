using System;
using System.Collections;
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
        static int length;
        static int height;

        //Snake
        static List<Tuple<int, int>> snakeParts = new List<Tuple<int, int>>();
        static List<Tuple<int, int>> previousPartsPositions = new List<Tuple<int, int>>();
        static Vector2 inputDirection = Vector2.Zero;
        static ConsoleKey previousKey;

        //Apple
        static Tuple<int, int> applePosition;


        static void Main(string[] args)
        {
            SnakeAllLogic();
        }


        private static void MenuDecisionLogic()
        {
            bool result = false;
            string input = "";

            do
            {
                PrintMenu();
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        result = true;
                        break;

                    case "x":
                        return;

                    default:
                        result = false;
                        break;
                }

            } while (!result);
        }


        private static void SnakeAllLogic()
        {

            MenuDecisionLogic();

            bool resultY = false;
            bool resultX = false;

            do
            {
                Console.Write("Enter the grid height: ");
                resultY = int.TryParse(Console.ReadLine(), out height);

                Console.Write("Enter the grid width: ");
                resultX = int.TryParse(Console.ReadLine(), out length);

            } while (!resultX || ! resultY || length < 5 || height < 5);

            CreateGrid();
            CreateSnake();
            GenerateApple();

            GameLoop();

            PrintDeathScreen();
        }


        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(@"                                           /^\/^\
                                         _|__|  O|
                                \/     /~     \_/ \
                                 \____|__________/  \
                                        \_______      \
                                                `\     \                 \
                                                  |     |                  \
                                                 /      /                    \
                                                /     /                       \\
                                              /      /                         \ \
                                             /     /                            \  \
                                           /     /             _----_            \   \
                                          /     /           _-~      ~-_         |   |
                                         (      (        _-~    _--_    ~-_     _/   |
                                          \      ~-____-~    _-~    ~-_    ~-_-~    /
                                            ~-_           _-~          ~-_       _-~
                                               ~--______-~                ~-___-~"
            );

            Console.WriteLine("\n _-_-SNAKE-_-_");
            Console.WriteLine("Press 1 to play");
            Console.WriteLine("Press X to exit");
            Console.Write("Input: ");
        }


        private static void GameLoop()
        {
            isPlayingGame = true;

            while (isPlayingGame)
            {

                SnakeControls();
                CanEatApple();
                PrintBoard();
                Thread.Sleep(100);
            }
        }


        private static void GenerateApple()
        {
            Random rnd = new Random();

            int randomY = rnd.Next(0, height);
            int randomX = rnd.Next(0, length);

            applePosition = new Tuple<int, int>(randomY, randomX);
        }


        //TODO
        private static void CanEatApple()
        {
            if (snakeParts[0].Item1 == applePosition.Item1 && snakeParts[0].Item2 == applePosition.Item2)
            {
                GrowSnake(1);
                GenerateApple();
            }
        }


        private static void GrowSnake(int number)
        {
            var positionOfLastPart = snakeParts[snakeParts.Count - 1];
            snakeParts.Add(positionOfLastPart);
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

            //Save a backup of current positions, to make them previous later
            previousPartsPositions.Clear();
            foreach (var part in snakeParts)
            {
                previousPartsPositions.Add(part);
            }

            //Move the snake automatically
            Tuple<int, int> headPosition = snakeParts[0];
            
            int newPositionY = (int) (snakeParts[0].Item1 + inputDirection.Y);
            int newPositionX = (int) (snakeParts[0].Item2 + inputDirection.X);

            //Check limits
            if (newPositionY < 0) 
                newPositionY = height;
            else if 
                (newPositionY >= height) newPositionY = 0;

            if (newPositionX < 0)
                newPositionX = length;
            else if
                (newPositionX >= length) newPositionX = 0;

            //Set final position to the head
            snakeParts[0] = Tuple.Create(newPositionY, newPositionX);

            //Set the parts to the previous positions (Not the head)
            if (snakeParts.Count > 1)
            {
                for (int i = 1; i < snakeParts.Count; i++)
                {
                    snakeParts[i] = previousPartsPositions[i - 1];
                }
            }

        }


        private static void CreateGrid()
        {
            grid2D.Clear();

            //Create for the first time
            for (int i = 0; i < height; i++)
            {
                grid2D.Add(new List<string>());

                for (int k = 0; k < length; k++)
                    grid2D[i].Add("·");
            }
        }


        private static void CreateSnake()
        {
            snakeParts.Clear();

            //Create the first part (the head)
            int midLength = length / 2;
            int midHeight = height / 2;

            snakeParts.Add(Tuple.Create(midHeight, midLength));
        }


        private static void PrintBoard()
        {
            //Printing everything at once in a single string reduces blinking
            string scene = "";

            for (int r = 0; r < grid2D.Count; r++)
            {
                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    if (snakeParts.Contains(Tuple.Create(r, c)))
                    {
                        //Check if it's the head or a body part
                        if (grid2D[r][c] == grid2D[0][0])
                            scene += "X";
                        else
                            scene += "+";
                    }
                    else if (applePosition.Item1 == r && applePosition.Item2 == c)
                        scene += "O";
                    else
                        scene += "·";
                }
                scene += '\n';
            }

            Console.Clear();
            Console.Write(scene);
        }


        private static void PrintDeathScreen()
        {
            Console.Clear();
            Console.WriteLine(@"                                           /^\/^\
                                         _|__|  X|
                                \/     /~     \_/ \
                                 \____|__________/  \
                                        \_______      \
                                                `\     \                 \
                                                  |     |                  \
                                                 /      /                    \
                                                /     /                       \\
                                              /      /                         \ \
                                             /     /                            \  \
                                           /     /             _----_            \   \
                                          /     /           _-~      ~-_         |   |
                                         (      (        _-~    _--_    ~-_     _/   |
                                          \      ~-____-~    _-~    ~-_    ~-_-~    /
                                            ~-_           _-~          ~-_       _-~
                                               ~--______-~                ~-___-~"
            );

            Console.WriteLine("\n _-_-GAME OVER-_-_");
            Console.WriteLine("\n Press any key to go back to the main menu");

            Console.ReadKey();

            SnakeAllLogic();
        }

    }
}
