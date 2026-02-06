namespace QLXuatNhapKhau
{
    partial class FormDanhMucHopDong
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
            txt_TimKiemHD = new TextBox();
            btn_TimKiemHD = new Button();
            grid_HD = new DataGridView();
            lbl_Title = new Label();
            ((System.ComponentModel.ISupportInitialize)grid_HD).BeginInit();
            SuspendLayout();
            // 
            // txt_TimKiemHD
            // 
            txt_TimKiemHD.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TimKiemHD.ForeColor = Color.Gray;
            txt_TimKiemHD.Location = new Point(14, 87);
            txt_TimKiemHD.Margin = new Padding(4, 3, 4, 3);
            txt_TimKiemHD.Name = "txt_TimKiemHD";
            txt_TimKiemHD.Size = new Size(401, 27);
            txt_TimKiemHD.TabIndex = 1;
            txt_TimKiemHD.Text = "Mã hợp đồng hoặc mã khách hàng";
            txt_TimKiemHD.Enter += txt_TimKiem_Enter;
            txt_TimKiemHD.Leave += txt_TimKiem_Leave;
            // 
            // btn_TimKiemHD
            // 
            btn_TimKiemHD.BackColor = SystemColors.Control;
            btn_TimKiemHD.Location = new Point(422, 87);
            btn_TimKiemHD.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiemHD.Name = "btn_TimKiemHD";
            btn_TimKiemHD.Size = new Size(122, 31);
            btn_TimKiemHD.TabIndex = 1;
            btn_TimKiemHD.Text = "Tìm kiếm";
            btn_TimKiemHD.UseVisualStyleBackColor = false;
            btn_TimKiemHD.Click += btn_TimKiem_Click;
            // 
            // grid_HD
            // 
            grid_HD.BackgroundColor = Color.White;
            grid_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_HD.Location = new Point(14, 125);
            grid_HD.Margin = new Padding(4, 3, 4, 3);
            grid_HD.Name = "grid_HD";
            grid_HD.Size = new Size(905, 381);
            grid_HD.TabIndex = 2;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(327, 10);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(250, 31);
            lbl_Title.TabIndex = 3;
            lbl_Title.Text = "Danh mục hợp đồng";
            // 
            // FormDanhMucHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lbl_Title);
            Controls.Add(grid_HD);
            Controls.Add(btn_TimKiemHD);
            Controls.Add(txt_TimKiemHD);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDanhMucHopDong";
            Text = "DanhMucHopDong";
            Load += DanhMucHopDong_Load;
            ((System.ComponentModel.ISupportInitialize)grid_HD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiemHD;
        private System.Windows.Forms.Button btn_TimKiemHD;
        private System.Windows.Forms.DataGridView grid_HD;
        private System.Windows.Forms.Label lbl_Title;
    }
}