namespace School
{
    partial class Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnSaveCateg = new Button();
            btnCancelCateg = new Button();
            btnDeleteCateg = new Button();
            btnAddCateg = new Button();
            btnEditCateg = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            lblCategory = new Label();
            lblProducts = new Label();
            lblDashboard = new Label();
            label8 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 10.2F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(285, 21);
            label3.Name = "label3";
            label3.Size = new Size(141, 19);
            label3.TabIndex = 9;
            label3.Text = "Category Name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.Location = new Point(538, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans", 10.2F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 7;
            label1.Text = "Category Id:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.Location = new Point(303, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 6;
            // 
            // btnSaveCateg
            // 
            btnSaveCateg.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            btnSaveCateg.Location = new Point(598, 27);
            btnSaveCateg.Name = "btnSaveCateg";
            btnSaveCateg.Size = new Size(142, 42);
            btnSaveCateg.TabIndex = 21;
            btnSaveCateg.Text = "SAVE";
            btnSaveCateg.UseVisualStyleBackColor = true;
            btnSaveCateg.Click += btnSaveCateg_Click;
            btnSaveCateg.MouseLeave += btnSaveCateg_MouseLeave;
            btnSaveCateg.MouseHover += btnSaveCateg_MouseHover;
            // 
            // btnCancelCateg
            // 
            btnCancelCateg.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            btnCancelCateg.Location = new Point(755, 27);
            btnCancelCateg.Name = "btnCancelCateg";
            btnCancelCateg.Size = new Size(142, 42);
            btnCancelCateg.TabIndex = 20;
            btnCancelCateg.Text = "CANCEL";
            btnCancelCateg.UseVisualStyleBackColor = true;
            btnCancelCateg.Click += btnCancelCateg_Click;
            btnCancelCateg.MouseLeave += btnCancelCateg_MouseLeave;
            btnCancelCateg.MouseHover += btnCancelCateg_MouseHover;
            // 
            // btnDeleteCateg
            // 
            btnDeleteCateg.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            btnDeleteCateg.Location = new Point(978, 626);
            btnDeleteCateg.Name = "btnDeleteCateg";
            btnDeleteCateg.Size = new Size(151, 42);
            btnDeleteCateg.TabIndex = 19;
            btnDeleteCateg.Text = "DELETE";
            btnDeleteCateg.UseVisualStyleBackColor = true;
            btnDeleteCateg.Click += btnDeleteCateg_Click;
            btnDeleteCateg.MouseLeave += btnDeleteCateg_MouseLeave;
            btnDeleteCateg.MouseHover += btnDeleteCateg_MouseHover;
            // 
            // btnAddCateg
            // 
            btnAddCateg.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            btnAddCateg.Location = new Point(763, 626);
            btnAddCateg.Name = "btnAddCateg";
            btnAddCateg.Size = new Size(194, 42);
            btnAddCateg.TabIndex = 18;
            btnAddCateg.Text = "ADD PRODUCT";
            btnAddCateg.UseVisualStyleBackColor = true;
            btnAddCateg.Click += btnAddCateg_Click;
            btnAddCateg.MouseLeave += btnAddCateg_MouseLeave;
            btnAddCateg.MouseHover += btnAddCateg_MouseHover;
            // 
            // btnEditCateg
            // 
            btnEditCateg.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            btnEditCateg.Location = new Point(592, 626);
            btnEditCateg.Name = "btnEditCateg";
            btnEditCateg.Size = new Size(151, 42);
            btnEditCateg.TabIndex = 17;
            btnEditCateg.Text = "EDIT";
            btnEditCateg.UseVisualStyleBackColor = true;
            btnEditCateg.Click += btnEditCateg_Click;
            btnEditCateg.MouseLeave += btnEditCateg_MouseLeave;
            btnEditCateg.MouseHover += btnEditCateg_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(825, 316);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(209, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 45);
            panel2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(226, 8);
            label2.Name = "label2";
            label2.Size = new Size(545, 26);
            label2.TabIndex = 3;
            label2.Text = "SCHOOL SUPPLIES INVENTORY ITEMS SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(lblProducts);
            panel1.Controls.Add(lblDashboard);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 854);
            panel1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(35, 322);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 3;
            label4.Text = "➜] Logout";
            label4.Click += label4_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            lblCategory.ForeColor = Color.WhiteSmoke;
            lblCategory.Location = new Point(35, 284);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(124, 21);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "🗂️ Category";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            lblProducts.ForeColor = Color.WhiteSmoke;
            lblProducts.Location = new Point(35, 242);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(120, 21);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "📦 Products";
            lblProducts.Click += lblProducts_Click_1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Lucida Sans", 10.8F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.WhiteSmoke;
            lblDashboard.Location = new Point(35, 204);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(139, 21);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "📊 Dashboard";
            lblDashboard.Click += lblDashboard_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(576, 87);
            label8.Name = "label8";
            label8.Size = new Size(274, 26);
            label8.TabIndex = 28;
            label8.Text = "Category Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(btnCancelCateg);
            panel3.Controls.Add(btnSaveCateg);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(253, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(927, 460);
            panel3.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(8, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 190);
            panel5.TabIndex = 6;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1217, 693);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnDeleteCateg);
            Controls.Add(btnAddCateg);
            Controls.Add(btnEditCateg);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Name = "Category";
            Text = "Category";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button btnSaveCateg;
        private Button btnCancelCateg;
        private Button btnDeleteCateg;
        private Button btnAddCateg;
        private Button btnEditCateg;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label lblCategory;
        private Label lblProducts;
        private Label lblDashboard;
        private Label label4;
        private Label label8;
        private Panel panel3;
        private Panel panel5;
    }
}