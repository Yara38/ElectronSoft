using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Electron
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form Login= new FormLogin();
            Login.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLogin.Text) ||
                String.IsNullOrEmpty(textBoxPassword.Text) ||
                String.IsNullOrEmpty(richTextBoxEmail.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MailAddress fromAdress = new MailAddress("soft.electron@yandex.ru", "Electron");
            MailAddress toAdress = new MailAddress(richTextBoxEmail.Text, textBoxLogin.Text);
            MailMessage message = new MailMessage(fromAdress, toAdress);
            message.Subject = "Спасибо за регистрацию!";
            message.Body = "Логин: " + textBoxLogin.Text + "\nПароль: " + textBoxPassword.Text;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.yandex.ru";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "test123");
            smtpClient.Send(message);
            MessageBox.Show("Спасибо за регистрацию!");
            message.Body = "Логин: " + textBoxLogin.Text + "\nПароль: " + textBoxPassword.Text;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
