using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Pentagon : Figure
    {
        protected Point[] myPointArray = { new Point(), new Point(), new Point(), new Point(), new Point() };

        public override Point[] Coordinate
        {
            get { return myPointArray; }

            set
            {
                myPointArray[0] = value[0];
                myPointArray[1].X = value[0].X;
                myPointArray[1].Y = value[0].Y + 40;
                myPointArray[2] = value[1];
                myPointArray[3].X = value[1].X - 40;
                myPointArray[3].Y = value[1].Y;
                myPointArray[4].X = value[1].X + 80;
                myPointArray[4].Y = value[1].Y + 80;
            }
        }
    }
}
