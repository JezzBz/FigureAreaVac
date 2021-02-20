
using FigureArea.Exceptions;
using FigureArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureArea.Models
{
    public class Triangle:IFigure
    {
        public Triangle(int[] sides)
        {
            if (Triangle.IsExist(sides)) {
                Sides = sides;
               }
            else throw new FigureNotExistException();
        }
        public int[] Sides = new int[3];

        public bool IsRectangular()
        {

            int[] sides = this.Sides;
            Array.Sort(sides);

            if (sides[2] * sides[2] == (sides[0] * sides[0] + sides[1] * sides[1]))
            {
                return true;
            }

            return false;

        }


        public   double GetArea()
        {
            int a = this.Sides[0];
            int b = this.Sides[1];
            int c = this.Sides[2];
            double p = (double)(a + b + c) / 2;
            return (double)(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }


        protected static bool IsExist(int[] sides)
        {
            if (sides == null || !(sides.All<int>(x => x > 0) && sides.Length == 3))
            {
                return false;
            }
            int a = sides[0];
            int b = sides[1];
            int c = sides[2];
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }


            return false;
        }

    }
}
