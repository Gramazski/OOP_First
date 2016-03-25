using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Figure
    {
        public Point Coordinates = new Point(0, 0);
        public Point[] myPointArray = { new Point(), new Point(), new Point(), new Point(), new Point() };

        public virtual void SetCoordinates(int X, int Y)
        {
            Coordinates = new Point(X, Y);
        }
    }
}
