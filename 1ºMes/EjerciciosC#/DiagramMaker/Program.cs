using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    internal class Program
    {
        public static Diagram diagram = new Diagram();


        static void Main(string[] args)
        {
            AddFigureLoop();
            diagram.DisplayShapes();
            diagram.TotalArea();
            diagram.TotalPerimeter();

            Console.ReadKey();
        }


        static private void AddFigureLoop()
        {
            int result;

            do
            {
                Console.WriteLine("Choose a figure type to add to the diagram: ");
                Console.WriteLine("0.Stop adding figures");
                Console.WriteLine("1.Circle");
                Console.WriteLine("2.Rectangle");
                Console.WriteLine("3.Square");
                Console.WriteLine("4.Triangle");
                Console.Write("Input: ");

                result = int.Parse(Console.ReadLine());

                float width;
                float height;
                float radius;

                switch (result)
                {
                    case 1:
                        Console.Write("Enter radius: ");
                        radius = float.Parse(Console.ReadLine());

                        Circle circle = new Circle(radius);
                        diagram.AddShape(circle);
                        break;

                    case 2:

                        Console.Write("Enter width: ");
                        width = float.Parse(Console.ReadLine());

                        Console.Write("Enter height: ");
                        height = float.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(width, height);
                        diagram.AddShape(rectangle);
                        break;

                    case 3:

                        Console.Write("Enter width: ");
                        width = float.Parse(Console.ReadLine());

                        Square square = new Square(width);
                        diagram.AddShape(square);
                        break;

                    case 4:

                        Console.Write("Enter width: ");
                        width = float.Parse(Console.ReadLine());

                        Console.Write("Enter height: ");
                        height = float.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle(width, height);
                        diagram.AddShape(triangle);
                        break;
                }

                Console.WriteLine("");

            } while (result != 0);
        }
    }
}
