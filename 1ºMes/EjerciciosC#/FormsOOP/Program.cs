using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOOP
{
    public class Form
    {
        public Form() { }
    }


    public class Circle : Form
    {
        public Circle() { }
    }


    public class Polygon : Form
    {
        public Polygon() { }
    }


    public class Rectangle : Polygon
    {
        public Rectangle() { }
    }


    public class Square : Rectangle
    {
        public Square() { }
    }


    public class Triangle: Polygon
    {
        public Triangle() { }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
