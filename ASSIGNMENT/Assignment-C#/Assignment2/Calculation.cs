using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Calculation
{
    public class Calculation
    {
        public static void Calcu()
        {
            Rectangle objRect = new Rectangle(10, 20);
            Console.WriteLine("Rectangle");
            Console.WriteLine("Length : {0} , Breadth {1}", objRect.Length, objRect.Breadth);
            Console.WriteLine("Perimeter: {0}", objRect.Perimeter);
            Console.WriteLine("Area: {0}", objRect.Area);
            Console.WriteLine();

            Square squre = new Square(30);

        }
    }

    abstract class Geometric
    {
        abstract  public  decimal Perimeter { get;  }

        abstract public decimal  Area(); 
    }

    class Triange : Geometric
    {
        private int side1,side2,side3;

        public Triange(int side1,int side2,int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override decimal Perimeter
        {
            get
            {
                return side1 + side2 + side3;
            }
        }
        public override decimal Area()
        {
            return side2;
        }

    }

     abstract class Quadrilateral : Geometric
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
        public  int Breadth
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
