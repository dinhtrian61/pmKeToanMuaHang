namespace PurchaseAccounting.UI
{
    partial class LoginForm
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
            plogin = new Panel();
            linkdki = new LinkLabel();
            btdangki = new Button();
            btdangnhap = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbtieude = new Label();
            txtendn = new TextBox();
            this.txmk = new TextBox();
            plogin.SuspendLayout();
            SuspendLayout();
            // 
            // plogin
            // 
            plogin.BackColor = Color.FromArgb(244, 246, 247);
            plogin.BorderStyle = BorderStyle.FixedSingle;
            plogin.Controls.Add(this.txmk);
            plogin.Controls.Add(txtendn);
            plogin.Controls.Add(linkdki);
            plogin.Controls.Add(btdangki);
            plogin.Controls.Add(btdangnhap);
            plogin.Controls.Add(label4);
            plogin.Controls.Add(label3);
            plogin.Controls.Add(label2);
            plogin.Controls.Add(label1);
            plogin.Controls.Add(lbtieude);
            plogin.ForeColor = SystemColors.ControlText;
            plogin.Location = new Point(62, 24);
            plogin.Name = "plogin";
            plogin.Size = new Size(450, 320);
            plogin.TabIndex = 0;
            plogin.Paint += plogin_Paint;
            // 
            // linkdki
            // 
            linkdki.AutoSize = true;
            linkdki.Location = new Point(93, 269);
            linkdki.Name = "linkdki";
            linkdki.Size = new Size(256, 20);
            linkdki.TabIndex = 5;
            linkdki.TabStop = true;
            linkdki.Text = "Bạn chưa có tài khoản? Đăng ký ngay";
            // 
            // btdangki
            // 
            btdangki.BackColor = Color.SlateBlue;
            btdangki.FlatStyle = FlatStyle.Flat;
            btdangki.ForeColor = Color.White;
            btdangki.Location = new Point(240, 198);
            btdangki.Name = "btdangki";
            btdangki.Size = new Size(153, 37);
            btdangki.TabIndex = 4;
            btdangki.Text = "Đăng ký";
            btdangki.UseVisualStyleBackColor = false;
            // 
            // btdangnhap
            // 
            btdangnhap.BackColor = Color.CornflowerBlue;
            btdangnhap.FlatStyle = FlatStyle.Flat;
            btdangnhap.ForeColor = Color.White;
            btdangnhap.Location = new Point(43, 200);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(153, 37);
            btdangnhap.TabIndex = 4;
            btdangnhap.Text = "Đăng nhập";
            btdangnhap.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.CadetBlue;
            label4.Location = new Point(43, 256);
            label4.Name = "label4";
            label4.Size = new Size(354, 1);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.CadetBlue;
            label3.Location = new Point(43, 56);
            label3.Name = "label3";
            label3.Size = new Size(354, 1);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 86);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbtieude.ForeColor = Color.FromArgb(64, 64, 64);
            lbtieude.Location = new Point(141, 10);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(155, 32);
            lbtieude.TabIndex = 0;
            lbtieude.Text = "ĐĂNG NHẬP";
            lbtieude.Click += lbtieude_Click;
            // 
            // txtendn
            // 
            txtendn.Location = new Point(171, 83);
            txtendn.Name = "txtendn";
            txtendn.Size = new Size(222, 27);
            txtendn.TabIndex = 6;
            // 
            // txmk
            // 
            this.txmk.Location = new Point(171, 137);
            this.txmk.Name = "txmk";
            this.txmk.Size = new Size(222, 27);
            this.txmk.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(582, 370);
            Controls.Add(plogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            plogin.ResumeLayout(false);
            plogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plogin;
        private Label lbtieude;
        private Label label1;
        private TextBox txmk;
        private TextBox txtendn;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btdangnhap;
        private Button btdangki;
        private LinkLabel linkdki;
     
    }
}