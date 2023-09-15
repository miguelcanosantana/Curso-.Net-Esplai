using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandaEjercicios001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int exerciseToDisplay = 0;

            exerciseToDisplay = Convert.ToInt32(Console.ReadLine());

            LaunchExercise(exerciseToDisplay);
        }

        private static void LaunchExercise(int exerciseToDisplay)
        {
            switch (exerciseToDisplay)
            {
                case 1:

                    break;

                default:
                    break;
            }

            Console.Title = "Exercise " + exerciseToDisplay.ToString();
            Console.ReadKey();
        }
    }
}
