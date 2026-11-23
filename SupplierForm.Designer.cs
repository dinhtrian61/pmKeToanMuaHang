namespace PurchaseAccounting.UI
{
    partial class SupplierForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txtmancc = new TextBox();
            txten = new TextBox();
            txtdiachi = new TextBox();
            txtsdt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            textBox6 = new TextBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            txtemail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_supplier_48;
            pictureBox1.InitialImage = Properties.Resources.icons8_supplier_48;
            pictureBox1.Location = new Point(30, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 43);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 580);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(231, 76, 60);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(316, 470);
            button3.Name = "button3";
            button3.Size = new Size(122, 43);
            button3.TabIndex = 2;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(172, 470);
            button2.Name = "button2";
            button2.Size = new Size(122, 43);
            button2.TabIndex = 2;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 470);
            button1.Name = "button1";
            button1.Size = new Size(122, 43);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtmancc);
            groupBox1.Controls.Add(txten);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtmancc
            // 
            txtmancc.Location = new Point(160, 50);
            txtmancc.Name = "txtmancc";
            txtmancc.Size = new Size(252, 30);
            txtmancc.TabIndex = 4;
            // 
            // txten
            // 
            txten.Location = new Point(160, 116);
            txten.Name = "txten";
            txten.Size = new Size(252, 30);
            txten.TabIndex = 3;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(158, 180);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(252, 30);
            txtdiachi.TabIndex = 2;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(158, 309);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(252, 30);
            txtsdt.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(21, 314);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 0;
            label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(21, 249);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(21, 184);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên nhà cung cấp:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(21, 56);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhà cung cấp:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(465, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 580);
            panel4.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(158, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 27);
            textBox6.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(472, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 580);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 30);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(0, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 467);
            dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 152, 219);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.icons8_find_24;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(371, 45);
            button4.Name = "button4";
            button4.Size = new Size(122, 30);
            button4.TabIndex = 2;
            button4.Text = "     Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(158, 244);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(252, 30);
            txtemail.TabIndex = 5;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 247);
            ClientSize = new Size(992, 636);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(52, 73, 94);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà cung cấp";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
      //private TextBox txmancc;
        private Label label2;
        private TextBox textBox5;
       //rivate TextBox text;
      //private TextBox txtdchi;
     // private TextBox txtenncc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private TextBox txtsdt;
        private TextBox txtmancc;
        private TextBox txten;
        private TextBox txtdiachi;
        private TextBox textBox1;
        private TextBox txtemail;
    }
}