using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12Months
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowMonthPicture();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowMonthPicture();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = (monthCalendar.Visible)?false:true;
        }
        private void ShowMonthPicture()
        {
            string month;
            try
            {
                month = monthCalendar.SelectionStart.Month.ToString();
                pictureBox.Image = Image.FromFile("Images\\" + month + ".jpg");
            }
            catch
            {
                MessageBox.Show("File with pictures not found");
                Application.Exit();
                this.Close();
            }
        }
    }
}
