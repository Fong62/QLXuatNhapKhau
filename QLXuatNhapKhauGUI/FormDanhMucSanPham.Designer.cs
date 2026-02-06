namespace QLXuatNhapKhau
{
    partial class FormDanhMucSanPham
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
            this.grid_SP = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemSP = new System.Windows.Forms.Button();
            this.txt_TimKiemSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(280, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(254, 31);
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "Danh mục sản phẩm";
            // 
            // grid_SP
            // 
            this.grid_SP.BackgroundColor = System.Drawing.Color.White;
            this.grid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SP.Location = new System.Drawing.Point(12, 110);
            this.grid_SP.Name = "grid_SP";
            this.grid_SP.Size = new System.Drawing.Size(776, 330);
            this.grid_SP.TabIndex = 6;
            this.grid_SP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SP_CellContentClick);
            // 
            // btn_TimKiemSP
            // 
            this.btn_TimKiemSP.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiemSP.Location = new System.Drawing.Point(362, 77);
            this.btn_TimKiemSP.Name = "btn_TimKiemSP";
            this.btn_TimKiemSP.Size = new System.Drawing.Size(105, 27);
            this.btn_TimKiemSP.TabIndex = 4;
            this.btn_TimKiemSP.Text = "Tìm kiếm";
            this.btn_TimKiemSP.UseVisualStyleBackColor = false;
            this.btn_TimKiemSP.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiemSP
            // 
            this.txt_TimKiemSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemSP.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiemSP.Location = new System.Drawing.Point(12, 77);
            this.txt_TimKiemSP.Name = "txt_TimKiemSP";
            this.txt_TimKiemSP.Size = new System.Drawing.Size(344, 27);
            this.txt_TimKiemSP.TabIndex = 5;
            this.txt_TimKiemSP.Text = "Mã sản phẩm hoặc tên sản phẩm";
            this.txt_TimKiemSP.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiemSP.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // FormDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grid_SP);
            this.Controls.Add(this.btn_TimKiemSP);
            this.Controls.Add(this.txt_TimKiemSP);
            this.Name = "FormDanhMucSanPham";
            this.Text = "DanhMucSanPham";
            this.Load += new System.EventHandler(this.DanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView grid_SP;
        private System.Windows.Forms.Button btn_TimKiemSP;
        private System.Windows.Forms.TextBox txt_TimKiemSP;
    }
}