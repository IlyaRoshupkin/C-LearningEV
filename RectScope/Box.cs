using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectScope
{
    class Box
    {
        int sx = 1, sy = 1;
        static int width, height;
        Graphics graphics;
        static Random rnd = new Random();

        public enum Figure
        {
            line, circle
        };

        static Figure figure;
        static int x1line;  
        static int y1line;
        static int x2line;
        static int y2line;
        static Color color;

        static int xCircle;
        static int yCircle;
        static int rCircle;

        public void DrawFigure()
        {
            switch (figure)
            {
                case Figure.line:
                    DrawLine();
                    break;
                case Figure.circle:
                    DrawCircle();
                    break;
            }
        }

        private void DrawCircle()
        {
            Pen pen = new Pen(color);
            graphics.DrawEllipse(pen, ChangeX((int)(1.5 * xCircle)), ChangeY((int)(1.5 * yCircle)), rCircle, rCircle);
        }

        private void DrawLine()
        {
            Pen pen = new Pen(color);
            graphics.DrawLine(pen,ChangeX(x1line), ChangeY(y1line), ChangeX(x2line), ChangeY(y2line));
        }

        static public void SetSize(int _width,int _height)
        {
            width = _width;
            height = _height;
        }

        static public void ChoiseFigure()
        {
            int f = rnd.Next(0, Enum.GetValues(typeof(Figure)).Length);
            figure = (Figure)f;
            color = Color.FromArgb(
                rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            switch (figure)
            {
                case Figure.line:
                    x1line = rnd.Next(0, width);
                    y1line = rnd.Next(0, height);
                    x2line = rnd.Next(0, width);
                    y2line = rnd.Next(0, height);
                    break;
                case Figure.circle:
                    xCircle = rnd.Next(0, width);
                    yCircle = rnd.Next(0, height);
                    rCircle = rnd.Next(0, width / 4);
                    break;
            }
        }

        public Box(Panel panel, int sx, int sy)
        {
            this.sx = sx;
            this.sy = sy;
            graphics = panel.CreateGraphics();
        }

        private int ChangeX(int x)
        {
            return sx == 1 ? x : width - x;
        }
        private int ChangeY(int y)
        {
            return sy == 1 ? y : height - y;
        }
    }
}
