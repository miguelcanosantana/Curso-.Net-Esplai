using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandaEjercicios002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int exerciseToDisplay = 0;

            Console.Title = "Choose an exercise :)";

            Print("Choose an Exercise (Enter a number from 1 to 14): ");
            exerciseToDisplay = Convert.ToInt32(Console.ReadLine());

            LaunchExercise(exerciseToDisplay);
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
                    Numbers();
                    break;

                case 2:
                    NameCity();
                    break;

                case 3:
                    NameYears();
                    break;

                case 4:
                    GreaterThan();
                    break;

                case 5:
                    Weekend();
                    break;

                case 6:
                    Payment();
                    break;

                case 7:
                    ToHundredFor();
                    break;

                case 8:
                    ToHundredWhile();
                    break;

                case 9:
                    ToHundredEven();
                    break;

                case 10:
                    ToHundredEvenOrThree();
                    break; 

                case 11:

                    break; 

                case 12:
                            
                    break;

                case 13:

                    break;

                case 14:

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
            float c = 4.75f;

            PrintL("a = " + a + " | b = " + b + " | c = " + c);

            float result = a + b + c;
            PrintL("a + b + c = " + result);
        }


        private static void NameCity()
        {
            Print("Input your name: ");
            string name = Convert.ToString(Console.ReadLine());

            Print("Input the city name: ");
            string city = Convert.ToString(Console.ReadLine());

            PrintL("Hi " + name + ", welcome to " + city + "!");
        }


        private static void NameYears()
        {
            Print("Input your name: ");
            string name = Convert.ToString(Console.ReadLine());

            Print("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            PrintL("Your name is " + name + ", you are " + age + " years old.");
        }


        private static void GreaterThan()
        {
            Print("Input the Number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Print("Input the Number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            if (numberA > numberB)
            {
                PrintL("A is bigger than B");
            }
            else if (numberA < numberB)
            {
                PrintL("B is bigger than A");
            }
            else
            {
                PrintL("Both numbers are equal");
            }
        }


        private static void Weekend()
        {
            List<string> weekendDays = new List<string>();
            weekendDays.Add("Saturday");
            weekendDays.Add("Sunday");

            Print("Input the name of the day in english: ");
            string day = Convert.ToString(Console.ReadLine());


            if (weekendDays.Contains(day)) PrintL("That day is weekend");
            else PrintL("That day is not weekend");
        }


        private static void Payment()
        {
            Print("Input the price of the product to buy: ");
            int price = Convert.ToInt32(Console.ReadLine());

            if (price <= 0) 
            {
                PrintL("The item must have a valid price");
                return;
            }

            Print("Input the payment menthod (cash/card): ");
            string payMethod = Convert.ToString(Console.ReadLine());

            if (payMethod.Equals("cash"))
            {
                PrintL("Thanks for buying the item");
                return;
            }

            if (payMethod.Equals("card"))
            {
                Print("Input the card number: ");
                string cardNumber = Convert.ToString(Console.ReadLine());

                PrintL("Thanks for buying the item");
            }

        }


        private static void ToHundredFor()
        {
            for (int i = 1; i <= 100; i++)
            {
                PrintL(i.ToString());
            }
        }


        private static void ToHundredWhile()
        {
            var count = 1;
            while (count <= 100)
            {
                PrintL(count.ToString());
                count++;
            }
        }


        private static void ToHundredEven()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) PrintL(i.ToString());
            }
        }


        private static void ToHundredEvenOrThree()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0) PrintL(i.ToString());
            }
        }
        //private static void NumbersDoublesAndChars()
        //{
        //    int n = 1;
        //    double a = 2.5f;
        //    char c = 'a';

        //    PrintL("n variable = " + n);
        //    PrintL("a variable = " + a);
        //    PrintL("c variable = " + c.ToString());

        //    PrintL("n + a = " + (n + a));
        //    PrintL("a - n = " + (a - n));
        //    PrintL("c value = " + Convert.ToInt32(c));
        //}


        //private static void TonsOfCalcs()
        //{
        //    int x, y;
        //    double n, m;

        //    Print("Write an int: ");
        //    x = Convert.ToInt32(Console.ReadLine());

        //    Print("Write another int: ");
        //    y = Convert.ToInt32(Console.ReadLine());

        //    //CultureInfo.InvariantCulture fixes incorrect parsing
        //    //https://stackoverflow.com/questions/1354924/how-do-i-parse-a-string-with-a-decimal-point-to-a-double
        //    Print("Write a double: ");
        //    n = Convert.ToDouble(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        //    Print("Write another double: ");
        //    m = Convert.ToDouble(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        //    PrintL(
        //        "Your numbers are: x = " + x +
        //        " | y = " + y +
        //        " | n = " + n +
        //        " | m = " + m);

        //    PrintL("x + y = " + (x + y));
        //    PrintL("x - y = " + (x - y));
        //    PrintL("x * y = " + (x * y));
        //    PrintL("x / y = " + (x / y));
        //    PrintL("x % y = " + (x % y));

        //    PrintL("n + m = " + (n + m));
        //    PrintL("n - m = " + (n - m));
        //    PrintL("n * m = " + (n * m));
        //    PrintL("n / m = " + (n / m));
        //    PrintL("n % m = " + (n % m));

        //    PrintL("x + n = " + (x + n));
        //    PrintL("y / m = " + (y / m));
        //    PrintL("y % m = " + (y % m));

        //    PrintL(
        //        "2x = " + 2 * x +
        //        " | 2y = " + 2 * y +
        //        " | 2n = " + 2 * n +
        //        " | 2m = " + 2 * m);
        //    PrintL("x + y + n + m = " + (x + y + n + m));
        //    PrintL("x * y * n * m = " + (x * y * n * m));
        //}


        //private static void IncrDecrDupl()
        //{
        //    int n;
        //    int resultA;
        //    int resultB;

        //    Print("Write an int: ");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    resultA = n + 77;
        //    PrintL("n + 77 = " + resultA);

        //    resultB = resultA - 3;
        //    PrintL("First Result - 3 = " + resultB);

        //    PrintL("Second Result * 2 = " + resultB * 2);
        //}


        //private static void FourVariables()
        //{
        //    int a;
        //    int b;
        //    int c;
        //    int d;

        //    Print("Write an int: ");
        //    a = Convert.ToInt32(Console.ReadLine());

        //    Print("Write another int: ");
        //    b = Convert.ToInt32(Console.ReadLine());

        //    Print("Another one: ");
        //    c = Convert.ToInt32(Console.ReadLine());

        //    Print("The last one *_*: ");
        //    d = Convert.ToInt32(Console.ReadLine());

        //    b = c;
        //    c = a;
        //    a = d;
        //    d = b;

        //    PrintL(
        //        "Your numbers are: a = " + a +
        //        " | b = " + b +
        //        " | c = " + c +
        //        " | d = " + b);
        //}
    }
}
