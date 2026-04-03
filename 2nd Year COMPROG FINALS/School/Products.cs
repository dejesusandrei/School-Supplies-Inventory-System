using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace School
{
    public partial class Products : Form
    {
        // GLOBAL VARIABLES FOR PRODUCTS
        public static DataTable itemTable = new DataTable();
        public static int itemID;
        public static string itemName = " ";
        public static string itemCateg = " ";
        public static double itemPrice;
        public static int itemStock;
        public static string itemManu = " ";
        int indexRow;

        static Products() // PURPOSE IS TO ACCESS SA IBANG FORM ang GRIDVIEW
        {
            // INITIALIZE COLUMNS FOR DATATABLE
            itemTable.Columns.Add("ID", typeof(int));
            itemTable.Columns.Add("Name", typeof(string));
            itemTable.Columns.Add("Category", typeof(string));
            itemTable.Columns.Add("Price", typeof(double));
            itemTable.Columns.Add("Stock", typeof(int));
            itemTable.Columns.Add("Manufacturer", typeof(string));
            itemTable.Rows.Add(1, "Pilot G-Tech C Gel Pen", "Ballpen", 80, 15, "PilotPh");
            itemTable.Rows.Add(2, "Cattleya Note", "Notebook", 50, 20, "Elmer'sPh");
            itemTable.Rows.Add(3, "Elmer's Glue", "Glue", 65, 13, "CattleyaPh");
            itemTable.Rows.Add(4, "Casio Fx-82 Plus", "Calculators", 1390, 8, "CasioPh");
            itemTable.Rows.Add(5, "Crayola 64 Colors", "Crayons", 120, 14, "CrayolaPh");
        }
        public Products()
        {
            InitializeComponent();
            dataGridView1.DataSource = itemTable;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // OFF LOAD DISABLE TEXTBOXES and BUTTONS SAVE AND CANCEL
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dataGridView1.Enabled = false;


            // 
            comboBox1.DataSource = Category.categoryTable;
            comboBox1.DisplayMember = "CName"; // Display the category name
            comboBox1.ValueMember = "CName"; // Use the category name as the value
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ADD BUTTON

            // DISABLE EDIT AND DELETE BUTTON
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView1.Enabled = false;
            // ENABLE TEXTBOXES FOR ADDING PRODUCT
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            comboBox1.DataSource = Category.categoryTable;
            comboBox1.DisplayMember = "CName";
            comboBox1.ValueMember = "CID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // CANCEL BUTTON

            // CLEAR TEXTBOXES
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            comboBox1.SelectedIndex = -1;

            // DISABLE TEXTBOXES AND SAVE AND CANCEL BUTTON
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dataGridView1.Enabled = false;

            // ENABLE ADD, EDIT AND DELETE BUTTON
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // EDIT BUTTON

            // DISABLE ADD AND DELETE BUTTON
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            // ENABLE TEXTBOXES FOR EDITING PRODUCT
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DELETE BUTTON
            // DISABLE ADD AND EDIT BUTTON
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // ENABLE TEXTBOXES FOR DELETING PRODUCT
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // SAVE BUTTON

            if (btnAdd.Enabled == true)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    // ADD PRODUCT
                    MessageBox.Show("Input Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Input Product Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select a Product Category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Input Product Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Input Product Stock.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Input Manufacturer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    itemID = (int)Convert.ToUInt32(textBox1.Text);
                    itemName = textBox2.Text;
                    itemCateg = comboBox1.Text.ToString();
                    itemPrice = Convert.ToDouble(textBox3.Text);
                    itemStock = (int)Convert.ToUInt32(textBox4.Text);
                    itemManu = textBox5.Text;
                    MessageBox.Show("Product added successfuly.", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemTable.Rows.Add(itemID, itemName, itemCateg, itemPrice, itemStock, itemManu);
                    textBox1.ResetText();
                    textBox2.ResetText();
                    textBox3.ResetText();
                    textBox4.ResetText();
                    textBox5.ResetText();
                    comboBox1.SelectedIndex = -1;

                }

            }
            else if (btnDelete.Enabled == true)
            {
                // DELETE PRODUCT

                DialogResult deleteChoice = MessageBox.Show("Are you sure do you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteChoice == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentCell != null)
                    {
                        int rowIndex = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("Product deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox1.ResetText();
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox3.ResetText();
                        textBox4.ResetText();
                        textBox5.ResetText();


                    }
                }
                else
                {
                    return;
                }

            }
            else
            {
                // UPDATE PRODUCT
                DataGridViewRow updateRow = dataGridView1.Rows[indexRow];

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Input Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Input Product Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select a Product Category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Input Product Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Input Product Stock.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Input Manufacturer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {


                    updateRow.Cells[0].Value = textBox1.Text;
                    updateRow.Cells[1].Value = textBox2.Text;
                    updateRow.Cells[2].Value = comboBox1.Text.ToString();
                    updateRow.Cells[3].Value = textBox3.Text;
                    updateRow.Cells[4].Value = textBox4.Text;
                    updateRow.Cells[5].Value = textBox5.Text;

                    MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.ResetText();
                    textBox2.ResetText();
                    textBox3.ResetText();
                    textBox4.ResetText();
                    textBox5.ResetText();
                    comboBox1.SelectedIndex = -1; // Reset comboBox selection
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DATA GRID VIEW CELL CLICK EVENT
            // yung e sa rowindex is the row na iclick mo sa gridview kumbaga events
            // e = Events
            // pag clinick mo si gridview lalabas sa textbox yung laman nung row na iclick mo
            indexRow = e.RowIndex;
            DataGridViewRow cellRow = dataGridView1.Rows[indexRow];
            textBox1.Text = cellRow.Cells[0].Value.ToString();
            textBox2.Text = cellRow.Cells[1].Value.ToString();
            comboBox1.Text = cellRow.Cells[2].Value.ToString();
            textBox3.Text = cellRow.Cells[3].Value.ToString();
            textBox4.Text = cellRow.Cells[4].Value.ToString();
            textBox5.Text = cellRow.Cells[5].Value.ToString();
        }


        private void lblDashboard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.ShowDialog();
        }

        private void lblCategory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Category categoryForm = new Category();
            categoryForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
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

        // HOVER NATO
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = Color.WhiteSmoke;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.ForeColor = Color.Black;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.WhiteSmoke;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.ForeColor = Color.Black;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Blue;
            btnEdit.ForeColor = Color.WhiteSmoke;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.WhiteSmoke;
            btnEdit.ForeColor = Color.Black;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.ForestGreen;
            btnSave.ForeColor = Color.WhiteSmoke;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.ForeColor = Color.Black;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.WhiteSmoke;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
