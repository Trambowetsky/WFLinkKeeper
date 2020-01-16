using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using WFShortcutKeeper.Entities;

namespace WFShortcutKeeper
{
    public partial class RegUserForm : Form
    {
        public RegUserForm()
        {
            InitializeComponent();
        }

        private void RegExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Point lastPoint;
        readonly string key = "trambovetsky";
        bool localcheck = false;
        private void HeadingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void HeadingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private async void RegButton_Click(object sender, EventArgs e)
        {
            LoadingPicBox.Visible = true;
            string userRegLog = loginRegBox.Text;
            string userRegPas = passRegBox.Text;

            await Task.Run(() => RegisterUser(userRegLog, userRegPas));
            LoadingPicBox.Visible = false;
            if (!localcheck)
                MessageBox.Show("Аккаунт успішно створено! Вітаємо");
            else
                MessageBox.Show("Аккаунт з таким логінем чи паролем вже існує");
        }
        private static void AddUser(User user, EFDbContext context)
        {
                context.Users.Add(user);
                context.SaveChanges();
               
        }
        private void RegisterUser(string userRegLog, string userRegPas)
        {
            using (EFDbContext db = new EFDbContext())
            {
                foreach (var exuser in db.Users)
                {
                    if (CypherClass.XORCipher(userRegLog, key) == exuser.UserName || CypherClass.XORCipher(userRegLog, key) == exuser.PassWord ||
                        CypherClass.XORCipher(userRegPas, key) == exuser.UserName || CypherClass.XORCipher(userRegPas, key) == exuser.PassWord)
                    {
                        localcheck = true;
                    }
                }
                if (!localcheck)
                {
                    if (db.Users.Count() == 0)
                    {
                        AddUser(new User() { UserName = CypherClass.XORCipher(userRegLog, key), PassWord = CypherClass.XORCipher(userRegPas, key), IsAdmin = true }, db);
                    }
                    else
                        AddUser(new User() { UserName = CypherClass.XORCipher(userRegLog, key), PassWord = CypherClass.XORCipher(userRegPas, key), IsAdmin = false }, db);
                }
            }
        }
    }
}
