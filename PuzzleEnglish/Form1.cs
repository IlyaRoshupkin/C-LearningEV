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
        int curr = 0;

        public form()
        {
            InitializeComponent();
            dic = new Dictionary();
            ShowCard();
        }
        public void ShowCard()
        {
            if( dic.Image(curr) != "")
            picCard.Image = Image.FromFile(dic.Image(curr));
            lblEnglish.Text = dic.English(curr);
            lblRussian.Text = dic.Russian(curr);

            lblVideo.Visible = dic.Video(curr) != "" ;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (curr >= dic.Total() - 1) return;
            curr++;
            ShowCard();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (curr <= 0) return;
            curr--;
            ShowCard();
        }

        private void lblRussian_Click(object sender, EventArgs e)
        {
            playMp3(dic.AudioRus(curr));
        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {
            playMp3(dic.AudioEng(curr));
        }

        private void playMp3(string filename)
        {
            if (filename == "") return;
            player.Visible = false;
            player.URL = filename;
        }
        private void playMp4(string filename)
        {
            if (filename == "") return;
            player.Visible = true;
            player.uiMode = "none";
            player.URL = filename;
        }

        private void lblVideo_Click(object sender, EventArgs e)
        {
            playMp4(dic.Video(curr));
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                player.Visible = false;
        }

        private void player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            player.Visible = false;
            player.Ctlcontrols.stop();
        }
    }
}
