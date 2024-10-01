using System;
using System.Windows.Forms;

namespace _2024_10_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Database.OpenConnection();
            UpdateListBox();
        }
        void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Product product in Database.GetAllProducts()) listBox1.Items.Add(product);
        }
        private void newProductButton_Click(object sender, EventArgs e)
        {
            NewProductDialog dialog = new NewProductDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Database.AddProduct(dialog.newProduct);
                UpdateListBox();
            }
        }
        private void deleteSelectedButton_Click(object sender, EventArgs e) => DeleteSelected();
        void DeleteSelected()
        {
            if (listBox1.SelectedIndex != -1)
            {
                Database.DeleteById(((Product)listBox1.SelectedItem).Id);
                UpdateListBox();
            }
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteSelected();
        }
        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete everything?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Database.DeleteAll();
                UpdateListBox();
            }
        }
    }
}
