using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing.Figures
{
    class FigureList
    {
        public List<Figure> ListOf = new List<Figure>();
        private Figure OneFigure;

        public FigureList()
        {
            OneFigure = new Circle();
            OneFigure.SetCoordinates(100, 100);
            ListOf.Add(OneFigure);
            OneFigure = new Rectangle();
            OneFigure.SetCoordinates(20, 20);
            ListOf.Add(OneFigure);
            OneFigure = new Square();
            OneFigure.SetCoordinates(200, 200);
            ListOf.Add(OneFigure);
            OneFigure = new Pentagon();
            OneFigure.SetCoordinates(100, 20);
            ListOf.Add(OneFigure);
            OneFigure = new Triangle();
            OneFigure.SetCoordinates(20, 200);
            ListOf.Add(OneFigure);
            OneFigure = new Line();
            OneFigure.SetCoordinates(250, 250);
            ListOf.Add(OneFigure);
        }
    }
}
