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
            canvas.DrawLine(pen, CurrFigure.Coordinate[0].X, CurrFigure.Coordinate[0].Y, CurrFigure.Coordinate[1].X, CurrFigure.Coordinate[1].Y);
        }
    }
}
