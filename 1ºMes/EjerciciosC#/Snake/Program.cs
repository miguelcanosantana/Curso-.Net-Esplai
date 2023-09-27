using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum eBoxType
    {
        None,
        Empty,
        SnakePart
    }


    public class Box
    {
        private eBoxType boxType = eBoxType.None;
    }


    internal class Program
    {
        static List<List<string>> grid2D = new List<List<string>>();

        static void Main(string[] args)
        {
            SnakeAllLogic();
        }


        private static void SnakeAllLogic()
        {
            CreateGrid();
        }


        private static void CreateGrid()
        {
            grid2D.Clear();
        }
    }
}
