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
            //Variables
            int exerciseToDisplay = 0;

            Console.Title = "Choose an exercise :)";

            Print("Choose an Exercise (Enter a number from 1 to 15): ");
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

                    break;

                case 2:
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

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;

                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
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


        private static void CircleArea()
        {
            Print("Enter the circle radius (cm): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = (Math.PI * Math.Pow(radius, 2));
            PrintL(area.ToString() + "cm2 is the circle area");
        }


        private static void DivideByTwo()
        {
            Print("Enter a number to check if it can be divided by 2: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number % 2 == 0) PrintL("It's even.");
            else PrintL("It's odd.");
        }


        private static void CalculateIVA()
        {
            Print("Enter a product price without IVA to calculate it: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double addedIVA = (price / 100) * 21;
            double finalPrice = price + addedIVA;

            PrintL("Final price with added IVA is " + finalPrice + " euros.");
        }


        private static void SalesManager()
        {
            Print("Enter the number of sales: ");
            int salesNumber = int.Parse(Console.ReadLine());

            Dictionary<int, double> salesDictionary = new Dictionary<int, double>();

            for (int sale = 1; sale <= salesNumber; sale++)
            {
                Print("Enter the spent on sale " + sale + ": ");
                double spent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                salesDictionary.Add(sale, spent);
            }

            double totalSales = 0;

            foreach (var entry in salesDictionary)
            {
                totalSales += entry.Value;

                PrintL("The sale " + entry.Key + " was: " + entry.Value + " euros.");
            }

            PrintL("Final sales were " + totalSales + " euros.");
        }
    }
}
