using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToMorse
{
    internal class Program
    {


    static void Main(string[] args)
        {
            MorseTranslator();
        }


        private static void MorseTranslator()
        {
            Dictionary<string, string> dictionary;

            dictionary = new Dictionary<string, string>(){
            {"a", ".-"},{"b", "-..."},{"c", "-.-."},
            {"d", "-.."},{"e", "."},{"f", "..-."},
            {"g", "--."},{"h", "...."},{"i", ".."},
            {"j", ".---"},{"k", "-.-"},{"l", ".-.."},
            {"m", "--"},{"n", "-."},{"o", "---"},
            {"p", ".--"},{"q", "--.-"},{"r", ".-."},
            {"s", "..."},{"t", "-"},{"u", "..-"},
            {"v", "...-"},{"w", ".--"},{"x", "-..-"},
            {"y", "-.--"},{"z", "--."},{"0", "-----"},
            {"1", ".----"},{"2", "..---"},{"3", "...--"},
            {"4", "....-"},{"5", "....."},{"6", "-...."},
            {"7", "--..."},{"8", "---.."},{"9", "----."},

};

            PrintL("Input the message you want to translate to morse");
            string message = Console.ReadLine();

            char[] messageChars = message.ToCharArray();
        }


        private static void Print(string value)
        {
            Console.Write(value);
        }


        private static void PrintL(string value)
        {
            Console.WriteLine(value);
        }
    }
}
