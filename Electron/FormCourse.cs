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
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }

        private void Cours_Load(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.FirstName = textBoxFirstName.Text;
            course.MiddleName = textBoxMiddleName.Text;
            course.LastName = textBoxLastName.Text;
            course.Phone = textBoxPhone.Text;
            course.Email = textBoxEmail.Text;
            Program.elDb.Course.Add(course);
            Program.elDb.SaveChanges();
            MessageBox.Show("Запрос успешно отправлен, проверьте почту");
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
