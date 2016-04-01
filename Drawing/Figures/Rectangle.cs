﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Drawing.Figures
{
    public class Rectangle : Figure
    {
        protected Point[] myPointArray = { new Point(), new Point(), new Point(), new Point() };

        public override Point[] Coordinate
        {
            get { return myPointArray; }

            set
            {
                myPointArray[0] = value[0];
                myPointArray[1].X = value[0].X;
                myPointArray[1].Y = value[1].Y;
                myPointArray[2] = value[1];
                myPointArray[3].X = value[1].X;
                myPointArray[3].Y = value[0].Y;
            }
        }
    }
}
