namespace QLXuatNhapKhau.GUI
{
    partial class PhieuNhapNguyenLieu
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
            textDonViTinh = new TextBox();
            label11 = new Label();
            textTongGiaTri = new TextBox();
            label10 = new Label();
            grid_PN = new DataGridView();
            grid_NL = new DataGridView();
            btnXoa = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateNgayMua = new DateTimePicker();
            label12 = new Label();
            comboNCC = new ComboBox();
            label5 = new Label();
            dateTimeNhap = new DateTimePicker();
            label4 = new Label();
            textNV = new TextBox();
            label3 = new Label();
            textMP = new TextBox();
            label2 = new Label();
            textDonGia = new TextBox();
            label9 = new Label();
            textSoLuong = new TextBox();
            label8 = new Label();
            textTenNL = new TextBox();
            label7 = new Label();
            textMaNL = new TextBox();
            label6 = new Label();
            btnIn = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            btnLapPhieu = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_PN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_NL).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // textDonViTinh
            // 
            textDonViTinh.Enabled = false;
            textDonViTinh.Location = new Point(100, 108);
            textDonViTinh.Margin = new Padding(2);
            textDonViTinh.Name = "textDonViTinh";
            textDonViTinh.Size = new Size(88, 23);
            textDonViTinh.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 110);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 30;
            label11.Text = "Đơn vị tính :";
            // 
            // textTongGiaTri
            // 
            textTongGiaTri.Location = new Point(911, 537);
            textTongGiaTri.Margin = new Padding(2);
            textTongGiaTri.Name = "textTongGiaTri";
            textTongGiaTri.Size = new Size(128, 23);
            textTongGiaTri.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(830, 539);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 28;
            label10.Text = "Tổng giá trị :";
            // 
            // grid_PN
            // 
            grid_PN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_PN.Location = new Point(5, 20);
            grid_PN.Margin = new Padding(2);
            grid_PN.Name = "grid_PN";
            grid_PN.RowHeadersWidth = 51;
            grid_PN.RowTemplate.Height = 24;
            grid_PN.Size = new Size(486, 152);
            grid_PN.TabIndex = 25;
            grid_PN.CellContentClick += grid_PN_CellContentClick;
            // 
            // grid_NL
            // 
            grid_NL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_NL.Location = new Point(5, 20);
            grid_NL.Margin = new Padding(2);
            grid_NL.Name = "grid_NL";
            grid_NL.RowHeadersWidth = 51;
            grid_NL.RowTemplate.Height = 24;
            grid_NL.Size = new Size(496, 152);
            grid_NL.TabIndex = 24;
            grid_NL.CellContentClick += grid_NL_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(712, 17);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 40);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 22;
            label1.Text = "Phiếu nhập nguyên liệu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateNgayMua);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboNCC);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimeNhap);
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
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dateNgayMua
            // 
            dateNgayMua.Location = new Point(83, 108);
            dateNgayMua.Margin = new Padding(2);
            dateNgayMua.Name = "dateNgayMua";
            dateNgayMua.Size = new Size(204, 23);
            dateNgayMua.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 110);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 16;
            label12.Text = "Ngày mua :";
            // 
            // comboNCC
            // 
            comboNCC.FormattingEnabled = true;
            comboNCC.Location = new Point(404, 68);
            comboNCC.Margin = new Padding(2);
            comboNCC.Name = "comboNCC";
            comboNCC.Size = new Size(156, 23);
            comboNCC.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 6;
            label5.Text = "Nhà cung cấp :";
            // 
            // dateTimeNhap
            // 
            dateTimeNhap.Location = new Point(83, 68);
            dateTimeNhap.Margin = new Padding(2);
            dateTimeNhap.Name = "dateTimeNhap";
            dateTimeNhap.Size = new Size(204, 23);
            dateTimeNhap.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày nhập :";
            // 
            // textNV
            // 
            textNV.Enabled = false;
            textNV.Location = new Point(382, 28);
            textNV.Margin = new Padding(2);
            textNV.Name = "textNV";
            textNV.Size = new Size(164, 23);
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
            // textDonGia
            // 
            textDonGia.Enabled = false;
            textDonGia.Location = new Point(312, 68);
            textDonGia.Margin = new Padding(2);
            textDonGia.Name = "textDonGia";
            textDonGia.Size = new Size(88, 23);
            textDonGia.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(252, 70);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 14;
            label9.Text = "Đơn giá :";
            // 
            // textSoLuong
            // 
            textSoLuong.Enabled = false;
            textSoLuong.Location = new Point(312, 28);
            textSoLuong.Margin = new Padding(2);
            textSoLuong.Name = "textSoLuong";
            textSoLuong.Size = new Size(88, 23);
            textSoLuong.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 30);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 12;
            label8.Text = "Số lượng :";
            // 
            // textTenNL
            // 
            textTenNL.Enabled = false;
            textTenNL.Location = new Point(79, 68);
            textTenNL.Margin = new Padding(2);
            textTenNL.Name = "textTenNL";
            textTenNL.Size = new Size(156, 23);
            textTenNL.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 70);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 10;
            label7.Text = "Tên NL :";
            // 
            // textMaNL
            // 
            textMaNL.Enabled = false;
            textMaNL.Location = new Point(79, 28);
            textMaNL.Margin = new Padding(2);
            textMaNL.Name = "textMaNL";
            textMaNL.Size = new Size(88, 23);
            textMaNL.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 30);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 8;
            label6.Text = "Mã NL :";
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIn.Location = new Point(828, 17);
            btnIn.Margin = new Padding(2);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 40);
            btnIn.TabIndex = 20;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(595, 17);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 40);
            btnSua.TabIndex = 19;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(478, 17);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 40);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grid_NL);
            groupBox2.Location = new Point(15, 333);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(505, 181);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết nguyên liệu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grid_PN);
            groupBox3.Location = new Point(539, 333);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(496, 181);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết phiếu nhập";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textMaNL);
            groupBox4.Controls.Add(textDonViTinh);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(textDonGia);
            groupBox4.Controls.Add(textTenNL);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textSoLuong);
            groupBox4.Location = new Point(596, 77);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(439, 147);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nguyên liệu";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnLapPhieu);
            groupBox5.Controls.Add(btnXoa);
            groupBox5.Controls.Add(btnIn);
            groupBox5.Controls.Add(btnSua);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Location = new Point(20, 241);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(1018, 69);
            groupBox5.TabIndex = 33;
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
            btnLapPhieu.TabIndex = 24;
            btnLapPhieu.Text = "Lập phiếu";
            btnLapPhieu.UseVisualStyleBackColor = true;
            btnLapPhieu.Click += btnLapPhieu_Click;
            // 
            // PhieuNhapNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 565);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(textTongGiaTri);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Margin = new Padding(2);
            Name = "PhieuNhapNguyenLieu";
            Text = "PhieuNhapNguyenLieu";
            Load += PhieuNhapNguyenLieu_Load;
            ((System.ComponentModel.ISupportInitialize)grid_PN).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_NL).EndInit();
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

        private System.Windows.Forms.TextBox textDonViTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTongGiaTri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid_PN;
        private System.Windows.Forms.DataGridView grid_NL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTenNL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMaNL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateNgayMua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLapPhieu;
    }
}