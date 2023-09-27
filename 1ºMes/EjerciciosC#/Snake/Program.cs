﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    public enum eBoxType
    {
        Empty,
        SnakeBody,
        SnakeHead
    }


    internal class Program
    {
        //Grid
        static List<List<string>> grid2D = new List<List<string>>();
        static int sideSize = 25;

        //Snake
        static Dictionary<Tuple<int, int>, eBoxType> snakeDictionary = new Dictionary<Tuple<int, int>, eBoxType>();


        static void Main(string[] args)
        {
            SnakeAllLogic();
        }


        private static void SnakeAllLogic()
        {
            CreateGrid();

            Console.ReadKey();
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

            PrintGridAndSnake();
        }


        private static void PrintGridAndSnake()
        {
            for (int r = 0; r < grid2D.Count; r++)
            {
                Console.WriteLine("");

                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    eBoxType boxType;

                    //Using tuples instead arrays, because getting a value by array from a dictionary
                    //is in preview and not oficially supported yet
                    if (snakeDictionary.TryGetValue(Tuple.Create(r, c), out boxType))
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
