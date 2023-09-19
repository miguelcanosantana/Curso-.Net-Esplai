using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandaEjercicios003
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
                    WorkDays();
                    break;

                case 2:
                    Password();
                    break;

                case 3:
                    InverseCalc();
                    break;
            }
        }


        private static void WorkDays()
        {
            Print("Input the name of the day in english (Starting with a capital letter): ");
            string dayInput = Convert.ToString(Console.ReadLine());

            WeekDay dayParsed;

            var result = Enum.TryParse(dayInput, out dayParsed);

            if (!result)
            {
                PrintL("That day doesn't exist!");
                return;
            }
            

            switch (dayParsed)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    PrintL("It's a working day");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    PrintL("It's NOT a working day");
                    break;
            }
        }


        private static void Password()
        {
            Print("Input the password: ");
            string originalPassword = Convert.ToString(Console.ReadLine());

            int attempts = 3;
            string input = "";

            do
            {
                Print("You have " + attempts + " attempts: ");
                attempts--;
                input = Convert.ToString(Console.ReadLine());
            } while (attempts > 0 && !input.Equals(originalPassword));

            if (input.Equals(originalPassword)) PrintL("Greetings!");
            else PrintL("You have no attempts left");
        }


        private static void InverseCalc()
        {
            Print("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Print("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Print("Enter an arithmetical symbol: ");
            string symbol = Convert.ToString(Console.ReadLine());

            float result = 0;

            switch (symbol)
            {
                case "+":
                    result = x + y;
                    break;

                case "-":
                    result = x - y;
                    break;

                case "*":
                    result = x * y;
                    break; 

                case "/":
                    result = x / y;
                    break;

                case "%":
                    result = x % y;
                    break;

                case "^":
                    result = x ^ y;
                    break;
            }

            PrintL("The result is: " + result);
        }
    }
}
