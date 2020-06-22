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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.FirstName = textBoxFirstName.Text;
            product.MiddleName = textBoxMiddleName.Text;
            product.LastName = textBoxLastName.Text;
            product.Phone = textBoxPhone.Text;
            product.Email = textBoxEmail.Text;
            Program.elDb.Product.Add(product);
            Program.elDb.SaveChanges();
            MessageBox.Show("Товар успешно добавлен, проверьте почту");
        }
    }
}
