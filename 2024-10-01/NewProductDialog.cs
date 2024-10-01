using System;
using System.Windows.Forms;

namespace _2024_10_01
{
    public partial class NewProductDialog : Form
    {
        public Product newProduct;
        public NewProductDialog()
        {
            InitializeComponent();
        }
        private void cancelButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
        private void okButton_Click(object sender, EventArgs e) => Ok();
        void Ok()
        {
            try
            {
                newProduct = new Product
                {
                    Name = nameField.Text,
                    Quantity = Convert.ToInt32(quantityField.Text),
                    Price = Convert.ToInt32(priceField.Text),
                };
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Error while parsing your input!", "Error");
            }
        }
        private void nameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) quantityField.Focus();
        }
        private void quantityField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) priceField.Focus();
        }
        private void priceField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Ok();
        }
    }
}
