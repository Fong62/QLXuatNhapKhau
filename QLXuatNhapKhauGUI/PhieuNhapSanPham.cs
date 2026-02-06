using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Drawing.Printing;
using OfficeOpenXml;
using System.Text.RegularExpressions;


namespace QLXuatNhapKhau.GUI
{
    public partial class PhieuNhapSanPham : Form
    {
        public PhieuNhapSanPham()
        {
            InitializeComponent();
        }
        NhapSanPham nhapSanPham = new NhapSanPham();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        bool NewProduct = false;
        
        decimal soluongcu = 0;
        decimal tonggiatricu = 0;
        decimal tongTien = 0;

        string mapnsp;
        DateTime ngayNhap;
        string maPX;

        string maSP;
        string tenSP;
        string soLuong;
        string donGia;
        string donViTinh;

        private void grid_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMaSP.Text = grid_SP.Rows[e.RowIndex].Cells["MASP"].Value.ToString();
                textTenSP.Text = grid_SP.Rows[e.RowIndex].Cells["TENSP"].Value.ToString();
                textSoLuong.Text = grid_SP.Rows[e.RowIndex].Cells["SOLUONG"].Value.ToString();
                textDonGia.Text = grid_SP.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString();
                textDonViTinh.Text = grid_SP.Rows[e.RowIndex].Cells["DONVITINH"].Value.ToString();
            }
        }
        private void grid_PN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMP.Text = grid_PN.Rows[e.RowIndex].Cells["MAPNHAPSP"].Value.ToString();
                textMaSP.Text = grid_PN.Rows[e.RowIndex].Cells["MASP"].Value.ToString();
                textSoLuong.Text = grid_PN.Rows[e.RowIndex].Cells["SOLUONGNHAP"].Value.ToString();
                //textTongGiaTri.Text = grid_PN.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString();
                tonggiatricu = Convert.ToDecimal(grid_PN.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString());
                soluongcu = Convert.ToDecimal(textSoLuong.Text); //SoLuongNhapTrcKhiCapNhat
                textDonGia.Text = nhapSanPham.LayDonGia(textMaSP.Text);
                textTenSP.Text = nhapSanPham.LayTenSP(textMaSP.Text);
            }

        }
        private void PhieuNhapSanPham_Load(object sender, EventArgs e)
        {
            grid_SP.DataSource = nhapSanPham.LaySanPham();
            grid_PN.DataSource = nhapSanPham.LayCTPhieuNhapSP();
            List<string> dsPX = nhapSanPham.LayDanhSachPX();
            comboPX.Items.Clear();
            foreach (string tenpx in dsPX)
            {
                comboPX.Items.Add(tenpx);
            }
            textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);

            mapnsp = nhapSanPham.TaoMaPNSP();
            textMP.Text = mapnsp;
        }
        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Nhập");

                // Xuất tiêu đề
                worksheet.Cells[1, 1].Value = "Chi Tiết Phiếu Nhập Sản Phẩm";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Font.Size = 14;
                worksheet.Cells[1, 1, 1, 5].Merge = true; // Gộp cột
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Xuất tiêu đề các cột
                worksheet.Cells[3, 1].Value = "Mã Sản Phẩm";
                worksheet.Cells[3, 2].Value = "Mã Phiếu Nhập";
                worksheet.Cells[3, 3].Value = "Số Lượng Nhập";
                worksheet.Cells[3, 4].Value = "Ngày Nhập";
                worksheet.Cells[3, 5].Value = "Tổng Giá Trị";

                // Xuất dữ liệu từ DataGridView
                int rowIndex = 4;
                foreach (DataGridViewRow row in grid_PN.Rows)
                {
                    if (row.Cells["MASP"].Value != null && row.Cells["MAPNHAPSP"].Value != null) // Kiểm tra dữ liệu tồn tại
                    {
                        worksheet.Cells[rowIndex, 1].Value = row.Cells["MASP"].Value.ToString();
                        worksheet.Cells[rowIndex, 2].Value = row.Cells["MAPNHAPSP"].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comboPX.Text))
            {
                MessageBox.Show("Chọn phân xưởng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {  
                textMP.Text = mapnsp;

                ngayNhap = dateTimeNhap.Value;
                maPX = nhapSanPham.LayMaPX(comboPX.Text);

                maSP = textMaSP.Text;
                tenSP = textTenSP.Text;
                soLuong = textSoLuong.Text;
                donGia = textDonGia.Text;
                donViTinh = textDonViTinh.Text;

                int rowsSP = nhapSanPham.CheckMaSP(textMaSP.Text);
                bool NewProduct = rowsSP == 0;

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
                
                decimal tonggiatrinhap = soluong * dongia;

                tongTien += Convert.ToDecimal(tonggiatrinhap);

                textTongGiaTri.Text = tongTien.ToString();

                decimal tongtien = Convert.ToDecimal(textTongGiaTri.Text);

                if (NewProduct)
                {
                    nhapSanPham.ThemSP(maSP, tenSP, donViTinh, dongia, soluong);

                    nhapSanPham.ThemCTPNSP(maSP, mapnsp, soluong, tonggiatrinhap, ngayNhap);

                    nhapSanPham.UpdatePNSP(mapnsp, tongtien);
                }
                else
                {
                    decimal tongsoluong = soluong + nhapSanPham.LaySoLuongSp(maSP);
                    nhapSanPham.UpdateSP(maSP, tongsoluong, dongia, tenSP);

                    nhapSanPham.ThemCTPNSP(maSP, mapnsp, soluong, tonggiatrinhap, ngayNhap);

                    nhapSanPham.UpdatePNSP(mapnsp, tongtien);
                }


                grid_SP.DataSource = nhapSanPham.LaySanPham();
                grid_PN.DataSource = nhapSanPham.LayCTPhieuNhapSP();

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

                DataTable danhSachSanPham = nhapSanPham.LayCTPNDuaTrenMaPN(textMP.Text);

                if (danhSachSanPham.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào trong phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Duyệt từng sản phẩm trong phiếu mượn và cộng lại số lượng
                foreach (DataRow row in danhSachSanPham.Rows)
                {
                    string maSP = row["MASP"].ToString();
                    decimal soluongcu = Convert.ToDecimal(row["SOLUONGNHAP"]);
                    decimal soluong = nhapSanPham.LaySoLuongSp(maSP);

                    decimal soluongmoi = soluong - soluongcu;
                    nhapSanPham.UpdateSP(textMaSP.Text, soluongmoi, dongia, textTenSP.Text);
                }

                nhapSanPham.XoaPhieuNhap(textMP.Text);

                

                if (success)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu hiển thị
                    grid_SP.DataSource = nhapSanPham.LaySanPham();
                    grid_PN.DataSource = nhapSanPham.LayCTPhieuNhapSP();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu nhập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DateTime ngayNhap = dateTimeNhap.Value;

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

            decimal soluongmoi = nhapSanPham.LaySoLuongSp(textMaSP.Text) - soluongcu + soluong;
            nhapSanPham.UpdateSP(textMaSP.Text, soluongmoi, dongia, textTenSP.Text);

            decimal tonggiatrinhap = soluong * dongia;
            nhapSanPham.UpdateCTPNSP(textMaSP.Text, textMP.Text, soluong, tonggiatrinhap, ngayNhap);

            decimal tonggiatrimoi = nhapSanPham.LayTongTien(mapnsp) - tonggiatricu + tonggiatrinhap;
            nhapSanPham.UpdatePNSP(textMP.Text, tonggiatrimoi);
            tongTien = tonggiatrimoi;
            textTongGiaTri.Text = tongTien.ToString();

            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_SP.DataSource = nhapSanPham.LaySanPham();
            grid_PN.DataSource = nhapSanPham.LayCTPhieuNhapSP();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.FileName = "Chi_Tiet_Phieu_Nhap_San_Pham " + textMP.Text.Trim() + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboPX.Text))
            {
                MessageBox.Show("Chọn phân xưởng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ngayNhap = dateTimeNhap.Value;
                maPX = nhapSanPham.LayMaPX(comboPX.Text);

                nhapSanPham.ThemPNSP(mapnsp, maPX, UserInfo.ManNV, ngayNhap);

                btnLapPhieu.Enabled = false;

                dateTimeNhap.Enabled = false;
                comboPX.Enabled = false;

                textMaSP.Enabled = true;
                textTenSP.Enabled = true;
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
