namespace QLXuatNhapKhau.GUI
{
    partial class PhieuXuatSanPham
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
            grid_PX = new DataGridView();
            grid_SP = new DataGridView();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            textMaKH = new TextBox();
            label5 = new Label();
            textTenSP = new TextBox();
            label7 = new Label();
            comboMaHD = new ComboBox();
            dateTimeXuat = new DateTimePicker();
            M = new Label();
            label4 = new Label();
            textNV = new TextBox();
            label3 = new Label();
            textMP = new TextBox();
            label2 = new Label();
            comboMaSP = new ComboBox();
            label10 = new Label();
            textNoiGiao = new TextBox();
            textDonGia = new TextBox();
            label9 = new Label();
            textSoLuong = new TextBox();
            label8 = new Label();
            label6 = new Label();
            btnIn = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            textDonViTinh = new TextBox();
            label11 = new Label();
            textTongGiaTri = new TextBox();
            label12 = new Label();
            btnTimKiem = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            btnLapPhieu = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_PX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_SP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // grid_PX
            // 
            grid_PX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_PX.Location = new Point(5, 20);
            grid_PX.Margin = new Padding(2);
            grid_PX.Name = "grid_PX";
            grid_PX.RowHeadersWidth = 51;
            grid_PX.RowTemplate.Height = 24;
            grid_PX.Size = new Size(486, 152);
            grid_PX.TabIndex = 17;
            grid_PX.CellContentClick += grid_PX_CellContentClick;
            // 
            // grid_SP
            // 
            grid_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_SP.Location = new Point(5, 20);
            grid_SP.Margin = new Padding(2);
            grid_SP.Name = "grid_SP";
            grid_SP.RowHeadersWidth = 51;
            grid_SP.RowTemplate.Height = 24;
            grid_SP.Size = new Size(496, 152);
            grid_SP.TabIndex = 16;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(712, 17);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 40);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textMaKH);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textTenSP);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboMaHD);
            groupBox1.Controls.Add(dateTimeXuat);
            groupBox1.Controls.Add(M);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textMP);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 77);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(575, 147);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // textMaKH
            // 
            textMaKH.Location = new Point(87, 108);
            textMaKH.Margin = new Padding(2);
            textMaKH.Name = "textMaKH";
            textMaKH.Size = new Size(145, 23);
            textMaKH.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 16;
            label5.Text = "Khách hàng :";
            // 
            // textTenSP
            // 
            textTenSP.Location = new Point(624, -18);
            textTenSP.Margin = new Padding(2);
            textTenSP.Name = "textTenSP";
            textTenSP.Size = new Size(156, 23);
            textTenSP.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(568, -16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Tên SP :";
            // 
            // comboMaHD
            // 
            comboMaHD.Enabled = false;
            comboMaHD.FormattingEnabled = true;
            comboMaHD.Location = new Point(382, 68);
            comboMaHD.Margin = new Padding(2);
            comboMaHD.Name = "comboMaHD";
            comboMaHD.Size = new Size(114, 23);
            comboMaHD.TabIndex = 20;
            comboMaHD.SelectedIndexChanged += comboMaHD_SelectedIndexChanged;
            // 
            // dateTimeXuat
            // 
            dateTimeXuat.Location = new Point(83, 68);
            dateTimeXuat.Margin = new Padding(2);
            dateTimeXuat.Name = "dateTimeXuat";
            dateTimeXuat.Size = new Size(204, 23);
            dateTimeXuat.TabIndex = 5;
            // 
            // M
            // 
            M.AutoSize = true;
            M.Location = new Point(304, 70);
            M.Margin = new Padding(2, 0, 2, 0);
            M.Name = "M";
            M.Size = new Size(50, 15);
            M.TabIndex = 19;
            M.Text = "Mã HD :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày giao :";
            // 
            // textNV
            // 
            textNV.Enabled = false;
            textNV.Location = new Point(382, 28);
            textNV.Margin = new Padding(2);
            textNV.Name = "textNV";
            textNV.Size = new Size(184, 23);
            textNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên :";
            // 
            // textMP
            // 
            textMP.Enabled = false;
            textMP.Location = new Point(83, 28);
            textMP.Margin = new Padding(2);
            textMP.Name = "textMP";
            textMP.Size = new Size(93, 23);
            textMP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu :";
            // 
            // comboMaSP
            // 
            comboMaSP.Enabled = false;
            comboMaSP.FormattingEnabled = true;
            comboMaSP.Location = new Point(79, 28);
            comboMaSP.Margin = new Padding(2);
            comboMaSP.Name = "comboMaSP";
            comboMaSP.Size = new Size(88, 23);
            comboMaSP.TabIndex = 23;
            comboMaSP.SelectedIndexChanged += comboMaSP_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 110);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 22;
            label10.Text = "Nơi giao :";
            // 
            // textNoiGiao
            // 
            textNoiGiao.Enabled = false;
            textNoiGiao.Location = new Point(79, 108);
            textNoiGiao.Margin = new Padding(2);
            textNoiGiao.Name = "textNoiGiao";
            textNoiGiao.Size = new Size(154, 23);
            textNoiGiao.TabIndex = 21;
            // 
            // textDonGia
            // 
            textDonGia.Enabled = false;
            textDonGia.Location = new Point(79, 68);
            textDonGia.Margin = new Padding(2);
            textDonGia.Name = "textDonGia";
            textDonGia.Size = new Size(88, 23);
            textDonGia.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 70);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 14;
            label9.Text = "Đơn giá :";
            // 
            // textSoLuong
            // 
            textSoLuong.Enabled = false;
            textSoLuong.Location = new Point(307, 28);
            textSoLuong.Margin = new Padding(2);
            textSoLuong.Name = "textSoLuong";
            textSoLuong.Size = new Size(88, 23);
            textSoLuong.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 31);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 12;
            label8.Text = "Số lượng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 30);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 8;
            label6.Text = "Mã SP :";
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIn.Location = new Point(828, 17);
            btnIn.Margin = new Padding(2);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 40);
            btnIn.TabIndex = 12;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(595, 17);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 40);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grid_SP);
            groupBox2.Location = new Point(15, 333);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(505, 181);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grid_PX);
            groupBox3.Location = new Point(539, 333);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(496, 181);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết phiếu xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 14;
            label1.Text = "Phiếu xuất sản phẩm";
            // 
            // textDonViTinh
            // 
            textDonViTinh.Enabled = false;
            textDonViTinh.Location = new Point(319, 68);
            textDonViTinh.Margin = new Padding(2);
            textDonViTinh.Name = "textDonViTinh";
            textDonViTinh.Size = new Size(88, 23);
            textDonViTinh.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(244, 71);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 22;
            label11.Text = "Đơn vị tính :";
            // 
            // textTongGiaTri
            // 
            textTongGiaTri.Location = new Point(911, 537);
            textTongGiaTri.Margin = new Padding(2);
            textTongGiaTri.Name = "textTongGiaTri";
            textTongGiaTri.Size = new Size(128, 23);
            textTongGiaTri.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(830, 539);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 20;
            label12.Text = "Tổng giá trị :";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(478, 17);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 40);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textDonViTinh);
            groupBox4.Controls.Add(comboMaSP);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(textNoiGiao);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textDonGia);
            groupBox4.Controls.Add(textSoLuong);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(596, 77);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 147);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin hợp đồng";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnLapPhieu);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Controls.Add(btnXoa);
            groupBox5.Controls.Add(btnIn);
            groupBox5.Location = new Point(20, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1018, 69);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // btnLapPhieu
            // 
            btnLapPhieu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLapPhieu.Location = new Point(360, 17);
            btnLapPhieu.Margin = new Padding(2);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(90, 40);
            btnLapPhieu.TabIndex = 25;
            btnLapPhieu.Text = "Lập phiếu";
            btnLapPhieu.UseVisualStyleBackColor = true;
            btnLapPhieu.Click += btnLapPhieu_Click;
            // 
            // PhieuXuatSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 565);
            Controls.Add(groupBox4);
            Controls.Add(textTongGiaTri);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Margin = new Padding(2);
            Name = "PhieuXuatSanPham";
            Text = "PhieuXuatSanPham";
            Load += PhieuXuatSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)grid_PX).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_SP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grid_PX;
        private System.Windows.Forms.DataGridView grid_SP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMaHD;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textNoiGiao;
        private System.Windows.Forms.TextBox textDonViTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTongGiaTri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboMaSP;
        private System.Windows.Forms.Button btnTimKiem;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btnLapPhieu;
    }
}