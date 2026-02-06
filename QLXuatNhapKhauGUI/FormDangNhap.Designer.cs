namespace QLXuatNhapKhau
{
    partial class FormDangNhap
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 95);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 198);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 278);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 205);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 282);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu :";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(427, 345);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 58);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(219, 345);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 58);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "OK";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(492, 278);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 506);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}