using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFShortcutKeeper.Entities;

namespace WFShortcutKeeper
{
    public partial class CutsForm : Form
    {
        public CutsForm(User entryUser)
        {
            InitializeComponent();
            user = entryUser;
        }
        BindingList<VisibleLinks> links = new BindingList<VisibleLinks>();
        readonly User user;
        EFDbContext db;
        readonly private string key = "trambovetsky";

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutsForm_Load(object sender, EventArgs e)
        {
            if (user.IsAdmin == true) AdmBtn.Visible = true;
            
            using (db = new EFDbContext())
            {
                foreach (var item in db.Shortcuts)
                {
                    if (item.UserId == user.Id)
                        links.Add(new VisibleLinks() { URL = CypherClass.XORCipher(item.Link, key), Description = CypherClass.XORCipher(item.Desc, key) });
                }
                shortcutsDataGrid.DataSource = links;
            }
        }
        Point lastPoint;
        private void MainFormPanel_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);
        
        private void MainFormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddShortcut ads = new AddShortcut(user, this);
            this.Enabled = false;
            ads.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var selected = shortcutsDataGrid.CurrentCell.FormattedValue;
            var selected_link = links.SingleOrDefault(x => x.URL == selected.ToString() || x.Description == selected.ToString());

            foreach (DataGridViewCell dgvc in shortcutsDataGrid.SelectedCells)
            {
                if (dgvc.Selected == true)
                {
                    shortcutsDataGrid.Rows.RemoveAt(dgvc.RowIndex);
                    links.Remove(selected_link);
                }
            }
            using (db = new EFDbContext())
            {
                foreach (var item in db.Shortcuts)
                {
                    if (item.Link == CypherClass.XORCipher(selected_link.URL, key) || item.Desc == CypherClass.XORCipher(selected_link.Description, key))
                        db.Shortcuts.Remove(item);
                }
                db.SaveChanges();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selected = shortcutsDataGrid.CurrentCell.FormattedValue;
            var selected_link = links.SingleOrDefault(x => x.URL == selected.ToString() || x.Description == selected.ToString());

            EditSelectedLinkForm eslf = new EditSelectedLinkForm(this, selected_link, user.Id);
            this.Enabled = false;
            eslf.Show();
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(this);
            this.Enabled = false;
            about.Show();
        }

        private void AdmBtn_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm(user.Id, this);
            this.Enabled = false;
            admin.Show();
        }
    }
    public class VisibleLinks
    {
        public string URL { get; set; }
        public string Description { get; set; }
    }

}
