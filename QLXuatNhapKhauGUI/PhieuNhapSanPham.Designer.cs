namespace QLXuatNhapKhau.GUI
{
    partial class PhieuNhapSanPham
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
            btnThem = new Button();
            btnSua = new Button();
            btnIn = new Button();
            groupBox1 = new GroupBox();
            comboPX = new ComboBox();
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
            textTenSP = new TextBox();
            label7 = new Label();
            textMaSP = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnXoa = new Button();
            grid_SP = new DataGridView();
            grid_PN = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            textTongGiaTri = new TextBox();
            textDonViTinh = new TextBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            btnLapPhieu = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_PN).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(478, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(595, 17);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIn.Location = new Point(828, 17);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 40);
            btnIn.TabIndex = 2;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboPX);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimeNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textMP);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 147);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // comboPX
            // 
            comboPX.FormattingEnabled = true;
            comboPX.Location = new Point(404, 68);
            comboPX.Name = "comboPX";
            comboPX.Size = new Size(155, 23);
            comboPX.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 70);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Phân xưởng :";
            // 
            // dateTimeNhap
            // 
            dateTimeNhap.Location = new Point(83, 68);
            dateTimeNhap.Name = "dateTimeNhap";
            dateTimeNhap.Size = new Size(204, 23);
            dateTimeNhap.TabIndex = 5;
            dateTimeNhap.Value = new DateTime(2024, 12, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 70);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày nhập :";
            // 
            // textNV
            // 
            textNV.Enabled = false;
            textNV.Location = new Point(382, 28);
            textNV.Name = "textNV";
            textNV.Size = new Size(164, 23);
            textNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 30);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên :";
            // 
            // textMP
            // 
            textMP.Enabled = false;
            textMP.Location = new Point(83, 28);
            textMP.Name = "textMP";
            textMP.Size = new Size(92, 23);
            textMP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu :";
            // 
            // textDonGia
            // 
            textDonGia.Location = new Point(312, 68);
            textDonGia.Name = "textDonGia";
            textDonGia.Size = new Size(88, 23);
            textDonGia.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(252, 70);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 14;
            label9.Text = "Đơn giá :";
            // 
            // textSoLuong
            // 
            textSoLuong.Location = new Point(312, 28);
            textSoLuong.Name = "textSoLuong";
            textSoLuong.Size = new Size(88, 23);
            textSoLuong.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 30);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 12;
            label8.Text = "Số lượng :";
            // 
            // textTenSP
            // 
            textTenSP.Location = new Point(79, 68);
            textTenSP.Name = "textTenSP";
            textTenSP.Size = new Size(156, 23);
            textTenSP.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 70);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Tên SP :";
            // 
            // textMaSP
            // 
            textMaSP.Location = new Point(79, 28);
            textMaSP.Name = "textMaSP";
            textMaSP.Size = new Size(88, 23);
            textMaSP.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 30);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 8;
            label6.Text = "Mã SP :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 21);
            label1.Name = "label1";
            label1.Size = new Size(267, 31);
            label1.TabIndex = 4;
            label1.Text = "Phiếu nhập sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(712, 17);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 40);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // grid_SP
            // 
            grid_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_SP.Location = new Point(5, 20);
            grid_SP.Name = "grid_SP";
            grid_SP.RowHeadersWidth = 51;
            grid_SP.RowTemplate.Height = 24;
            grid_SP.Size = new Size(496, 152);
            grid_SP.TabIndex = 6;
            grid_SP.CellContentClick += grid_SP_CellContentClick;
            // 
            // grid_PN
            // 
            grid_PN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_PN.Location = new Point(5, 20);
            grid_PN.Name = "grid_PN";
            grid_PN.RowHeadersWidth = 51;
            grid_PN.RowTemplate.Height = 24;
            grid_PN.Size = new Size(486, 152);
            grid_PN.TabIndex = 7;
            grid_PN.CellContentClick += grid_PN_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grid_SP);
            groupBox2.Location = new Point(15, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 181);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grid_PN);
            groupBox3.Location = new Point(539, 333);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 181);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết phiếu nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(830, 539);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 10;
            label10.Text = "Tổng giá trị :";
            // 
            // textTongGiaTri
            // 
            textTongGiaTri.Location = new Point(911, 537);
            textTongGiaTri.Name = "textTongGiaTri";
            textTongGiaTri.Size = new Size(127, 23);
            textTongGiaTri.TabIndex = 11;
            // 
            // textDonViTinh
            // 
            textDonViTinh.Location = new Point(100, 108);
            textDonViTinh.Name = "textDonViTinh";
            textDonViTinh.Size = new Size(88, 23);
            textDonViTinh.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 110);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 16;
            label11.Text = "Đơn vị tính :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textDonGia);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(textTenSP);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textDonViTinh);
            groupBox4.Controls.Add(textSoLuong);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(textMaSP);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(596, 77);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 147);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin sản phẩm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnLapPhieu);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Controls.Add(btnSua);
            groupBox5.Controls.Add(btnXoa);
            groupBox5.Controls.Add(btnIn);
            groupBox5.Location = new Point(20, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1018, 69);
            groupBox5.TabIndex = 19;
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
            // PhieuNhapSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 565);
            Controls.Add(textTongGiaTri);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Name = "PhieuNhapSanPham";
            Text = "PhieuNhapSanPham";
            Load += PhieuNhapSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SP).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_PN).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView grid_SP;
        private System.Windows.Forms.DataGridView grid_PN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPX;
        private System.Windows.Forms.TextBox textTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMaSP;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTongGiaTri;
        private System.Windows.Forms.TextBox textDonViTinh;
        private System.Windows.Forms.Label label11;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btnLapPhieu;
    }
}