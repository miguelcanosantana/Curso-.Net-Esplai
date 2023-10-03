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

        private Rectangle(float width, float height) : base (width, height)
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
        public Square(float width) : base(width) 
        {

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
        }
    }
}
