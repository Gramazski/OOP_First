using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Drawing.Figures;
using System.Drawing;

namespace Drawing
{
    public class Drawer
    {
        protected Figure CurrFigure = new Figure();

        public void Set(Figure SomeObject)
        {
            CurrFigure = SomeObject;
        }

        public virtual void Display(Graphics canvas, Pen pen)
        {

        }
    }
}
