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
    public partial class AdminForm : Form
    {
        BindingList<VisibleAccounts> accounts = new BindingList<VisibleAccounts>();
        readonly private int id;
        readonly private string key = "trambovetsky";
        CutsForm form;
        Point lastPoint;
        public AdminForm(int adminid, CutsForm cuts)
        {
            InitializeComponent();
            id = adminid;
            form = cuts;
        }

        private void AdmDeleteBtn_Click(object sender, EventArgs e)
        {
            var selected_cell = AdminDataGrid.CurrentCell.FormattedValue;
            var selected_acc = accounts.SingleOrDefault(x => x.UserName == selected_cell.ToString() || x.Password == selected_cell.ToString());
            foreach (DataGridViewCell dgvc in AdminDataGrid.SelectedCells)
            {
                if (dgvc.Selected == true)
                {
                    AdminDataGrid.Rows.RemoveAt(dgvc.RowIndex);
                    accounts.Remove(selected_acc);
                }
            }
            using (EFDbContext db = new EFDbContext())
            {
                foreach (var item in db.Users)
                {
                    if (item.UserName == CypherClass.XORCipher(selected_acc.UserName, key) || item.PassWord == CypherClass.XORCipher(selected_acc.Password, key))
                    {
                        var queryDeleteLinks = from links in db.Shortcuts
                                               where links.UserId == item.Id
                                               select links;

                        db.Shortcuts.RemoveRange(queryDeleteLinks);
                        db.Users.Remove(item);
                    }
                }
                db.SaveChanges();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (EFDbContext db = new EFDbContext())
            {
                foreach (var item in db.Users)
                {
                    if (item.Id != id)
                    {
                        item.PassWord = CypherClass.XORCipher(item.PassWord, key);
                        item.UserName = CypherClass.XORCipher(item.UserName, key);
                        accounts.Add(new VisibleAccounts() {UserName = item.UserName, Password = item.PassWord });
                    }
                }
            }
            AdminDataGrid.DataSource = accounts;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            form.Enabled = true;
            form.Show();
            this.Dispose();
        }

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
    public class VisibleAccounts
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
