using System;
using System.IO;
using System.Windows.Forms;

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
                tbEditor.Text = File.ReadAllText(ofd.FileName);
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
                File.WriteAllText(ofd.FileName, tbEditor.Text);
            }
            catch
            {
                MessageBox.Show("Error during the file saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
