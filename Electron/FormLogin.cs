using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electron
{
    public struct User
    {
        public string login;
        public string password;
    }
    public partial class FormLogin : Form
    {
        public static User users = new User();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Login user in Program.elDb.Login)
                {
                    if (textBoxLogin.Text == user.Login1 && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login1;
                        users.password = user.Password;

                    }
                }
                if (!key)
                {
                    MessageBox.Show("Неверный логин или пароль", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
