namespace QLXuatNhapKhau
{
    partial class FormDanhMucNhanVien
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grid_NV = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.txt_TimKiemNV = new System.Windows.Forms.TextBox();
            this.cbo_PhongBanNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(280, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(256, 31);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Danh mục nhân viên";
            // 
            // grid_NV
            // 
            this.grid_NV.BackgroundColor = System.Drawing.Color.White;
            this.grid_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NV.Location = new System.Drawing.Point(12, 110);
            this.grid_NV.Name = "grid_NV";
            this.grid_NV.Size = new System.Drawing.Size(776, 330);
            this.grid_NV.TabIndex = 10;
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiemNV.Location = new System.Drawing.Point(542, 77);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(105, 27);
            this.btn_TimKiemNV.TabIndex = 8;
            this.btn_TimKiemNV.Text = "Tìm kiếm";
            this.btn_TimKiemNV.UseVisualStyleBackColor = false;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // txt_TimKiemNV
            // 
            this.txt_TimKiemNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemNV.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiemNV.Location = new System.Drawing.Point(12, 77);
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(344, 27);
            this.txt_TimKiemNV.TabIndex = 9;
            this.txt_TimKiemNV.Text = "Mã nhân viên hoặc tên nhân viên";
            this.txt_TimKiemNV.Enter += new System.EventHandler(this.txt_TimKiemNV_Enter);
            this.txt_TimKiemNV.Leave += new System.EventHandler(this.txt_TimKiemNV_Leave);
            // 
            // cbo_PhongBanNV
            // 
            this.cbo_PhongBanNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_PhongBanNV.FormattingEnabled = true;
            this.cbo_PhongBanNV.Items.AddRange(new object[] {
            "Phòng kế toán",
            "Phòng cung ứng",
            "Phòng kinh doanh"});
            this.cbo_PhongBanNV.Location = new System.Drawing.Point(362, 77);
            this.cbo_PhongBanNV.Name = "cbo_PhongBanNV";
            this.cbo_PhongBanNV.Size = new System.Drawing.Size(174, 27);
            this.cbo_PhongBanNV.TabIndex = 12;
            // 
            // DanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_PhongBanNV);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grid_NV);
            this.Controls.Add(this.btn_TimKiemNV);
            this.Controls.Add(this.txt_TimKiemNV);
            this.Name = "DanhMucNhanVien";
            this.Text = "DanhMucNhanVien";
            this.Load += new System.EventHandler(this.DanhMucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView grid_NV;
        private System.Windows.Forms.Button btn_TimKiemNV;
        private System.Windows.Forms.TextBox txt_TimKiemNV;
        private System.Windows.Forms.ComboBox cbo_PhongBanNV;
    }
}