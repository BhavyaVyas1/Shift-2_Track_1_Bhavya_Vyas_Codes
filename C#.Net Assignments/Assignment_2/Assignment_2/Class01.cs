using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Demo01
{
    public class Run
    {
        public static void RunThis()
        {
            Rectangle Rect = new Rectangle(10, 20);
            Console.WriteLine("--- Rectangle");
            Console.WriteLine("Length: {0}, Breadth {1}", Rect.Length, Rect.Breadth);
            Console.WriteLine("Perimeter: {0}", Rect.Perimeter);
            Console.WriteLine("Area : {0}", Rect.Area());
            Console.WriteLine();

            Square s = new Square(50);
            Console.WriteLine("--- Square");
            Console.WriteLine("Side: {0}", s.Side);
            Console.WriteLine("Perimeter: {0}", s.Perimeter);
            Console.WriteLine("Area : {0}", s.Area());
            Console.WriteLine();

            Triangle t = new Triangle(10, 20, 30);
            Console.WriteLine("--- Triangle");
            Console.WriteLine("Triangle Base: {0}", t.TriangleBase);
            Console.WriteLine("Triangle Height: {0}", t.TraingleHeight);
            Console.WriteLine("Perimeter: {0}", t.Perimeter);
            Console.WriteLine("Area : {0}", t.Area());
            Console.WriteLine();

        }
    }
    abstract class GeometricSymbols
    {
        abstract public decimal Perimeter { get; }

        abstract public decimal Area();
    }

    class Triangle : GeometricSymbols
    {
        private int side1, side2, side3;

        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override decimal Perimeter
        {
            get
            {
                return this.side1 + this.side2 + this.side3;
            }
        }

        public int TriangleBase
        {
            get
            {
                return this.side1;
            }
        }

        public int TraingleHeight
        {
            get
            {
                return this.side2;
            }
        }

        public override decimal Area()
        {
            // return 0.00M;

            return (this.TriangleBase * this.TraingleHeight) / 2;
        }
    }

    abstract class Quadrilateral : GeometricSymbols
    {
        protected int side1, side2, side3, side4;

        public override decimal Perimeter
        {
            get
            {
                return this.side1 + this.side2 + this.side3 + this.side4;
            }
        }

        public abstract override decimal Area();
    }

    class Square : Quadrilateral
    {
        public Square(int side)
        {
            base.side1 = base.side2 = base.side3 = base.side4 = side;
        }

        public int Side
        {
            get
            {
                return base.side1;
            }
        }

        public override decimal Area()
        {
            return this.Side * this.Side;
        }
    }

    class Rectangle : Quadrilateral
    {
        public Rectangle(int length, int breadth)
        {
            base.side1 = base.side3 = length;
            base.side2 = base.side4 = breadth;
        }

        public int Length
        {
            get
            {
                return base.side1;
            }
        }

        public int Breadth
        {
            get
            {
                return base.side2;
            }
        }

        public override decimal Area()
        {
            return this.Length * this.Breadth;
        }
    }
}
