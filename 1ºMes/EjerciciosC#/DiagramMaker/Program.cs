using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public abstract class Shape
    {
        public Shape() { }

        //Abstract clases dont contain methods logic and must be implemented in children classes
        public abstract float Area();
        public abstract float Perimeter();
    }


    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float Area()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }


        public override float Perimeter()
        {
            return (float)(2 * Math.PI * radius); ;
        }
    }


    public abstract class Polygon : Shape
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

        public Rectangle(float width, float height) : base(width, height)
        {
            this.height = height;
            this.width = width;
        }

        public override float Area()
        {
            return width * height;
        }

        public override float Perimeter()
        {
            return width * 2 + height * 2;
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


    public class Triangle : Polygon
    {
        public Triangle(float width, float height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }

        public override float Area()
        {
            return (1 / 2) * width * height;
        }

        public override float Perimeter()
        {
            return (float)Math.Sqrt(Math.Pow(this.width, 2) + Math.Pow(this.height, 2));
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
            Console.WriteLine("Choose a figure type: ");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("4.Triangle");
            Console.Write("Input: ");

            int result = int.Parse(Console.ReadLine());

            Console.Write("Choose 1 for the area or 2 for the perimeter: ");
            int operation = int.Parse(Console.ReadLine());


            float width;
            float height;
            float radius;

            switch (result)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    radius = float.Parse(Console.ReadLine());

                    Circle circle = new Circle(radius);

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine(circle.Area());
                            break;

                        case 2:
                            Console.WriteLine(circle.Perimeter());
                            break;
                    }
                    break;

                case 2:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    height = float.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(width, height);

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine(rectangle.Area());
                            break;

                        case 2:
                            Console.WriteLine(rectangle.Perimeter());
                            break;
                    }

                    break;

                case 3:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Square square = new Square(width);

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine(square.Area());
                            break;

                        case 2:
                            Console.WriteLine(square.Perimeter());
                            break;
                    }

                    break;

                case 4:

                    Console.Write("Enter width: ");
                    width = float.Parse(Console.ReadLine());

                    Console.Write("Enter height: ");
                    height = float.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(width, height);

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine(triangle.Area());
                            break;

                        case 2:
                            Console.WriteLine(triangle.Perimeter());
                            break;
                    }

                    break;
            }
        }
    }
}
