using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HospitalLoop();
            Console.ReadKey();
        }

        static public void HospitalLoop()
        {
            int selectOption;
            bool result;

            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Create Hospital");
                Console.WriteLine("2.Modify Hospital");
                Console.WriteLine("3.Remove Hospital");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("4.Create Patient");
                Console.WriteLine("5.Modify Patient");
                Console.WriteLine("6.Remove Patient");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("7.Create Medic");
                Console.WriteLine("8.Modify Medic");
                Console.WriteLine("9.Remove Medic");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("10.Create Appointment");
                Console.WriteLine("11.Modify Appointment");
                Console.WriteLine("12.Remove Appointment");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("13.Print patient's appointments");
                Console.WriteLine("14.Print medic's appointments");
                Console.WriteLine("--------------------------------");
                Console.Write("Input: ");

                result = int.TryParse(Console.ReadLine(), out selectOption);

                switch (selectOption)
                {

                    default:
                        Console.Clear();
                        Console.WriteLine("\n Your input was incorrect, try again...");
                        break;
                }

                Console.WriteLine("\n");

            } while (!result || selectOption != 0);
        }
    }
}
