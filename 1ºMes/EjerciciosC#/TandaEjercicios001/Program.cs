using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandaEjercicios001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int exerciseToDisplay = 0;

            Console.Title = "Choose an exercise :)";

            Console.Write("Choose an Exercise: ");
            exerciseToDisplay = Convert.ToInt32(Console.ReadLine());

            LaunchExercise(exerciseToDisplay);
        }

        private static void LaunchExercise(int exerciseToDisplay)
        {
            Console.Title = "Exercise " + exerciseToDisplay.ToString();

            switch (exerciseToDisplay)
            {
                case 1:
                    Numbers();
                    break;

                case 2:
                    NumbersDoublesAndChars();
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }


        private static void Numbers()
        {
            float a = 5f;
            float b = 2.5f;

            Console.WriteLine("a = " + a + "| b = " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
        }


        private static void NumbersDoublesAndChars()
        {
            int n = 1;
            double a = 2.5f;
            char c = 'a';

            Console.WriteLine("n variable = " + n);
            Console.WriteLine("a variable = " + a);
            Console.WriteLine("c variable = " + c.ToString());

            Console.WriteLine("n + a = " + (n + a));
            Console.WriteLine("a - n = " + (a - n));
            Console.WriteLine("c value = " + Convert.ToInt32(c));
        }

    }
}
