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
        public Color color;
        public Figure Training;
        public Drawer TrainingPainter;
        public bool MouseDown = false;
        public Point startCoord = new Point();
        public Point finishCoord = new Point();
        public Point[] figuresCoord = { new Point(), new Point() };
        public List<Figure> drawnFigures = new List<Figure>();

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            canvas = Graphics.FromHwnd(pictureBox1.Handle);
            canvas.Clear(Color.White);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            Training = new Triangle();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            startCoord.X = e.X;
            startCoord.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Painter SomePainter = new Painter();

            MouseDown = false;

            finishCoord.X = e.X;
            finishCoord.Y = e.Y;

            figuresCoord[0] = startCoord;
            figuresCoord[1] = finishCoord;

            Training.Coordinate = figuresCoord;
            TrainingPainter = SomePainter.GetDrawerClass(Training);
            TrainingPainter.Set(Training);
            TrainingPainter.Display(canvas, pen);

            drawnFigures.Add(Training);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Painter SomePainter = new Painter();
            //ОТОБРАЖЕНИЕ ТЕКУЩЕГО ПОЛОЖЕНИЯ ФИГУРЫ
            if (MouseDown)
            {
                pen = new Pen(Color.White, 1);

                TrainingPainter = SomePainter.GetDrawerClass(Training);
                TrainingPainter.Set(Training);
                TrainingPainter.Display(canvas, pen);

                pen = new Pen(Color.Black, 1);

                finishCoord.X = e.X;
                finishCoord.Y = e.Y;

                figuresCoord[0] = startCoord;
                figuresCoord[1] = finishCoord;

                Training.Coordinate = figuresCoord;
                TrainingPainter = SomePainter.GetDrawerClass(Training);
                TrainingPainter.Set(Training);
                TrainingPainter.Display(canvas, pen);
            }
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            Training = new Line();
        }

        private void pentagonButton_Click(object sender, EventArgs e)
        {
            Training = new Pentagon();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Training = new Square();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Training = new Figures.Rectangle();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Training = new Circle();
        }
    }
}
