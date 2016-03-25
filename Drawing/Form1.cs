using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Drawing.DrawFigures;
using Drawing.Figures;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public static Graphics canvas;
        public static Pen pen;
        public Figure Training;
        public Drawer TrainingPainter;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            canvas = Graphics.FromHwnd(pictureBox1.Handle);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            FigureList Figuress = new FigureList();
            DrawerList Drawers = new DrawerList();

            for (int i = 0; i < Figuress.ListOf.Count; i++)
            {
                Training = Figuress.ListOf[i];
                TrainingPainter = Drawers.ListOf[i];
                TrainingPainter.Set(Training);
                TrainingPainter.Display(canvas, pen);
            }
        }
    }
}
