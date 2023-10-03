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
        private float radius;

        public Circle(float radius) 
        {
            this.radius = radius;
        }

        public float Area()
        {
            return (float) (Math.PI * Math.Pow(radius, 2));
        }
    }


    public class Polygon : Form
    {
        protected float width;
        protected float height;

        public Polygon(float width, float height) 
        {
            this.width = width;
            this.height = height;
        }
    }


    public class Rectangle : Polygon
    {

        public Rectangle(float width, float height) : base (width, height)
        {
            this.height = height;
            this.width = width;
        }

        public float Area()
        {
            return width * height;
        }
    }


    public class Square : Rectangle
    {
        //Using width width in the base
        public Square(float width) : base(width, width) 
        {
            this.width = width;
        }
    }


    public class Triangle: Polygon
    {
        public Triangle(float width, float height) : base(width, height) 
        {
            this.width = width;
            this.height = height;
        }


        public float Area()
        {
            return (1/2) * width * height;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateArea();
            Console.ReadKey();
        }


        static private void CalculateArea()
        {
            Console.WriteLine("Choose a figure type:");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("4.Triangle");
            Console.Write("Input: ");

            int result = int.Parse(Console.ReadLine());
            float width;
            float height;
            float radius;
            

            switch (result)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    radius = float.Parse(Console.ReadLine());

                    Circle circle = new Circle(radius);
                    Console.WriteLine(circle.Area());

                    break;

                case 2:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    height = float.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(width, height);
                    Console.WriteLine(rectangle.Area());

                    break;

                case 3:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Square square = new Square(width);
                    Console.WriteLine(square.Area());

                    break;

                case 4:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    height = float.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(width, height);
                    Console.WriteLine(triangle.Area());

                    break;
            }
        }
    }
}
