﻿using System;
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
            Menu();
        }


        private static void Menu()
        {
            bool result = false;
            int exerciseToDisplay = 1;

            Console.Title = "Choose an exercise :)";

            Print("Choose an Exercise (Enter a number from 1 to 5) (0 to exit): ");
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
                    NumbersDoublesAndChars();
                    break;

                case 3:
                    TonsOfCalcs();
                    break;

                case 4:
                    IncrDecrDupl();
                    break;

                case 5:
                    FourVariables();
                    break;

                default:
                    break;
            }
        }


        private static void Numbers()
        {
            float a = 5f;
            float b = 2.5f;

            PrintL("a = " + a + "| b = " + b);
            PrintL("a + b = " + (a + b));
            PrintL("a - b = " + (a - b));
            PrintL("a * b = " + (a * b));
            PrintL("a / b = " + (a / b));
            PrintL("a % b = " + (a % b));
        }


        private static void NumbersDoublesAndChars()
        {
            int n = 1;
            double a = 2.5f;
            char c = 'a';

            PrintL("n variable = " + n);
            PrintL("a variable = " + a);
            PrintL("c variable = " + c.ToString());

            PrintL("n + a = " + (n + a));
            PrintL("a - n = " + (a - n));
            PrintL("c value = " + Convert.ToInt32(c));
        }


        private static void TonsOfCalcs()
        {
            int x, y;
            double n, m;

            Print("Write an int: ");
            x = Convert.ToInt32(Console.ReadLine());

            Print("Write another int: ");
            y = Convert.ToInt32(Console.ReadLine());

            //CultureInfo.InvariantCulture fixes incorrect parsing
            //https://stackoverflow.com/questions/1354924/how-do-i-parse-a-string-with-a-decimal-point-to-a-double
            Print("Write a double: ");
            n = Convert.ToDouble(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Print("Write another double: ");
            m = Convert.ToDouble(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            PrintL(
                "Your numbers are: x = " + x + 
                " | y = " + y + 
                " | n = " + n + 
                " | m = " + m);

            PrintL("x + y = " + (x + y));
            PrintL("x - y = " + (x - y));
            PrintL("x * y = " + (x * y));
            PrintL("x / y = " + (x / y));
            PrintL("x % y = " + (x % y));

            PrintL("n + m = " + (n + m));
            PrintL("n - m = " + (n - m));
            PrintL("n * m = " + (n * m));
            PrintL("n / m = " + (n / m));
            PrintL("n % m = " + (n % m));

            PrintL("x + n = " + (x + n));
            PrintL("y / m = " + (y / m));
            PrintL("y % m = " + (y % m));

            PrintL(
                "2x = " + 2 * x +
                " | 2y = " + 2 * y +
                " | 2n = " + 2 * n +
                " | 2m = " + 2 * m);
            PrintL("x + y + n + m = " + (x + y + n + m));
            PrintL("x * y * n * m = " + (x * y * n * m));
        }


        private static void IncrDecrDupl()
        {
            int n;
            int resultA;
            int resultB;

            Print("Write an int: ");
            n = Convert.ToInt32(Console.ReadLine());

            resultA = n + 77;
            PrintL("n + 77 = " + resultA);

            resultB = resultA - 3;
            PrintL("First Result - 3 = " + resultB);

            PrintL("Second Result * 2 = " + resultB * 2);
        }


        private static void FourVariables()
        {
            int a;
            int b;
            int c;
            int d;

            Print("Write an int: ");
            a = Convert.ToInt32(Console.ReadLine());

            Print("Write another int: ");
            b = Convert.ToInt32(Console.ReadLine());

            Print("Another one: ");
            c = Convert.ToInt32(Console.ReadLine());

            Print("The last one *_*: ");
            d = Convert.ToInt32(Console.ReadLine());

            b = c;
            c = a;
            a = d;
            d = b;

            PrintL(
                "Your numbers are: a = " + a +
                " | b = " + b +
                " | c = " + c +
                " | d = " + b);
        }
    }
}
