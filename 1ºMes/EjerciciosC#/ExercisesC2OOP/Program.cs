using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesC2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        private static void Menu()
        {
            bool result = false;
            int exerciseToDisplay = 1;

            Console.Title = "Choose an exercise :)";

            Print("Choose an Exercise (Enter a number from 1 to 3) (0 to exit): ");
            result = int.TryParse(Console.ReadLine(), out exerciseToDisplay);

            if (result && exerciseToDisplay != 0)
            {
                LaunchExercise(exerciseToDisplay);
                Console.ReadKey();
                Menu();
            }
            else if (!result)
            {
                Menu();
            }
        }


        private enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }



        private static void Print(string value)
        {
            Console.Write(value);
        }


        private static void PrintL(string value)
        {
            Console.WriteLine(value);
        }


        private static void LaunchExercise(int exerciseToDisplay)
        {
            Console.Title = "Exercise " + exerciseToDisplay.ToString();

            switch (exerciseToDisplay)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;
            }
        }


        private static void Power()
        {
            Print("Write the first number: ");
            int x; 
            var xResult = int.TryParse(Console.ReadLine(), out x);

            Print("Write the second number: ");
            int y;
            var yResult = int.TryParse(Console.ReadLine(), out y);

            if (!xResult || !yResult)
            {
                PrintL("Some of the input values were not numbers...");
                return;
            }
        }

    }
}
