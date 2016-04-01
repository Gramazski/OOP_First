using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.DrawFigures
{
    public class DrawTriangle : Drawer
    {
        public override void Display(Graphics canvas, Pen pen)
        {
            canvas.DrawPolygon(pen, CurrFigure.Coordinate);
        }
    }
}
