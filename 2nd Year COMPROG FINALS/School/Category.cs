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
    public partial class Category : Form
    {
        // GLOBAL VARIABLES FOR CATEGORY
        public static DataTable categoryTable = new DataTable();
        public static int categID;
        public static string categName = " ";
        int rowIndex;
        int indexRow;


        static Category() // para ma call sya sa ibang form
        {
            categoryTable.Columns.Add("CID", typeof(int));
            categoryTable.Columns.Add("CName", typeof(string));
            categoryTable.Rows.Add(1, "Pencils");
            categoryTable.Rows.Add(2, "Notebooks");
            categoryTable.Rows.Add(3, "Bond Papers");
            categoryTable.Rows.Add(4, "Ballpens");
            categoryTable.Rows.Add(5, "Yellow Papers");
            categoryTable.Rows.Add(6, "Markers");
            categoryTable.Rows.Add(7, "Calculators");
            categoryTable.Rows.Add(8, "Crayons");
            categoryTable.Rows.Add(9, "Glue");
            categoryTable.Rows.Add(10,"Scissors");
        }

        public Category()
        {
            InitializeComponent();
            dataGridView1.DataSource = categoryTable; // para ma display sa datagridview
        }

        private void Category_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            btnCancelCateg.Enabled = false;
            btnSaveCateg.Enabled = false;
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            // ADD BUTTON
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            btnCancelCateg.Enabled = true;
            btnSaveCateg.Enabled = true;

            // DISABLE EDIT AND DELETE BUTTON
            btnEditCateg.Enabled = false;
            btnDeleteCateg.Enabled = false;
            dataGridView1.Enabled = false;

        }

        private void btnEditCateg_Click(object sender, EventArgs e)
        {
            // EDIT BUTTON
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            btnCancelCateg.Enabled = true;
            btnSaveCateg.Enabled = true;
            dataGridView1.Enabled = true;
            // DISABLE ADD AND DELETE BUTTON
            btnAddCateg.Enabled = false;
            btnDeleteCateg.Enabled = false;
        }

        private void btnDeleteCateg_Click(object sender, EventArgs e)
        {
            // DELETE BUTTON
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            btnCancelCateg.Enabled = true;
            btnSaveCateg.Enabled = true;
            dataGridView1.Enabled = true;
            // DISABLE ADD AND EDIT BUTTON
            btnAddCateg.Enabled = false;
            btnEditCateg.Enabled = false;
        }

        private void btnCancelCateg_Click(object sender, EventArgs e)
        {
            // CANCEL BUTTON

            // CLEAR TEXTBOXES
            textBox1.ResetText();
            textBox2.ResetText();
            // ENABLE ADD, EDIT AND DELETE BUTTON
            btnAddCateg.Enabled = true;
            btnEditCateg.Enabled = true;
            btnDeleteCateg.Enabled = true;

            // DISABLE TEXTBOXES AND BUTTONS SAVE AND CANCEL
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            btnCancelCateg.Enabled = false;
            btnSaveCateg.Enabled = false;
        }

        private void btnSaveCateg_Click(object sender, EventArgs e)
        {
            // SAVE BUTTON
            if (btnAddCateg.Enabled == true)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Input a Category Id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // to stop the function here
                }
                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Input Category Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // to stop the function here
                }
                else
                {

                    categID = int.Parse(textBox1.Text);
                    categName = textBox2.Text;
                    categoryTable.Rows.Add(categID, categName);

                    // MESSAGE BOX
                    MessageBox.Show("Category Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.ResetText();
                    textBox2.ResetText();
                    

                }
            }
            else if (btnDeleteCateg.Enabled == true)
            {
                // DELETE FUNCTIONALITY
                DialogResult deleteChoice = MessageBox.Show("Are you sure do you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteChoice == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentCell != null)
                    {
                        rowIndex = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Category deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.ResetText();
                        textBox2.ResetText();
                    }
                }
                else
                {
                    return; // to stop the function here
                }
            }

            else
            {
                // EDIT FUNCTIONALITY

                // nag seselect ng row sa datagridview para ma edit yung mga value
                DataGridViewRow selectedCell = dataGridView1.Rows[indexRow];

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Input a Category Id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // to stop the function here
                }
                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Input Category Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // to stop the function here
                }
                else
                {
                   
                    selectedCell.Cells[0].Value = textBox1.Text;
                    selectedCell.Cells[1].Value = textBox2.Text;
                    MessageBox.Show("Category updated successfully.", "Updated Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.ResetText();
                    textBox2.ResetText();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // PAG CLINICK YUNG GRIDVIEW
            // e = Events
            indexRow = e.RowIndex;
            DataGridViewRow cellRow = dataGridView1.Rows[indexRow];
            textBox1.Text = cellRow.Cells[0].Value.ToString();
            textBox2.Text = cellRow.Cells[1].Value.ToString();

            btnAddCateg.Enabled = false;
            btnEditCateg.Enabled = true;
            btnDeleteCateg.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        private void lblDashboard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.ShowDialog();
        }

        private void lblProducts_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Products productsForm = new Products();
            productsForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
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

        // HOVER BUTTON na LAHAT TO

        private void btnDeleteCateg_MouseHover(object sender, EventArgs e)
        {
            btnDeleteCateg.BackColor = Color.Red;
            btnDeleteCateg.ForeColor = Color.WhiteSmoke;
        }

        private void btnDeleteCateg_MouseLeave(object sender, EventArgs e)
        {

            btnDeleteCateg.BackColor = Color.WhiteSmoke;
            btnDeleteCateg.ForeColor = Color.Black;
        }

        private void btnAddCateg_MouseHover(object sender, EventArgs e)
        {
            btnAddCateg.BackColor = Color.ForestGreen;
            btnAddCateg.ForeColor = Color.WhiteSmoke;
        }

        private void btnAddCateg_MouseLeave(object sender, EventArgs e)
        {
            btnAddCateg.BackColor = Color.WhiteSmoke;
            btnAddCateg.ForeColor = Color.Black;
        }

        private void btnEditCateg_MouseHover(object sender, EventArgs e)
        {
            btnEditCateg.BackColor = Color.Blue;
            btnEditCateg.ForeColor = Color.WhiteSmoke;
        }

        private void btnEditCateg_MouseLeave(object sender, EventArgs e)
        {
            btnEditCateg.BackColor = Color.WhiteSmoke;
            btnEditCateg.ForeColor = Color.Black;
        }

        private void btnCancelCateg_MouseHover(object sender, EventArgs e)
        {
            btnCancelCateg.BackColor = Color.Red;
            btnCancelCateg.ForeColor = Color.WhiteSmoke;
        }

        private void btnCancelCateg_MouseLeave(object sender, EventArgs e)
        {
            btnCancelCateg.BackColor = Color.WhiteSmoke;
            btnCancelCateg.ForeColor = Color.Black;
        }
    
        private void btnSaveCateg_MouseHover(object sender, EventArgs e)
        {
            btnSaveCateg.BackColor = Color.ForestGreen;
            btnSaveCateg.ForeColor = Color.WhiteSmoke;
        }

        private void btnSaveCateg_MouseLeave(object sender, EventArgs e)
        {
            btnSaveCateg.BackColor = Color.WhiteSmoke;
            btnSaveCateg.ForeColor = Color.Black;
        }
    }
}
