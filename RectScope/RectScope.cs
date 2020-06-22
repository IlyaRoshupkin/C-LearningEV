using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectScope
{
    public partial class RectScope : Form
    {
        int w, h;
        Box[,] box ;

        public RectScope()
        {
            InitializeComponent();
            Init();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Box.ChoiseFigure();
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    box[i, j].DrawFigure();
        }

        void Init()
        {
            
            Box.SetSize(panel1.Width, panel1.Height);
            
            w = panel.Width / panel1.Width;
            h = panel.Height / panel1.Height;
            box = new Box[w, h];
            int sx, sy;
            for (int i = 0; i < w; i++)
                for(int j = 0; j < h; j++)
                {
                    Panel cell = new Panel();
                    cell.Parent = panel;
                    cell.Location = new Point(i*panel1.Width, j*panel1.Height);
                    cell.Size = new Size(panel1.Width, panel1.Height);
                    sx = (i % 2 == 1) ? -1 : 1;
                    sy = (j % 2 == 1) ? -1 : 1;
                    box[i, j] = new Box(cell, sx, sy);
                }
        }
    }
}
