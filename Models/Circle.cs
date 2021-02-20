
using FigureArea.Exceptions;
using FigureArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea.Models
{
    public class Circle:IFigure
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            if (IsExist(radius))
            {
                Radius = radius;
            }
            else throw new FigureNotExistException();
        }

        public  double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public static double GetArea(int radius)
        {
            return Math.PI * radius * radius;
        }

        protected   bool IsExist(int Radius)
        {
            if (Radius > 0)
            {
                return true;
            }
            return false;
        }
    }
}

