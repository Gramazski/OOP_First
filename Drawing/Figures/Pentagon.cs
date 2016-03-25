using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Pentagon : Figure
    {
        public override string ToString()
        {
            return "Pentagon";
        }

        public override void SetCoordinates(int X, int Y)
        {
            myPointArray[0] = new Point(X, Y);
            myPointArray[1] = new Point(X, Y + 60);
            myPointArray[2] = new Point(X + 60, Y);
            myPointArray[3] = new Point(X + 80, Y + 80);
            myPointArray[4] = new Point(X + 20, Y + 20);
        }
    }
}
