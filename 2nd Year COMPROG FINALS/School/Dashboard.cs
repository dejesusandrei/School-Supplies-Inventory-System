using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Dashboard : Form
    {
        public Dashboard() // PARA PWEDE MA CALL SA IBANG FORMS
        {
            InitializeComponent();

            dataGridView1.DataSource = Products.itemTable; // Display products in DataGridView

            lblTotalItem.Text = Products.itemTable.Rows.Count.ToString(); // Display total number of items

            lblTotalCateg.Text = Category.categoryTable.Rows.Count.ToString(); // Display total number of categories


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
        }

        private void lblProducts_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Products productsForm = new Products();
            productsForm.ShowDialog();
        }

        private void lblCategory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category categoryForm = new Category();
            categoryForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // LOGOUT
            DialogResult exitChoice = MessageBox.Show("Are you sure do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitChoice == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.ShowDialog();
            }
            else
            {
                return; // to stop the function here
            }
        }

    }
}
