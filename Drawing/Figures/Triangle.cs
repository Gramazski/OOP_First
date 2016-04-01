using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Triangle : Figure
    {
        protected Point[] myPointArray = { new Point(), new Point(), new Point() };

        public override Point[] Coordinate
        {
            get { return myPointArray; }

            set
            {
                myPointArray[0] = value[0];
                myPointArray[1] = value[1];
                myPointArray[2].X = value[0].X - 20;
                myPointArray[2].Y = value[0].Y;
            }
        }
    }
}
