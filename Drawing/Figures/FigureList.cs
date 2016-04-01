using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Drawing.Figures
{
    class FigureList
    {
        public List<Figure> ListOf = new List<Figure>();
        private Figure OneFigure;

        public FigureList()
        {
            OneFigure = new Circle();
            OneFigure.Coordinate[0] = new Point(100, 100);
            ListOf.Add(OneFigure);
            OneFigure = new Rectangle();
            OneFigure.Coordinate[0] = new Point(20, 20);
            ListOf.Add(OneFigure);
            OneFigure = new Square();
            OneFigure.Coordinate[0] = new Point(200, 200);
            ListOf.Add(OneFigure);
            OneFigure = new Pentagon();
            OneFigure.Coordinate[0] = new Point(100, 20);
            OneFigure.Coordinate[1] = new Point(100, 80);
            OneFigure.Coordinate[2] = new Point(160, 20);
            OneFigure.Coordinate[3] = new Point(180, 100);
            OneFigure.Coordinate[4] = new Point(120, 40);
            ListOf.Add(OneFigure);
            OneFigure = new Triangle();
            OneFigure.Coordinate[0] = new Point(20, 200);
            OneFigure.Coordinate[1] = new Point(20, 260);
            OneFigure.Coordinate[2] = new Point(80, 200);
            ListOf.Add(OneFigure);
            OneFigure = new Line();
            OneFigure.Coordinate[0] = new Point(250, 250);
            ListOf.Add(OneFigure);
        }
    }
}
