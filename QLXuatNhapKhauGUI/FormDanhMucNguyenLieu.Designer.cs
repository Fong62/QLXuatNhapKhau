namespace QLXuatNhapKhau
{
    partial class FormDanhMucNguyenLieu
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
            this.grid_NL = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemNL = new System.Windows.Forms.Button();
            this.txt_TimKiemNL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NL)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(280, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(274, 31);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Danh mục nguyên liệu";
            // 
            // grid_NL
            // 
            this.grid_NL.BackgroundColor = System.Drawing.Color.White;
            this.grid_NL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NL.Location = new System.Drawing.Point(12, 110);
            this.grid_NL.Name = "grid_NL";
            this.grid_NL.Size = new System.Drawing.Size(776, 330);
            this.grid_NL.TabIndex = 10;
            // 
            // btn_TimKiemNL
            // 
            this.btn_TimKiemNL.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiemNL.Location = new System.Drawing.Point(362, 77);
            this.btn_TimKiemNL.Name = "btn_TimKiemNL";
            this.btn_TimKiemNL.Size = new System.Drawing.Size(105, 27);
            this.btn_TimKiemNL.TabIndex = 8;
            this.btn_TimKiemNL.Text = "Tìm kiếm";
            this.btn_TimKiemNL.UseVisualStyleBackColor = false;
            this.btn_TimKiemNL.Click += new System.EventHandler(this.btn_TimKiemNL_Click);
            // 
            // txt_TimKiemNL
            // 
            this.txt_TimKiemNL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemNL.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiemNL.Location = new System.Drawing.Point(12, 77);
            this.txt_TimKiemNL.Name = "txt_TimKiemNL";
            this.txt_TimKiemNL.Size = new System.Drawing.Size(344, 27);
            this.txt_TimKiemNL.TabIndex = 9;
            this.txt_TimKiemNL.Text = "Mã nguyên liệu hoặc tên nguyên liệu";
            this.txt_TimKiemNL.Enter += new System.EventHandler(this.txt_TimKiemNL_Enter);
            this.txt_TimKiemNL.Leave += new System.EventHandler(this.txt_TimKiemNL_Leave);
            // 
            // FormDanhMucNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grid_NL);
            this.Controls.Add(this.btn_TimKiemNL);
            this.Controls.Add(this.txt_TimKiemNL);
            this.Name = "FormDanhMucNguyenLieu";
            this.Text = "FormDanhMucNguyenLieu";
            this.Load += new System.EventHandler(this.FormDanhMucNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView grid_NL;
        private System.Windows.Forms.Button btn_TimKiemNL;
        private System.Windows.Forms.TextBox txt_TimKiemNL;
    }
}