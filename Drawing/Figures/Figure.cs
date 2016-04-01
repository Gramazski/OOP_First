using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Figure
    {
        protected Point[] Coordinates = { new Point(0, 0), new Point(0, 0) };

        public virtual Point[] Coordinate
        {
            get { return Coordinates; }

            set
            {
                Coordinates = value;
            }
        }
    }
}
