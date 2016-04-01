using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Drawing.DrawFigures;
using Drawing.Figures;

namespace Drawing
{
    class Painter
    {
        protected Dictionary<Type, Drawer> DrawerClass =
            new Dictionary<Type, Drawer>();

        public Painter()
        {
            DrawerClass.Add(typeof(Circle), new DrawCircle());
            DrawerClass.Add(typeof(Rectangle), new DrawRectangle());
            DrawerClass.Add(typeof(Square), new DrawSquare());
            DrawerClass.Add(typeof(Triangle), new DrawTriangle());
            DrawerClass.Add(typeof(Line), new DrawLine());
            DrawerClass.Add(typeof(Pentagon), new DrawPentagon());
        }

        public Drawer GetDrawerClass(Figure SomeFigure)
        {
            return DrawerClass[SomeFigure.GetType()];
        }
    }
}
