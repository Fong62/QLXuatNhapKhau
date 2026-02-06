namespace QLXuatNhapKhauGUI
{
    partial class FormThongKe
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
            cbo_ThongKe = new ComboBox();
            lbl_Title = new Label();
            grid_TK = new DataGridView();
            btn_TimKiem = new Button();
            groupBox1 = new GroupBox();
            grid_TKCT = new DataGridView();
            groupBox2 = new GroupBox();
            btn_In = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_TK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_TKCT).BeginInit();
            SuspendLayout();
            // 
            // cbo_ThongKe
            // 
            cbo_ThongKe.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_ThongKe.FormattingEnabled = true;
            cbo_ThongKe.Items.AddRange(new object[] { "Hợp Đồng", "Phiếu Nhập Nguyên Liệu", "Phiếu Nhập Sản Phẩm", "Phiếu Xuất Nguyên Liệu", "Phiếu Xuất Sản Phẩm" });
            cbo_ThongKe.Location = new Point(13, 73);
            cbo_ThongKe.Name = "cbo_ThongKe";
            cbo_ThongKe.Size = new Size(327, 27);
            cbo_ThongKe.TabIndex = 15;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(340, 10);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(235, 31);
            lbl_Title.TabIndex = 14;
            lbl_Title.Text = "Thống kê thông tin";
            // 
            // grid_TK
            // 
            grid_TK.BackgroundColor = Color.White;
            grid_TK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_TK.Location = new Point(20, 128);
            grid_TK.Margin = new Padding(4, 3, 4, 3);
            grid_TK.Name = "grid_TK";
            grid_TK.Size = new Size(895, 165);
            grid_TK.TabIndex = 13;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.Control;
            btn_TimKiem.Location = new Point(670, 69);
            btn_TimKiem.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(122, 31);
            btn_TimKiem.TabIndex = 12;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 193);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kế";
            // 
            // grid_TKCT
            // 
            grid_TKCT.BackgroundColor = Color.White;
            grid_TKCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_TKCT.Location = new Point(19, 343);
            grid_TKCT.Margin = new Padding(4, 3, 4, 3);
            grid_TKCT.Name = "grid_TKCT";
            grid_TKCT.Size = new Size(895, 165);
            grid_TKCT.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(13, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(909, 193);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê chi tiết";
            // 
            // btn_In
            // 
            btn_In.BackColor = SystemColors.Control;
            btn_In.Location = new Point(800, 69);
            btn_In.Margin = new Padding(4, 3, 4, 3);
            btn_In.Name = "btn_In";
            btn_In.Size = new Size(122, 31);
            btn_In.TabIndex = 22;
            btn_In.Text = "In";
            btn_In.UseVisualStyleBackColor = false;
            btn_In.Click += btn_In_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 526);
            Controls.Add(btn_In);
            Controls.Add(grid_TKCT);
            Controls.Add(groupBox2);
            Controls.Add(cbo_ThongKe);
            Controls.Add(lbl_Title);
            Controls.Add(grid_TK);
            Controls.Add(btn_TimKiem);
            Controls.Add(groupBox1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)grid_TK).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_TKCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbo_ThongKe;
        private Label lbl_Title;
        private DataGridView grid_TK;
        private Button btn_TimKiem;
        private GroupBox groupBox1;
        private DataGridView grid_TKCT;
        private GroupBox groupBox2;
        private Button btn_In;
    }
}