using System;
using System.Drawing;
using System.Windows.Forms;
using WFShortcutKeeper.Entities;

namespace WFShortcutKeeper
{
    public partial class AddShortcut : Form
    {
        public AddShortcut(User entryUser, CutsForm ctf)
        {
            InitializeComponent();
            user = entryUser;
            cutsform = ctf;
        }
        User user;
        CutsForm cutsform;
        Point lastPoint;
        string key = "trambovetsky";
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            cutsform.Enabled = true;
            cutsform.Show();

            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string link = linkbox.Text;
            string description = descbox.Text;

            using (EFDbContext db = new EFDbContext())
            {
                db.Shortcuts.Add(new Entities.Shortcut() { Link = CypherClass.XORCipher(link, key), Desc = CypherClass.XORCipher(description, key), UserId = user.Id});
                db.SaveChanges();
            }
            cutsform.Enabled = true;
            cutsform.Dispose();
            this.Hide();
            CutsForm cutsf = new CutsForm(user);
            cutsf.Show();
        }

        private void AddFormPanel_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);
        

        private void AddFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
