using System;
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
        static Dictionary<int, eBoxType> snakeDictionary = new Dictionary<int, eBoxType>();


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

            PrintGrid();
        }


        private static void PrintGrid()
        {
            for (int r = 0; r < grid2D.Count; r++)
            {
                Console.WriteLine("");
                for (int c = 0; c < grid2D[r].Count; c++)
                {
                    eBoxType boxType;

                    if (snakeDictionary.TryGetValue(1, out boxType))
                    {

                    }
                    else
                        Console.Write("·");
                    
                    //switch (grid2D[r][c])
                    //{
                    //    case eBoxType.Empty:
                    //        Console.Write("·");
                    //        break;
                    //    case eBoxType.SnakeBody:
                    //        Console.Write("+");
                    //        break;
                    //    case eBoxType.SnakeHead:
                    //        Console.Write("⟩");
                    //        break;
                    //}
                    
                }
            }
        }

    }
}
