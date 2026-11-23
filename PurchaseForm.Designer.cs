namespace PurchaseAccounting.UI
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            colstt = new DataGridViewTextBoxColumn();
            colmasp = new DataGridViewComboBoxColumn();
            colsl = new DataGridViewTextBoxColumn();
            coldg = new DataGridViewTextBoxColumn();
            colttien = new DataGridViewTextBoxColumn();
            colxoa = new DataGridViewButtonColumn();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            label1.Text = "LẬP PHIẾU NHẬP HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(44, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 182);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(41, 49);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu nhập:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(43, 108);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhà cung cấp:";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(470, 49);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày lập phiếu:";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(472, 108);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã phiếu nhập:";
            label5.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(600, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(600, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 28);
            comboBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colstt, colmasp, colsl, coldg, colttien, colxoa });
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(44, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(901, 159);
            dataGridView1.TabIndex = 3;
            // 
            // colstt
            // 
            colstt.HeaderText = "STT";
            colstt.MinimumWidth = 6;
            colstt.Name = "colstt";
            // 
            // colmasp
            // 
            colmasp.HeaderText = "Mã sản phẩm";
            colmasp.MinimumWidth = 6;
            colmasp.Name = "colmasp";
            // 
            // colsl
            // 
            colsl.HeaderText = "Số lượng";
            colsl.MinimumWidth = 6;
            colsl.Name = "colsl";
            // 
            // coldg
            // 
            coldg.HeaderText = "Đơn giá";
            coldg.MinimumWidth = 6;
            coldg.Name = "coldg";
            // 
            // colttien
            // 
            colttien.HeaderText = "Thành tiền";
            colttien.MinimumWidth = 6;
            colttien.Name = "colttien";
            colttien.ReadOnly = true;
            // 
            // colxoa
            // 
            colxoa.HeaderText = "Xoá";
            colxoa.MinimumWidth = 6;
            colxoa.Name = "colxoa";
            colxoa.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(755, 470);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 1;
            label6.Text = "Tổng tiền:";
            label6.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(836, 470);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 1;
            label7.Text = "0";
            label7.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(44, 466);
            button1.Name = "button1";
            button1.Size = new Size(284, 29);
            button1.TabIndex = 4;
            button1.Text = "+ Thêm dòng sản phẩm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_save_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(300, 543);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 4;
            button2.Text = "     Lưu phiếu";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(231, 76, 60);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(483, 543);
            button3.Name = "button3";
            button3.Size = new Size(156, 50);
            button3.TabIndex = 5;
            button3.Text = "     Huỷ/ Reset";
            button3.UseVisualStyleBackColor = false;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 247);
            ClientSize = new Size(992, 636);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "PurchaseForm";
            Text = "Lập phiếu nhập hàng";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colstt;
        private DataGridViewComboBoxColumn colmasp;
        private DataGridViewTextBoxColumn colsl;
        private DataGridViewTextBoxColumn coldg;
        private DataGridViewTextBoxColumn colttien;
        private DataGridViewButtonColumn colxoa;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}