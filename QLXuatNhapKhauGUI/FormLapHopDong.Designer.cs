namespace QLXuatNhapKhau
{
    partial class FormLapHopDong
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
            lbl_TittleLapHopDong = new Label();
            groupBox1 = new GroupBox();
            lbl_ThoiGian = new Label();
            txt_ThoiGianGiao = new TextBox();
            btn_LapHopDong = new Button();
            dtp_NgayGiao = new DateTimePicker();
            cbo_PhuongThucThanhToan = new ComboBox();
            lbl_ThoiGianGiao = new Label();
            lbl_PhuongThucThanhToan = new Label();
            groupBox2 = new GroupBox();
            btn_TimKiemKH = new Button();
            txt_NoiGiao = new TextBox();
            lbl_NoiGiao = new Label();
            txt_HoTenKH = new TextBox();
            lbl_TenKH = new Label();
            txt_MaKH = new TextBox();
            lbl_MaKH = new Label();
            grp_ThongTinHopDong = new GroupBox();
            btn_Xóa = new Button();
            btn_Them = new Button();
            txt_SoLuong = new TextBox();
            lbl_SoLuong = new Label();
            btn_TimKiemSP = new Button();
            txt_TimKiemSP = new TextBox();
            grid_SP = new DataGridView();
            grid_HD = new DataGridView();
            lbl_TongTien = new Label();
            txt_TongTien = new TextBox();
            groupBox1.SuspendLayout();
            grp_ThongTinHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_HD).BeginInit();
            SuspendLayout();
            // 
            // lbl_TittleLapHopDong
            // 
            lbl_TittleLapHopDong.AutoSize = true;
            lbl_TittleLapHopDong.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TittleLapHopDong.Location = new Point(489, 10);
            lbl_TittleLapHopDong.Margin = new Padding(4, 0, 4, 0);
            lbl_TittleLapHopDong.Name = "lbl_TittleLapHopDong";
            lbl_TittleLapHopDong.Size = new Size(188, 31);
            lbl_TittleLapHopDong.TabIndex = 0;
            lbl_TittleLapHopDong.Text = "Lập Hợp Đồng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_ThoiGian);
            groupBox1.Controls.Add(txt_ThoiGianGiao);
            groupBox1.Controls.Add(btn_LapHopDong);
            groupBox1.Controls.Add(dtp_NgayGiao);
            groupBox1.Controls.Add(cbo_PhuongThucThanhToan);
            groupBox1.Controls.Add(lbl_ThoiGianGiao);
            groupBox1.Controls.Add(lbl_PhuongThucThanhToan);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btn_TimKiemKH);
            groupBox1.Controls.Add(txt_NoiGiao);
            groupBox1.Controls.Add(lbl_NoiGiao);
            groupBox1.Controls.Add(txt_HoTenKH);
            groupBox1.Controls.Add(lbl_TenKH);
            groupBox1.Controls.Add(txt_MaKH);
            groupBox1.Controls.Add(lbl_MaKH);
            groupBox1.Location = new Point(14, 66);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(468, 352);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hợp đồng:";
            // 
            // lbl_ThoiGian
            // 
            lbl_ThoiGian.AutoSize = true;
            lbl_ThoiGian.Location = new Point(7, 257);
            lbl_ThoiGian.Name = "lbl_ThoiGian";
            lbl_ThoiGian.Size = new Size(85, 15);
            lbl_ThoiGian.TabIndex = 16;
            lbl_ThoiGian.Text = "Thời gian giao:";
            // 
            // txt_ThoiGianGiao
            // 
            txt_ThoiGianGiao.ForeColor = Color.Gray;
            txt_ThoiGianGiao.Location = new Point(160, 254);
            txt_ThoiGianGiao.Name = "txt_ThoiGianGiao";
            txt_ThoiGianGiao.Size = new Size(120, 23);
            txt_ThoiGianGiao.TabIndex = 15;
            txt_ThoiGianGiao.Text = "12:00";
            txt_ThoiGianGiao.Enter += txt_ThoiGianGiao_Enter;
            txt_ThoiGianGiao.Leave += txt_ThoiGianGiao_Leave;
            // 
            // btn_LapHopDong
            // 
            btn_LapHopDong.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_LapHopDong.Location = new Point(324, 302);
            btn_LapHopDong.Margin = new Padding(4, 3, 4, 3);
            btn_LapHopDong.Name = "btn_LapHopDong";
            btn_LapHopDong.Size = new Size(136, 43);
            btn_LapHopDong.TabIndex = 14;
            btn_LapHopDong.Text = "Lập hợp đồng";
            btn_LapHopDong.UseVisualStyleBackColor = true;
            btn_LapHopDong.Click += btn_LapHopDong_Click;
            // 
            // dtp_NgayGiao
            // 
            dtp_NgayGiao.CustomFormat = "yyyy-MM-dd";
            dtp_NgayGiao.Enabled = false;
            dtp_NgayGiao.Location = new Point(160, 208);
            dtp_NgayGiao.Margin = new Padding(4, 3, 4, 3);
            dtp_NgayGiao.Name = "dtp_NgayGiao";
            dtp_NgayGiao.Size = new Size(233, 23);
            dtp_NgayGiao.TabIndex = 12;
            dtp_NgayGiao.Value = new DateTime(2024, 12, 12, 0, 0, 0, 0);
            // 
            // cbo_PhuongThucThanhToan
            // 
            cbo_PhuongThucThanhToan.Enabled = false;
            cbo_PhuongThucThanhToan.FormattingEnabled = true;
            cbo_PhuongThucThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cbo_PhuongThucThanhToan.Location = new Point(161, 159);
            cbo_PhuongThucThanhToan.Margin = new Padding(4, 3, 4, 3);
            cbo_PhuongThucThanhToan.Name = "cbo_PhuongThucThanhToan";
            cbo_PhuongThucThanhToan.Size = new Size(186, 23);
            cbo_PhuongThucThanhToan.TabIndex = 13;
            // 
            // lbl_ThoiGianGiao
            // 
            lbl_ThoiGianGiao.AutoSize = true;
            lbl_ThoiGianGiao.Location = new Point(7, 208);
            lbl_ThoiGianGiao.Margin = new Padding(4, 0, 4, 0);
            lbl_ThoiGianGiao.Name = "lbl_ThoiGianGiao";
            lbl_ThoiGianGiao.Size = new Size(64, 15);
            lbl_ThoiGianGiao.TabIndex = 10;
            lbl_ThoiGianGiao.Text = "Ngày giao:";
            // 
            // lbl_PhuongThucThanhToan
            // 
            lbl_PhuongThucThanhToan.AutoSize = true;
            lbl_PhuongThucThanhToan.Location = new Point(7, 165);
            lbl_PhuongThucThanhToan.Margin = new Padding(4, 0, 4, 0);
            lbl_PhuongThucThanhToan.Name = "lbl_PhuongThucThanhToan";
            lbl_PhuongThucThanhToan.Size = new Size(140, 15);
            lbl_PhuongThucThanhToan.TabIndex = 8;
            lbl_PhuongThucThanhToan.Text = "Phương thức thanh toán:";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(507, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(438, 234);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn_TimKiemKH
            // 
            btn_TimKiemKH.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimKiemKH.Location = new Point(219, 302);
            btn_TimKiemKH.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiemKH.Name = "btn_TimKiemKH";
            btn_TimKiemKH.Size = new Size(98, 43);
            btn_TimKiemKH.TabIndex = 7;
            btn_TimKiemKH.Text = "Tìm kiếm";
            btn_TimKiemKH.UseVisualStyleBackColor = true;
            btn_TimKiemKH.Click += btn_TimKiemKH_Click;
            // 
            // txt_NoiGiao
            // 
            txt_NoiGiao.Enabled = false;
            txt_NoiGiao.Location = new Point(71, 119);
            txt_NoiGiao.Margin = new Padding(4, 3, 4, 3);
            txt_NoiGiao.Name = "txt_NoiGiao";
            txt_NoiGiao.Size = new Size(276, 23);
            txt_NoiGiao.TabIndex = 6;
            // 
            // lbl_NoiGiao
            // 
            lbl_NoiGiao.AutoSize = true;
            lbl_NoiGiao.Location = new Point(7, 122);
            lbl_NoiGiao.Margin = new Padding(4, 0, 4, 0);
            lbl_NoiGiao.Name = "lbl_NoiGiao";
            lbl_NoiGiao.Size = new Size(55, 15);
            lbl_NoiGiao.TabIndex = 5;
            lbl_NoiGiao.Text = "Nơi giao:";
            // 
            // txt_HoTenKH
            // 
            txt_HoTenKH.Location = new Point(113, 78);
            txt_HoTenKH.Margin = new Padding(4, 3, 4, 3);
            txt_HoTenKH.Name = "txt_HoTenKH";
            txt_HoTenKH.Size = new Size(234, 23);
            txt_HoTenKH.TabIndex = 4;
            // 
            // lbl_TenKH
            // 
            lbl_TenKH.AutoSize = true;
            lbl_TenKH.Location = new Point(7, 82);
            lbl_TenKH.Margin = new Padding(4, 0, 4, 0);
            lbl_TenKH.Name = "lbl_TenKH";
            lbl_TenKH.Size = new Size(93, 15);
            lbl_TenKH.TabIndex = 3;
            lbl_TenKH.Text = "Tên khách hàng:";
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(113, 37);
            txt_MaKH.Margin = new Padding(4, 3, 4, 3);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(95, 23);
            txt_MaKH.TabIndex = 2;
            // 
            // lbl_MaKH
            // 
            lbl_MaKH.AutoSize = true;
            lbl_MaKH.Location = new Point(7, 40);
            lbl_MaKH.Margin = new Padding(4, 0, 4, 0);
            lbl_MaKH.Name = "lbl_MaKH";
            lbl_MaKH.Size = new Size(92, 15);
            lbl_MaKH.TabIndex = 0;
            lbl_MaKH.Text = "Mã khách hàng:";
            // 
            // grp_ThongTinHopDong
            // 
            grp_ThongTinHopDong.Controls.Add(btn_Xóa);
            grp_ThongTinHopDong.Controls.Add(btn_Them);
            grp_ThongTinHopDong.Controls.Add(txt_SoLuong);
            grp_ThongTinHopDong.Controls.Add(lbl_SoLuong);
            grp_ThongTinHopDong.Controls.Add(btn_TimKiemSP);
            grp_ThongTinHopDong.Controls.Add(txt_TimKiemSP);
            grp_ThongTinHopDong.Controls.Add(grid_SP);
            grp_ThongTinHopDong.Location = new Point(489, 66);
            grp_ThongTinHopDong.Margin = new Padding(4, 3, 4, 3);
            grp_ThongTinHopDong.Name = "grp_ThongTinHopDong";
            grp_ThongTinHopDong.Padding = new Padding(4, 3, 4, 3);
            grp_ThongTinHopDong.Size = new Size(664, 352);
            grp_ThongTinHopDong.TabIndex = 2;
            grp_ThongTinHopDong.TabStop = false;
            grp_ThongTinHopDong.Text = "Thông tin sản phẩm:";
            // 
            // btn_Xóa
            // 
            btn_Xóa.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Xóa.Location = new Point(569, 302);
            btn_Xóa.Margin = new Padding(4, 3, 4, 3);
            btn_Xóa.Name = "btn_Xóa";
            btn_Xóa.Size = new Size(88, 43);
            btn_Xóa.TabIndex = 15;
            btn_Xóa.Text = "Xóa";
            btn_Xóa.UseVisualStyleBackColor = true;
            btn_Xóa.Click += btn_Xóa_Click;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Them.Location = new Point(475, 302);
            btn_Them.Margin = new Padding(4, 3, 4, 3);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(88, 43);
            btn_Them.TabIndex = 14;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(85, 254);
            txt_SoLuong.Margin = new Padding(4, 3, 4, 3);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(95, 23);
            txt_SoLuong.TabIndex = 14;
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Location = new Point(18, 257);
            lbl_SoLuong.Margin = new Padding(4, 0, 4, 0);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(57, 15);
            lbl_SoLuong.TabIndex = 14;
            lbl_SoLuong.Text = "Số lượng:";
            // 
            // btn_TimKiemSP
            // 
            btn_TimKiemSP.Location = new Point(217, 35);
            btn_TimKiemSP.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiemSP.Name = "btn_TimKiemSP";
            btn_TimKiemSP.Size = new Size(88, 27);
            btn_TimKiemSP.TabIndex = 2;
            btn_TimKiemSP.Text = "Tìm kiếm";
            btn_TimKiemSP.UseVisualStyleBackColor = true;
            btn_TimKiemSP.Click += btn_TimKiemSP_Click;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.ForeColor = Color.Gray;
            txt_TimKiemSP.Location = new Point(7, 37);
            txt_TimKiemSP.Margin = new Padding(4, 3, 4, 3);
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.Size = new Size(202, 23);
            txt_TimKiemSP.TabIndex = 1;
            txt_TimKiemSP.Text = "Mã sản phẩm hoặc tên sản phẩm";
            txt_TimKiemSP.Enter += txt_TimKiemSP_Enter;
            txt_TimKiemSP.Leave += txt_TimKiemSP_Leave;
            // 
            // grid_SP
            // 
            grid_SP.BackgroundColor = Color.White;
            grid_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_SP.Location = new Point(7, 67);
            grid_SP.Margin = new Padding(4, 3, 4, 3);
            grid_SP.Name = "grid_SP";
            grid_SP.Size = new Size(650, 167);
            grid_SP.TabIndex = 0;
            grid_SP.CellContentClick += grid_SP_CellContentClick;
            // 
            // grid_HD
            // 
            grid_HD.BackgroundColor = Color.White;
            grid_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_HD.Location = new Point(14, 425);
            grid_HD.Margin = new Padding(4, 3, 4, 3);
            grid_HD.Name = "grid_HD";
            grid_HD.Size = new Size(1132, 216);
            grid_HD.TabIndex = 8;
            // 
            // lbl_TongTien
            // 
            lbl_TongTien.AutoSize = true;
            lbl_TongTien.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TongTien.Location = new Point(859, 670);
            lbl_TongTien.Margin = new Padding(4, 0, 4, 0);
            lbl_TongTien.Name = "lbl_TongTien";
            lbl_TongTien.Size = new Size(85, 19);
            lbl_TongTien.TabIndex = 9;
            lbl_TongTien.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(957, 669);
            txt_TongTien.Margin = new Padding(4, 3, 4, 3);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(188, 23);
            txt_TongTien.TabIndex = 10;
            // 
            // FormLapHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 706);
            Controls.Add(txt_TongTien);
            Controls.Add(lbl_TongTien);
            Controls.Add(grid_HD);
            Controls.Add(grp_ThongTinHopDong);
            Controls.Add(groupBox1);
            Controls.Add(lbl_TittleLapHopDong);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLapHopDong";
            Text = "FormLapHopDong";
            Load += FormLapHopDong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grp_ThongTinHopDong.ResumeLayout(false);
            grp_ThongTinHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SP).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_HD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_TittleLapHopDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.Button btn_TimKiemKH;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.DataGridView grid_HD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_ThongTinHopDong;
        private System.Windows.Forms.TextBox txt_NoiGiao;
        private System.Windows.Forms.Label lbl_NoiGiao;
        private System.Windows.Forms.Label lbl_ThoiGianGiao;
        private System.Windows.Forms.Label lbl_PhuongThucThanhToan;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiao;
        private System.Windows.Forms.ComboBox cbo_PhuongThucThanhToan;
        private System.Windows.Forms.Button btn_TimKiemSP;
        private System.Windows.Forms.TextBox txt_TimKiemSP;
        private System.Windows.Forms.DataGridView grid_SP;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Button btn_LapHopDong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private Label lbl_ThoiGian;
        private TextBox txt_ThoiGianGiao;
    }
}