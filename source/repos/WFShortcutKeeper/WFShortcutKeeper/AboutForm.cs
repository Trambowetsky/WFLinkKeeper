using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFShortcutKeeper
{
    public partial class AboutForm : Form
    {
        public AboutForm(CutsForm form)
        {
            InitializeComponent();
            cutsForm = form;
        }
        CutsForm cutsForm;
        Point lastPoint;
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            cutsForm.Enabled = true;
            cutsForm.Show();
            this.Dispose();
        }

        private void LinkedInPicBox_Click(object sender, EventArgs e) => Process.Start("https://www.linkedin.com/in/trambovetskyi-oleksandr/");

        private void PictureBox1_Click(object sender, EventArgs e) => Process.Start("https://github.com/Trambowetsky");

        private void HeadingPanel_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void HeadingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
