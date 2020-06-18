using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleEnglish
{
    public partial class form : Form
    {
        Dictionary dic;

        public form()
        {
            InitializeComponent();
            dic = new Dictionary();
            ShowCard(1);
        }
        public void ShowCard(int curr)
        {
            if( dic.Image(curr) != "")
            picCard.Image = Image.FromFile(dic.Image(curr));
            lblEnglish.Text = dic.English(curr);
            lblRussian.Text = dic.Russian(curr);

            lblVideo.Visible = dic.Video(curr) != "" ;
        }
    }
}
