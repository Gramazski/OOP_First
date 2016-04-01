using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.DrawFigures
{
    public class DrawCircle : Drawer
    {
        public override void Display(Graphics canvas, Pen pen)
        {
            canvas.DrawEllipse(pen, (CurrFigure.Coordinate[0].X - (CurrFigure.Coordinate[0].X - CurrFigure.Coordinate[1].X) / 2), (CurrFigure.Coordinate[0].Y - (CurrFigure.Coordinate[0].Y - CurrFigure.Coordinate[1].Y) / 2), (int)(Math.Sqrt(Math.Pow(CurrFigure.Coordinate[0].X - CurrFigure.Coordinate[1].X, 2) + Math.Pow(CurrFigure.Coordinate[0].Y - CurrFigure.Coordinate[1].Y, 2)) / 2), (int)(Math.Sqrt(Math.Pow(CurrFigure.Coordinate[0].X - CurrFigure.Coordinate[1].X, 2) + Math.Pow(CurrFigure.Coordinate[0].Y - CurrFigure.Coordinate[1].Y, 2)) / 2));
        }
    }
}
