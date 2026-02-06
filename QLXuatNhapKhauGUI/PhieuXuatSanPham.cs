using OfficeOpenXml;
using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using Microsoft.Identity.Client.Extensions.Msal;
using System.Runtime.CompilerServices;

namespace QLXuatNhapKhau.GUI
{
    public partial class PhieuXuatSanPham : Form
    {
        public PhieuXuatSanPham()
        {
            InitializeComponent();
        }
        XuatSPBLL xuatSPBLL = new XuatSPBLL();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        NhapSanPham NhapSanPham = new NhapSanPham();

        decimal tonggiatricu = 0;
        decimal tongTien = 0;

        string mapxsp;

        string maSP;
        string soLuong;
        string donGia;
        string maHD;


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            comboMaHD.Enabled = true;
            

            List<string> dshd = xuatSPBLL.LayDanhSachMaHD(textMaKH.Text);
            comboMaHD.Items.Clear();
            foreach (string hd in dshd)
            {
                comboMaHD.Items.Add(hd);
            }
        }

        private void comboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> dsmasp = xuatSPBLL.LayDanhSachMaSP(comboMaHD.Text);
            comboMaSP.Items.Clear();
            foreach (string sp in dsmasp)
            {
                comboMaSP.Items.Add(sp);
            }
        }

        private void comboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masp = comboMaSP.Text;
            textSoLuong.Text = xuatSPBLL.LaySoLuongSPHD(comboMaHD.Text, masp).ToString();
            dateTimeXuat.Value = xuatSPBLL.LayNgayGiao(comboMaHD.Text);
            textNoiGiao.Text = xuatSPBLL.NoiGiao(comboMaHD.Text).ToString();
            textTenSP.Text = NhapSanPham.LayTenSP(comboMaSP.Text);
            textDonGia.Text = NhapSanPham.LayDonGia(comboMaSP.Text);
            textDonViTinh.Text = NhapSanPham.LayDVTinh(comboMaSP.Text);
        }

        private void PhieuXuatSanPham_Load(object sender, EventArgs e)
        {
            grid_SP.DataSource = NhapSanPham.LaySanPham();
            grid_PX.DataSource = xuatSPBLL.LayCTPhieuXuatSP();
            textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);

            mapxsp = xuatSPBLL.TaoMaPXSPMoi();
            textMP.Text = mapxsp;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maHD = comboMaHD.Text;
            maSP = comboMaSP.Text;
            soLuong = textSoLuong.Text;
            donGia = textDonGia.Text;

            decimal soluongcanxuat = xuatSPBLL.DemSLCanXuat1HD(maHD);

            decimal soluongsp = NhapSanPham.LaySoLuongSp(maSP);
            decimal soluonghd = Convert.ToDecimal(soLuong);

            decimal dongia = Convert.ToDecimal(donGia);

            decimal tongGiaTri = soluonghd * dongia;

            tongTien += tongGiaTri;
            textTongGiaTri.Text = tongTien.ToString();

            decimal kq = soluongsp - soluonghd;

            if (kq >= 0)
            {
                NhapSanPham.UpdateSLSP(maSP, kq);

                xuatSPBLL.UpdatePXSP(mapxsp, tongTien);
                xuatSPBLL.ThemChiTietPXSP(maSP, mapxsp, soluonghd, tongGiaTri);

                decimal soluongpxdaxuat = xuatSPBLL.SUMSLXuatCUNG1HD(maHD);

                if (soluongpxdaxuat == soluongcanxuat)
                {
                    xuatSPBLL.CapNhatHopDong(maHD);
                }
                MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grid_SP.DataSource = NhapSanPham.LaySanPham();
                grid_PX.DataSource = xuatSPBLL.LayCTPhieuXuatSP();
                textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);
            }
            else MessageBox.Show("Không hợp lệ hãy nhập thêm sản phẩm !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            
            DataTable danhSachSanPham = xuatSPBLL.LayCTPXDuaTrenMaPX(textMP.Text);

            if (danhSachSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào trong phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Duyệt từng sản phẩm trong phiếu mượn và cộng lại số lượng
            foreach (DataRow row in danhSachSanPham.Rows)
            {
                string maSP = row["MASP"].ToString();
                decimal soluonghd = Convert.ToDecimal(row["SOLUONGXUAT"]);
                decimal soluongsp = NhapSanPham.LaySoLuongSp(maSP);

                // Cộng lại số lượng sản phẩm vào kho
                decimal kq = soluongsp + soluonghd;
                NhapSanPham.UpdateSLSP(maSP, kq); // Cập nhật lại số lượng trong kho
            }
            xuatSPBLL.XoaPXSP(textMP.Text);

            MessageBox.Show("Xóa thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_SP.DataSource = NhapSanPham.LaySanPham();
            grid_PX.DataSource = xuatSPBLL.LayCTPhieuXuatSP();
            textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);
            return;
        }

        private void grid_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMP.Text = grid_PX.Rows[e.RowIndex].Cells["MAPXUATSP"].Value.ToString();
                comboMaSP.Text = grid_PX.Rows[e.RowIndex].Cells["MASP"].Value.ToString();
                textSoLuong.Text = grid_PX.Rows[e.RowIndex].Cells["SOLUONGXUAT"].Value.ToString();
                textTongGiaTri.Text = grid_PX.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString();
                comboMaHD.Text = xuatSPBLL.LayMaHD(textMP.Text);
            }
        }
        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Xuất");

                // Xuất tiêu đề
                worksheet.Cells[1, 1].Value = "Chi Tiết Phiếu Xuất Sản Phẩm";
                worksheet.Cells[1, 1].Style.Font.Bold = true;
                worksheet.Cells[1, 1].Style.Font.Size = 14;
                worksheet.Cells[1, 1, 1, 4].Merge = true; // Gộp cột
                worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Xuất tiêu đề các cột
                worksheet.Cells[3, 1].Value = "Mã Sản Phẩm";
                worksheet.Cells[3, 2].Value = "Mã Phiếu Xuất";
                worksheet.Cells[3, 3].Value = "Số Lượng Xuất";
                worksheet.Cells[3, 4].Value = "Tổng Giá Trị";

                // Xuất dữ liệu từ DataGridView
                int rowIndex = 4;
                foreach (DataGridViewRow row in grid_PX.Rows)
                {
                    if (row.Cells["MASP"].Value != null && row.Cells["MAPXUATSP"].Value != null) // Kiểm tra dữ liệu tồn tại
                    {
                        worksheet.Cells[rowIndex, 1].Value = row.Cells["MASP"].Value.ToString();
                        worksheet.Cells[rowIndex, 2].Value = row.Cells["MAPXUATSP"].Value.ToString();
                        worksheet.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONGXUAT"].Value);
                        worksheet.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGGIATRI"].Value);
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
                saveFileDialog.FileName = "Chi_Tiet_Phieu_Xuat_San_Pham " + textMP.Text.Trim() + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                maHD = comboMaHD.Text;

                xuatSPBLL.ThemPXSP(mapxsp, UserInfo.ManNV, maHD);

                btnLapPhieu.Enabled = false;
                comboMaSP.Enabled = true;

                dateTimeXuat.Enabled = false;
                textMaKH.Enabled = true;

                textDonViTinh.Enabled = true;
                textDonGia.Enabled = true;
                textSoLuong.Enabled = true;
                textNoiGiao.Enabled = true;



                MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
