using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace TextProcessor
{
    public partial class FormTextProcessor : Form
    {
        public FormTextProcessor()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                tbEditor.Text = File.ReadAllText(ofd.FileName,Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Error during the file opening.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(ofd.FileName, tbEditor.Text,Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Error during the file saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (tbEditor.Text == "")
                return;
            tbEditor.Text = tbEditor.Text.Replace(
                tbSearch.Text, tbReplace.Text);
        }
    }
}
