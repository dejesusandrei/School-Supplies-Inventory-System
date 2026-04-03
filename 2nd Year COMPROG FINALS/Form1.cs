using System.Data;

namespace FINAL_EXAM_COMPROG_2
{
    public partial class Form1 : Form
    {
        public static DataTable dataTable = new DataTable();
        
        
        int rowIndex;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // DISABLED
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            // ENABLED
            btnAdd.Enabled = true;

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Course", typeof(string));

            int[] id = {1, 2, 3, 4, 5};
            string[] name = {"andrei", "marjea", "ian", "jane", "izy"};
            int[] age = {19, 19, 19, 21, 21};
            string[] course = {"BSIT", "BSIT", "BSIT" , "BSIT" , "BSIT" };

            for (int i = 0; i < id.Length; i++)
            {
                dataTable.Rows.Add(id[i], name[i], age[i], course[i]);
            }

            // ID
            for (int i = 0; i < id.Length; i++)
            {
                listBox1.Items.Add(id[i]);
            }

            // Name
            for (int i = 0; i < name.Length; i++)
            {
                listBox2.Items.Add(name[i]);
            }

            // Age
            for (int i = 0; i < age.Length; i++)
            {
                listBox3.Items.Add(age[i]);
            }

            // Course
            for (int i = 0; i < course.Length; i++)
            {
                listBox4.Items.Add(course[i]);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = false;

            // ENABLED
            btnDelete.Enabled=true;

            rowIndex = e.RowIndex;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ADD BUTTON
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;

            // ENABLED
            btnSave.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                listBox1.Items.RemoveAt(rowIndex);
                listBox2.Items.RemoveAt(rowIndex);
                listBox3.Items.RemoveAt(rowIndex);
                listBox4.Items.RemoveAt(rowIndex);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int inputID;
            string inputName;
            int inputAge;
            string inputCourse;

            // DISABLED
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill up the textboxes", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                inputID = Convert.ToInt32(textBox1.Text);
                inputName = textBox2.Text;
                inputAge = Convert.ToInt32(textBox3.Text);
                inputCourse = textBox4.Text;

                dataTable.Rows.Add(inputID, inputName, inputAge, inputCourse);

                // LISTBOX
                listBox1.Items.Add(inputID);
                listBox2.Items.Add(inputName);
                listBox3.Items.Add(inputAge);
                listBox4.Items.Add(inputCourse);

                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();

                // DSABLED
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;

                btnAdd.Enabled = true;

            }
        }
    }
}
