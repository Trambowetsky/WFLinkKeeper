using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFShortcutKeeper
{
    public partial class EditSelectedLinkForm : Form
    {
        public EditSelectedLinkForm(CutsForm form, VisibleLinks selected, int userid)
        {
            InitializeComponent();
            cutsForm = form;
            selected_link = selected;
            id = userid;
        }
        CutsForm cutsForm;
        VisibleLinks selected_link;
        Entities.Shortcut selected_db;
        Point lastPoint;
        string key = "trambovetsky";
        int id;
        private void EditSelectedLinkForm_Load(object sender, EventArgs e)
        {
            UrlTextBox.Text = selected_link.URL;
            DescTextBox.Text = selected_link.Description;
            selected_link.URL = CypherClass.XORCipher(selected_link.URL, key);
            selected_link.Description = CypherClass.XORCipher(selected_link.Description, key);

            using (EFDbContext db = new EFDbContext())
                selected_db = db.Shortcuts.SingleOrDefault(cut => cut.Link == selected_link.URL && cut.UserId == id);
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            selected_link.Description = CypherClass.XORCipher(selected_link.Description, key);
            selected_link.URL = CypherClass.XORCipher(selected_link.URL, key);

            CloseForm();
        }

        private void EditSaveChangesBtn_Click(object sender, EventArgs e)
        {
            string url = UrlTextBox.Text, desc = DescTextBox.Text;

            selected_link.URL = url;
            selected_link.Description = desc;

            using (EFDbContext db = new EFDbContext())
            {
                var new_item = db.Shortcuts.SingleOrDefault(cut => cut.Link == selected_db.Link);
                
                new_item.Link = selected_link.URL;
                new_item.Desc = selected_link.Description;

                new_item.Link = CypherClass.XORCipher(new_item.Link, key);
                new_item.Desc = CypherClass.XORCipher(new_item.Desc, key);

                db.Entry(new_item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CloseForm();
        }
        private void CloseForm()
        {
            cutsForm.Enabled = true;
            cutsForm.Show();
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
}
