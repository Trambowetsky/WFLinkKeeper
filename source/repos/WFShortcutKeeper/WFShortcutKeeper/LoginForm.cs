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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        readonly string key = "trambovetsky";
        CutsForm main;
        private void HeadingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void HeadingPanel_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            LoadingPic.Visible = true;
            string userLogin = loginBox.Text;
            string userPass = passBox.Text;
            bool successfulLog = false;
            
            await Task.Run(() => LoginMethod(userLogin, userPass, ref successfulLog));
            LoadingPic.Visible = false;
            if (successfulLog)
            {
                MessageBox.Show("Ви увійшли у систему");
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неправильний логін або пароль");
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegUserForm regForm = new RegUserForm();
            regForm.Show();
        }

        private void SuccessfulLogin(User user, ref bool succ)
        {

            succ = true;
            main = new CutsForm(user);
        }
        private void LoginMethod(string userLogin, string userPass, ref bool successfulLog)
        {
            if (loginBox.Text == "" || passBox.Text == "")
                MessageBox.Show("Ви не заповнили поля для авторизації");
            using (EFDbContext db = new EFDbContext())
            {
                foreach (var user in db.Users)
                {
                    if (user.UserName.Equals(CypherClass.XORCipher(userLogin, key)) && user.PassWord.Equals(CypherClass.XORCipher(userPass, key)))
                    {
                        SuccessfulLogin(user, ref successfulLog);
                        break;
                    }
                }
               
            }
        }
    }
}
