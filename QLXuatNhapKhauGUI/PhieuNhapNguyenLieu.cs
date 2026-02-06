using OfficeOpenXml;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLXuatNhapKhau.GUI
{
    public partial class PhieuNhapNguyenLieu : Form
    {
        public PhieuNhapNguyenLieu()
        {
            InitializeComponent();
        }

        NhapNguyenLieu nhapNguyenLieu = new NhapNguyenLieu();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        DataTable phieuNhap;

        decimal soluongcu = 0;
        decimal tonggiatricu = 0;
        decimal tongTien = 0;

        string mapnnl;
        DateTime ngayNhap;
        DateTime ngayMua;
        string maNCC;

        string maNL;
        string tenNL;
        string soLuong;
        string donGia;
        string donViTinh;

        private void PhieuNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
            grid_PN.DataSource = nhapNguyenLieu.LayCTPhieuNhapNL();
            List<string> dsPX = nhapNguyenLieu.LayDanhSachNCC();
            comboNCC.Items.Clear();
            foreach (string tenncc in dsPX)
            {
                comboNCC.Items.Add(tenncc);
            }
            textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);

            mapnnl = nhapNguyenLieu.TaoMaPNNL();
            textMP.Text = mapnnl;
        }

        private void grid_NL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMaNL.Text = grid_NL.Rows[e.RowIndex].Cells["MANL"].Value.ToString();
                textTenNL.Text = grid_NL.Rows[e.RowIndex].Cells["TENNL"].Value.ToString();
                textSoLuong.Text = grid_NL.Rows[e.RowIndex].Cells["SOLUONG"].Value.ToString();
                textDonGia.Text = grid_NL.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString();
                textDonViTinh.Text = grid_NL.Rows[e.RowIndex].Cells["DONVITINH"].Value.ToString();
            }
        }

        private void grid_PN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMP.Text = grid_PN.Rows[e.RowIndex].Cells["MAPNHAPNL"].Value.ToString();
                textMaNL.Text = grid_PN.Rows[e.RowIndex].Cells["MANL"].Value.ToString();
                textSoLuong.Text = grid_PN.Rows[e.RowIndex].Cells["SOLUONGNHAP"].Value.ToString();
                //textTongGiaTri.Text = grid_PN.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString();
                tonggiatricu = Convert.ToDecimal(grid_PN.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString());
                soluongcu = Convert.ToDecimal(textSoLuong.Text); //SoLuongNhapTrcKhiCapNhat
                textDonGia.Text = nhapNguyenLieu.LayDonGia(textMaNL.Text);
                textTenNL.Text = nhapNguyenLieu.LayTenNl(textMaNL.Text);
                //textDonViTinh.Text = grid_NL.Rows[e.RowIndex].Cells["DONVITINH"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboNCC.Text))
            {
                MessageBox.Show("Chọn phân xưởng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textMaNL.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                textMP.Text = mapnnl;

                ngayNhap = dateTimeNhap.Value;
                ngayMua = dateNgayMua.Value;
                maNCC = nhapNguyenLieu.LayMaNCC(comboNCC.Text);

                maNL = textMaNL.Text;
                tenNL = textTenNL.Text;
                soLuong = textSoLuong.Text;
                donGia = textDonGia.Text;
                donViTinh = textDonViTinh.Text;

                int rowsNL = nhapNguyenLieu.CheckMaNL(textMaNL.Text);
                bool NewMaterial = rowsNL == 0;


                if (!decimal.TryParse(soLuong, out decimal soluong) || soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(donGia, out decimal dongia) || dongia <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal tonggiatrinhap = soluong * dongia;

                tongTien += Convert.ToDecimal(tonggiatrinhap);

                textTongGiaTri.Text = tongTien.ToString();

                decimal tongtien = Convert.ToDecimal(textTongGiaTri.Text);

                if (NewMaterial)
                {
                    nhapNguyenLieu.ThemNL(maNL, tenNL, textDonViTinh.Text, dongia, soluong);

                    nhapNguyenLieu.ThemCTPNNL(maNL, mapnnl, soluong, tonggiatrinhap, ngayNhap);

                    nhapNguyenLieu.UpdatePNNL(mapnnl, tongtien);
                }
                else
                {
                    decimal tongsoluong = soluong + nhapNguyenLieu.LaySoLuongNL(maNL);
                    nhapNguyenLieu.UpdateNL(maNL, tongsoluong, dongia, tenNL);

                    nhapNguyenLieu.ThemCTPNNL(maNL, mapnnl, soluong, tonggiatrinhap, ngayNhap);

                    nhapNguyenLieu.UpdatePNNL(mapnnl, tongtien);
                }


                grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
                grid_PN.DataSource = nhapNguyenLieu.LayCTPhieuNhapNL();

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa phiếu nhập này không? Dữ liệu sẽ không thể khôi phục!",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                decimal dongia = Convert.ToDecimal(textDonGia.Text);
                bool success = true;
                DataTable danhSachNguyenLieu = nhapNguyenLieu.LayCTPNDuaTrenMaPN(textMP.Text);

                if (danhSachNguyenLieu.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào trong phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Duyệt từng sản phẩm trong phiếu mượn và cộng lại số lượng
                foreach (DataRow row in danhSachNguyenLieu.Rows)
                {
                    string manl = row["MANL"].ToString();
                    decimal soluongcu = Convert.ToDecimal(row["SOLUONGNHAP"]);
                    decimal soluong = nhapNguyenLieu.LaySoLuongNL(manl);

                    decimal soluongmoi = soluong - soluongcu;
                    nhapNguyenLieu.UpdateNL(manl, soluongmoi, dongia, textTenNL.Text);
                }
                nhapNguyenLieu.XoaPhieuNL(textMP.Text);


                if (success)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu hiển thị
                    grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
                    grid_PN.DataSource = nhapNguyenLieu.LayCTPhieuNhapNL();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu nhập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textSoLuong.Text, out decimal soluong) || soluong <= 0)
            {
                MessageBox.Show("Số lượng phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textDonGia.Text, out decimal dongia) || dongia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayNhap;
            if (!DateTime.TryParse(dateTimeNhap.Value.ToString(), out ngayNhap))
            {
                MessageBox.Show("Ngày giờ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal soluongmoi = nhapNguyenLieu.LaySoLuongNL(textMaNL.Text) - soluongcu + soluong;
            nhapNguyenLieu.UpdateNL(textMaNL.Text, soluongmoi, dongia, textTenNL.Text);

            decimal tonggiatrinhap = soluong * dongia;
            nhapNguyenLieu.UpdateCTPNNL(textMaNL.Text, textMP.Text, soluong, tonggiatrinhap, ngayNhap);

            //decimal tonggiatricu = Convert.ToDecimal(textTongGiaTri.Text);

            decimal tonggiatrimoi = nhapNguyenLieu.LayTongTien(mapnnl) - tonggiatricu + tonggiatrinhap;
            nhapNguyenLieu.UpdatePNNL(textMP.Text, tonggiatrimoi);
            tongTien = tonggiatrimoi;
            textTongGiaTri.Text = tongTien.ToString();

            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
            grid_PN.DataSource = nhapNguyenLieu.LayCTPhieuNhapNL();
        }
        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Nhập");

                // Xuất tiêu đề
                worksheet.Cells[1, 1].Value = "Chi Tiết Phiếu Nhập Nguyên Liệu";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Font.Size = 14;
                worksheet.Cells[1, 1, 1, 5].Merge = true; // Gộp cột
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Xuất tiêu đề các cột
                worksheet.Cells[3, 1].Value = "Mã Nguyên Liệu";
                worksheet.Cells[3, 2].Value = "Mã Phiếu Nhập";
                worksheet.Cells[3, 3].Value = "Số Lượng Nhập";
                worksheet.Cells[3, 4].Value = "Ngày Nhập";
                worksheet.Cells[3, 5].Value = "Tổng Giá Trị";

                // Xuất dữ liệu từ DataGridView
                int rowIndex = 4;
                foreach (DataGridViewRow row in grid_PN.Rows)
                {
                    if (row.Cells["MANL"].Value != null && row.Cells["MAPNHAPNL"].Value != null) // Kiểm tra dữ liệu tồn tại
                    {
                        worksheet.Cells[rowIndex, 1].Value = row.Cells["MANL"].Value.ToString();
                        worksheet.Cells[rowIndex, 2].Value = row.Cells["MAPNHAPNL"].Value.ToString();
                        worksheet.Cells[rowIndex, 3].Value = row.Cells["SOLUONGNHAP"].Value.ToString();
                        worksheet.Cells[rowIndex, 4].Value = row.Cells["NGAYNHAP"].Value.ToString();
                        worksheet.Cells[rowIndex, 5].Value = row.Cells["TONGGIATRI"].Value.ToString();
                    }
                    rowIndex++;
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);

                MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.FileName = "Chi_Tiet_Phieu_Nhap_NL " + textMP.Text.Trim() + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboNCC.Text))
            {
                MessageBox.Show("Chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ngayNhap = dateTimeNhap.Value;
                ngayMua = dateNgayMua.Value;
                maNCC = nhapNguyenLieu.LayMaNCC(comboNCC.Text);

                nhapNguyenLieu.ThemPNNL(mapnnl, maNCC, UserInfo.ManNV, ngayMua);

                btnLapPhieu.Enabled = false;

                dateNgayMua.Enabled = false;
                dateTimeNhap.Enabled = false;
                comboNCC.Enabled = false;

                textMaNL.Enabled = true;
                textTenNL.Enabled = true;
                textDonViTinh.Enabled = true;
                textDonGia.Enabled = true;
                textSoLuong.Enabled = true;



                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
