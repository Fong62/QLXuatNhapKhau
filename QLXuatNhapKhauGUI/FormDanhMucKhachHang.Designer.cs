namespace QLXuatNhapKhau
{
    partial class FormDanhMucKhachHang
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
            this.grid_KH = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemKH = new System.Windows.Forms.Button();
            this.txt_TimKiemKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(280, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(276, 31);
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "Danh mục khách hàng";
            // 
            // grid_KH
            // 
            this.grid_KH.BackgroundColor = System.Drawing.Color.White;
            this.grid_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KH.Location = new System.Drawing.Point(12, 110);
            this.grid_KH.Name = "grid_KH";
            this.grid_KH.Size = new System.Drawing.Size(776, 330);
            this.grid_KH.TabIndex = 6;
            // 
            // btn_TimKiemKH
            // 
            this.btn_TimKiemKH.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiemKH.Location = new System.Drawing.Point(362, 77);
            this.btn_TimKiemKH.Name = "btn_TimKiemKH";
            this.btn_TimKiemKH.Size = new System.Drawing.Size(105, 27);
            this.btn_TimKiemKH.TabIndex = 4;
            this.btn_TimKiemKH.Text = "Tìm kiếm";
            this.btn_TimKiemKH.UseVisualStyleBackColor = false;
            this.btn_TimKiemKH.Click += new System.EventHandler(this.btn_TimKiemKH_Click);
            // 
            // txt_TimKiemKH
            // 
            this.txt_TimKiemKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemKH.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiemKH.Location = new System.Drawing.Point(12, 77);
            this.txt_TimKiemKH.Name = "txt_TimKiemKH";
            this.txt_TimKiemKH.Size = new System.Drawing.Size(344, 27);
            this.txt_TimKiemKH.TabIndex = 5;
            this.txt_TimKiemKH.Text = "Mã khách hàng hoặc tên khách hàng";
            this.txt_TimKiemKH.Enter += new System.EventHandler(this.txt_TimKiemKH_Enter);
            this.txt_TimKiemKH.Leave += new System.EventHandler(this.txt_TimKiemKH_Leave);
            // 
            // DanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grid_KH);
            this.Controls.Add(this.btn_TimKiemKH);
            this.Controls.Add(this.txt_TimKiemKH);
            this.Name = "DanhMucKhachHang";
            this.Text = "DanhMucKhachHang";
            this.Load += new System.EventHandler(this.DanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView grid_KH;
        private System.Windows.Forms.Button btn_TimKiemKH;
        private System.Windows.Forms.TextBox txt_TimKiemKH;
    }
}