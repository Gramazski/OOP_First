using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.DrawFigures
{
    public class DrawLine : Drawer
    {
        public override void Display(Graphics canvas, Pen pen)
        {
            canvas.DrawLine(pen, CurrFigure.Coordinates.X, CurrFigure.Coordinates.Y, CurrFigure.Coordinates.X + 50, CurrFigure.Coordinates.Y);
        }
    }
}
