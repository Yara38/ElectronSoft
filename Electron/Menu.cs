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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labelHello.Text = "Здравствуй, " + FormLogin.users.login + "!";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenProduct_Click(object sender, EventArgs e)
        {
            Form Product = new FormProduct();
            Product.Show();
        }

        private void buttonOpenCours_Click(object sender, EventArgs e)
        {
            Form Cours = new FormCourse();
            Cours.Show();
        }

        private void buttonOpenContacts_Click(object sender, EventArgs e)
        {
            Form Contacts = new Contacts();
            Contacts.Show();
        }
    }
}
