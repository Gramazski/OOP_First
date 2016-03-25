using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.DrawFigures
{
    public class DrawSquare : Drawer
    {
        public override void Display(Graphics canvas, Pen pen)
        {
            canvas.DrawRectangle(pen, CurrFigure.Coordinates.X, CurrFigure.Coordinates.Y, 40, 40);
        }
    }
}
