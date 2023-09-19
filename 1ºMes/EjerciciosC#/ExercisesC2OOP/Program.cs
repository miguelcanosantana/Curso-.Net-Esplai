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

            Print("Choose an Exercise (Enter a number from 1 to 7) (0 to exit): ");
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
                    Power();
                    break;

                case 2:
                    Division();
                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;
            }
        }


        private static void Power()
        {
            Print("Write the number: ");
            int x; 
            var xResult = int.TryParse(Console.ReadLine(), out x);

            Print("Number of power (x^p): ");
            int p;
            var pResult = int.TryParse(Console.ReadLine(), out p);

            if (!xResult || !pResult)
            {
                PrintL("Some of the input values were not numbers...");
                return;
            }

            float result = x;

            if (p > 0)
            {
                for (int i = 1; i < p; i++)
                {
                    result *= x;
                }
            }
            else if (p == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = p; i < 1; i++)
                {
                    result /= x;
                }
            }

            PrintL("The result is: " + result);
        }


        private static void Division()
        {
            Print("Write the number: ");
            int n;
            var nResult = int.TryParse(Console.ReadLine(), out n);

            Print("Number of division (n/d): ");
            int d;
            var dResult = int.TryParse(Console.ReadLine(), out d);

            if (!nResult || !dResult)
            {
                PrintL("Some of the input values were not numbers...");
                return;
            }

            int result = 0;
            int c = 0;

            if (n < d)
            {
                result = 0;
                PrintL("The result is: " + result);
                return;
            }

            while (n >= d)
            {
                n -= d;
                c++;
            }

            result = c;
            PrintL("The result is: " + result);
        }
    }
}
