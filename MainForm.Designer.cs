namespace PurchaseAccounting.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlmenu = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btdxuat = new Button();
            button7 = new Button();
            this.btbcao = new Button();
            this.btno = new Button();
            this.btphieu = new Button();
            this.btncc = new Button();
            btmenu = new Button();
            pnlmain = new Panel();
            pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = Color.FromArgb(52, 73, 94);
            pnlmenu.Controls.Add(pictureBox1);
            pnlmenu.Controls.Add(label3);
            pnlmenu.Controls.Add(btdxuat);
            pnlmenu.Controls.Add(button7);
            pnlmenu.Controls.Add(this.btbcao);
            pnlmenu.Controls.Add(this.btno);
            pnlmenu.Controls.Add(this.btphieu);
            pnlmenu.Controls.Add(this.btncc);
            pnlmenu.Controls.Add(btmenu);
            pnlmenu.Dock = DockStyle.Left;
            pnlmenu.Location = new Point(0, 0);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(200, 553);
            pnlmenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_logout_26;
            pictureBox1.Location = new Point(154, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 29);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.CadetBlue;
            label3.Location = new Point(30, 304);
            label3.Name = "label3";
            label3.Size = new Size(150, 1);
            label3.TabIndex = 8;
            // 
            // btdxuat
            // 
            btdxuat.FlatAppearance.BorderColor = Color.White;
            btdxuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            btdxuat.FlatStyle = FlatStyle.Flat;
            btdxuat.Font = new Font("Segoe UI", 10F);
            btdxuat.ForeColor = Color.White;
            btdxuat.ImageAlign = ContentAlignment.MiddleRight;
            btdxuat.Location = new Point(0, 411);
            btdxuat.Name = "btdxuat";
            btdxuat.Size = new Size(200, 50);
            btdxuat.TabIndex = 7;
            btdxuat.Text = "Đăng xuất";
            btdxuat.UseVisualStyleBackColor = true;
            btdxuat.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 361);
            button7.Name = "button7";
            button7.Size = new Size(200, 50);
            button7.TabIndex = 7;
            button7.Text = "Người dùng (Admin)";
            button7.UseVisualStyleBackColor = true;
            // 
            // btbcao
            // 
            this.btbcao.Dock = DockStyle.Top;
            this.btbcao.FlatAppearance.BorderColor = Color.White;
            this.btbcao.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            this.btbcao.FlatStyle = FlatStyle.Flat;
            this.btbcao.Font = new Font("Segoe UI", 10F);
            this.btbcao.ForeColor = Color.White;
            this.btbcao.Location = new Point(0, 200);
            this.btbcao.Name = "btbcao";
            this.btbcao.Size = new Size(200, 50);
            this.btbcao.TabIndex = 5;
            this.btbcao.Text = "Báo cáo nhập hàng";
            this.btbcao.UseVisualStyleBackColor = true;
            // 
            // btno
            // 
            this.btno.Dock = DockStyle.Top;
            this.btno.FlatAppearance.BorderColor = Color.White;
            this.btno.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            this.btno.FlatStyle = FlatStyle.Flat;
            this.btno.Font = new Font("Segoe UI", 10F);
            this.btno.ForeColor = Color.White;
            this.btno.Location = new Point(0, 150);
            this.btno.Name = "btno";
            this.btno.Size = new Size(200, 50);
            this.btno.TabIndex = 4;
            this.btno.Text = "Công nợ phải trả";
            this.btno.UseVisualStyleBackColor = true;
            // 
            // btphieu
            // 
            this.btphieu.Dock = DockStyle.Top;
            this.btphieu.FlatAppearance.BorderColor = Color.White;
            this.btphieu.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            this.btphieu.FlatStyle = FlatStyle.Flat;
            this.btphieu.Font = new Font("Segoe UI", 10F);
            this.btphieu.ForeColor = Color.White;
            this.btphieu.Location = new Point(0, 100);
            this.btphieu.Name = "btphieu";
            this.btphieu.Size = new Size(200, 50);
            this.btphieu.TabIndex = 3;
            this.btphieu.Text = "Phiếu nhập hàng";
            this.btphieu.UseVisualStyleBackColor = true;
            // 
            // btncc
            // 
            this.btncc.Dock = DockStyle.Top;
            this.btncc.FlatAppearance.BorderColor = Color.White;
            this.btncc.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            this.btncc.FlatStyle = FlatStyle.Flat;
            this.btncc.Font = new Font("Segoe UI", 10F);
            this.btncc.ForeColor = Color.White;
            this.btncc.Location = new Point(0, 50);
            this.btncc.Name = "btncc";
            this.btncc.Size = new Size(200, 50);
            this.btncc.TabIndex = 1;
            this.btncc.Text = "Nhà cung cấp";
            this.btncc.UseVisualStyleBackColor = true;
            // 
            // btmenu
            // 
            btmenu.Dock = DockStyle.Top;
            btmenu.FlatAppearance.BorderColor = Color.White;
            btmenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 110);
            btmenu.FlatStyle = FlatStyle.Flat;
            btmenu.Font = new Font("Segoe UI", 10F);
            btmenu.ForeColor = Color.White;
            btmenu.Image = (Image)resources.GetObject("btmenu.Image");
            btmenu.ImageAlign = ContentAlignment.MiddleLeft;
            btmenu.Location = new Point(0, 0);
            btmenu.Name = "btmenu";
            btmenu.Size = new Size(200, 50);
            btmenu.TabIndex = 0;
            btmenu.Text = "TRANG CHỦ";
            btmenu.UseVisualStyleBackColor = true;
            // 
            // pnlmain
            // 
            pnlmain.BackColor = Color.FromArgb(244, 246, 247);
            pnlmain.Dock = DockStyle.Fill;
            pnlmain.Location = new Point(200, 0);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(782, 553);
            pnlmain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlmain);
            Controls.Add(pnlmenu);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += MainForm_Load;
            pnlmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlmenu;
        private Button btmenu;
        private Panel pnlmain;
        private Button btncc;
        private Button btphieu;
        private Button btno;
        private Button btbcao;
        private Button btdxuat;
        private Button button7;
        private Label label3;
        private PictureBox pictureBox1;
    }
}