using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea.Exceptions
{
    public class FigureNotExistException:Exception
    {
        public FigureNotExistException()
        : base("Triangle does not exist")
        { }
    }
}
