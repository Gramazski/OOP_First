using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing.DrawFigures
{
    class DrawerList
    {
        public List<Drawer> ListOf = new List<Drawer>();
        private Drawer OneDrawer;

        public DrawerList()
        {
            ListOf.Add(new DrawCircle());
            ListOf.Add(new DrawRectangle());
            ListOf.Add(new DrawSquare());
            ListOf.Add(new DrawPentagon());
            ListOf.Add(new DrawTriangle());
            ListOf.Add(new DrawLine());
        }

    }
}
