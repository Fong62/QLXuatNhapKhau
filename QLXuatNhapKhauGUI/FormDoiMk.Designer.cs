namespace QLXuatNhapKhauGUI
{
    partial class FormDoiMk
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
            label2 = new Label();
            textUserName = new TextBox();
            textMK = new TextBox();
            label3 = new Label();
            textXacNhanMK = new TextBox();
            label4 = new Label();
            buttonOK = new Button();
            buttonHuy = new Button();
            checkMK = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 104);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 155);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // textUserName
            // 
            textUserName.Enabled = false;
            textUserName.Location = new Point(229, 102);
            textUserName.Margin = new Padding(3, 2, 3, 2);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(140, 23);
            textUserName.TabIndex = 2;
            // 
            // textMK
            // 
            textMK.Location = new Point(229, 153);
            textMK.Margin = new Padding(3, 2, 3, 2);
            textMK.Name = "textMK";
            textMK.PasswordChar = '*';
            textMK.Size = new Size(140, 23);
            textMK.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 38);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 4;
            label3.Text = "Đổi mật khẩu";
            // 
            // textXacNhanMK
            // 
            textXacNhanMK.Location = new Point(229, 211);
            textXacNhanMK.Margin = new Padding(3, 2, 3, 2);
            textXacNhanMK.Name = "textXacNhanMK";
            textXacNhanMK.Size = new Size(140, 23);
            textXacNhanMK.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 214);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 5;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(180, 259);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(82, 51);
            buttonOK.TabIndex = 7;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Location = new Point(314, 259);
            buttonHuy.Margin = new Padding(3, 2, 3, 2);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(82, 51);
            buttonHuy.TabIndex = 8;
            buttonHuy.Text = "Hủy";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // checkMK
            // 
            checkMK.AutoSize = true;
            checkMK.Location = new Point(394, 155);
            checkMK.Margin = new Padding(3, 2, 3, 2);
            checkMK.Name = "checkMK";
            checkMK.Size = new Size(104, 19);
            checkMK.TabIndex = 9;
            checkMK.Text = "Hiện mật khẩu";
            checkMK.UseVisualStyleBackColor = true;
            checkMK.CheckedChanged += checkMK_CheckedChanged;
            // 
            // FormDoiMk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 345);
            Controls.Add(checkMK);
            Controls.Add(buttonHuy);
            Controls.Add(buttonOK);
            Controls.Add(textXacNhanMK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textMK);
            Controls.Add(textUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMk";
            Text = "FormDoiMk";
            Load += FormDoiMk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUserName;
        private TextBox textMK;
        private Label label3;
        private TextBox textXacNhanMK;
        private Label label4;
        private Button buttonOK;
        private Button buttonHuy;
        private CheckBox checkMK;
    }
}