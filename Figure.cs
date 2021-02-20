using FigureArea.Interfaces;
using FigureArea.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Figure
    {
        public double GetArea(IFigure figure)
        {
            if (figure != null)
            {
                return figure.GetArea();
            }
            else throw new NullReferenceException();
        }
        
        
    }
}
