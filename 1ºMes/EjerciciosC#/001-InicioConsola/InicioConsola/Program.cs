using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InicioConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Hi Gorge!");
        }


        private static void SayHello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
