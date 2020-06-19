using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void btnPassword1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((string)((Button)sender).Tag);
            ((Button)sender).BackColor = ((Button)sender).BackColor == Color.Red ? Color.Empty : Color.Red;
        }

        private void llSite1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void tbLogin1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((TextBox)sender).Text);
            ((TextBox)sender).SelectAll();
        }
    }
}
