using BLL;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXuatNhapKhauGUI
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        private HopDongBLL hopDongBLL = new HopDongBLL();
        private NhapNguyenLieu nhapNguyenLieu = new NhapNguyenLieu();
        private NhapSanPham nhapSanPham = new NhapSanPham();
        private XuatNLBLL xuatNLBLL = new XuatNLBLL();
        private XuatSPBLL xuatSPBLL = new XuatSPBLL();

        string thongTin;
        string ngay;
        string thang;
        string nam;

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            thongTin = cbo_ThongKe.Text;

            if (thongTin == "Hợp Đồng")
            {
                grid_TK.DataSource = hopDongBLL.LayHopDong();
                grid_TKCT.DataSource = hopDongBLL.LayChiTietHopDong();
            }
            if (thongTin == "Phiếu Nhập Nguyên Liệu")
            {
                grid_TK.DataSource = nhapNguyenLieu.LayPhieuNhapNL();
                grid_TKCT.DataSource = nhapNguyenLieu.LayCTPhieuNhapNL();
            }
            if (thongTin == "Phiếu Xuất Nguyên Liệu")
            {
                grid_TK.DataSource = xuatNLBLL.LayPhieuXuatNL();
                grid_TKCT.DataSource = xuatNLBLL.LayCTPhieuXuatNL();
            }
            if (thongTin == "Phiếu Nhập Sản Phẩm")
            {
                grid_TK.DataSource = nhapSanPham.LayPhieuNhapSP();
                grid_TKCT.DataSource = nhapSanPham.LayCTPhieuNhapSP();
            }
            if (thongTin == "Phiếu Xuất Sản Phẩm")
            {
                grid_TK.DataSource = xuatSPBLL.LayPhieuXuatSP();
                grid_TKCT.DataSource = xuatSPBLL.LayCTPhieuXuatSP();
            }
        }

        private void ExportToExcel(string filePath)
        {
            if (cbo_ThongKe.Text == "Hợp Đồng")
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet mới cho hợp đồng
                    ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Hợp Đồng");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Chi Tiết Hợp Đồng");

                    // Xuất tiêu đề cho worksheet 1
                    worksheet1.Cells[1, 1].Value = "Thống Kê Hợp Đồng";
                    worksheet1.Cells[1, 1].Style.Font.Bold = true;
                    worksheet1.Cells[1, 1].Style.Font.Size = 20;
                    worksheet1.Cells[1, 1, 1, 9].Merge = true;
                    worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 1
                    worksheet1.Cells[3, 1].Value = "Mã Hợp Đồng";
                    worksheet1.Cells[3, 2].Value = "Mã Nhân Viên";
                    worksheet1.Cells[3, 3].Value = "Mã Khách Hàng";
                    worksheet1.Cells[3, 4].Value = "Ngày Ký";
                    worksheet1.Cells[3, 5].Value = "Thời Gian Giao";
                    worksheet1.Cells[3, 6].Value = "Nơi Giao";
                    worksheet1.Cells[3, 7].Value = "Phương Thức Thanh Toán";
                    worksheet1.Cells[3, 8].Value = "Trị Giá";
                    worksheet1.Cells[3, 9].Value = "Tình Trạng Hợp Đồng";

                    // Xuất dữ liệu từ grid_HD1
                    int rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TK.Rows)
                    {
                        if (/*row.Cells["MASP"].Value != null &&*/ row.Cells["MAHD"].Value != null)
                        {
                            worksheet1.Cells[rowIndex, 1].Value = row.Cells["MAHD"].Value.ToString();
                            worksheet1.Cells[rowIndex, 2].Value = row.Cells["MANV"].Value.ToString();
                            worksheet1.Cells[rowIndex, 3].Value = row.Cells["MAKH"].Value.ToString();
                            worksheet1.Cells[rowIndex, 4].Value = row.Cells["NGAYKY"].Value.ToString();
                            worksheet1.Cells[rowIndex, 5].Value = row.Cells["THOIGIANGIAO"].Value.ToString();
                            worksheet1.Cells[rowIndex, 6].Value = row.Cells["NOIGIAO"].Value.ToString();
                            worksheet1.Cells[rowIndex, 7].Value = row.Cells["PHUONGTHUCTHANHTOAN"].Value.ToString();
                            worksheet1.Cells[rowIndex, 8].Value = Convert.ToDecimal(row.Cells["TRIGIA"].Value);
                            worksheet1.Cells[rowIndex, 9].Value = row.Cells["TINHTRANGHD"].Value.ToString();
                        }
                        rowIndex++;
                    }

                    // Xuất tiêu đề cho worksheet 2
                    worksheet2.Cells[1, 1].Value = "Thống Kê Chi Tiết Hợp Đồng";
                    worksheet2.Cells[1, 1].Style.Font.Bold = true;
                    worksheet2.Cells[1, 1].Style.Font.Size = 20;
                    worksheet2.Cells[1, 1, 1, 4].Merge = true;
                    worksheet2.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 2
                    worksheet2.Cells[3, 1].Value = "Mã Hợp Đồng";
                    worksheet2.Cells[3, 2].Value = "Mã Sản Phẩm";
                    worksheet2.Cells[3, 3].Value = "Số Lượng";
                    worksheet2.Cells[3, 4].Value = "Tổng Giá Trị";

                    // Xuất dữ liệu từ grid_HD2
                    rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TKCT.Rows)
                    {
                        if (row.Cells["MASP"].Value != null && row.Cells["MAHD"].Value != null)
                        {
                            worksheet2.Cells[rowIndex, 1].Value = row.Cells["MAHD"].Value.ToString();
                            worksheet2.Cells[rowIndex, 2].Value = row.Cells["MASP"].Value.ToString();
                            worksheet2.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONG"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                        }
                        rowIndex++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();
                    worksheet2.Cells[worksheet2.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Dữ liệu hợp đồng đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cbo_ThongKe.Text == "Phiếu Nhập Nguyên Liệu")
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet mới cho hợp đồng
                    ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Phiếu Nhập Nguyên Liệu");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Nhập Nguyên Liệu");

                    // Xuất tiêu đề cho worksheet 1
                    worksheet1.Cells[1, 1].Value = "Thống Kê Phiếu Nhập Nguyên Liệu";
                    worksheet1.Cells[1, 1].Style.Font.Bold = true;
                    worksheet1.Cells[1, 1].Style.Font.Size = 20;
                    worksheet1.Cells[1, 1, 1, 5].Merge = true;
                    worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 1
                    worksheet1.Cells[3, 1].Value = "Mã Phiếu Nhập";
                    worksheet1.Cells[3, 2].Value = "Mã Nhà Cung Cấp";
                    worksheet1.Cells[3, 3].Value = "Mã Nhân Viên";
                    worksheet1.Cells[3, 4].Value = "Ngày Mua";
                    worksheet1.Cells[3, 5].Value = "Tổng Tiền";


                    // Xuất dữ liệu từ grid_HD1
                    int rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TK.Rows)
                    {
                        if (/*row.Cells["MASP"].Value != null &&*/ row.Cells["MAPNHAPNL"].Value != null)
                        {
                            worksheet1.Cells[rowIndex, 1].Value = row.Cells["MAPNHAPNL"].Value.ToString();
                            worksheet1.Cells[rowIndex, 2].Value = row.Cells["MANCC"].Value.ToString();
                            worksheet1.Cells[rowIndex, 3].Value = row.Cells["MANV"].Value.ToString();
                            worksheet1.Cells[rowIndex, 4].Value = row.Cells["NGAYMUA"].Value.ToString();
                            worksheet1.Cells[rowIndex, 5].Value = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                        }
                        rowIndex++;
                    }

                    // Xuất tiêu đề cho worksheet 2
                    worksheet2.Cells[1, 1].Value = "Thống Kê Chi Tiết Phiếu Nhập Nguyên Liệu";
                    worksheet2.Cells[1, 1].Style.Font.Bold = true;
                    worksheet2.Cells[1, 1].Style.Font.Size = 20;
                    worksheet2.Cells[1, 1, 1, 4].Merge = true;
                    worksheet2.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 2
                    worksheet2.Cells[3, 1].Value = "Mã Phiếu Nhập";
                    worksheet2.Cells[3, 2].Value = "Mã Nguyên Liệu";
                    worksheet2.Cells[3, 3].Value = "Số Lượng Nhập";
                    worksheet2.Cells[3, 4].Value = "Tổng Giá Trị";
                    worksheet2.Cells[3, 5].Value = "Ngày Nhập";

                    // Xuất dữ liệu từ grid_HD2
                    rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TKCT.Rows)
                    {
                        if (row.Cells["MANL"].Value != null && row.Cells["MAPNHAPNL"].Value != null)
                        {
                            worksheet2.Cells[rowIndex, 1].Value = row.Cells["MAPNHAPNL"].Value.ToString();
                            worksheet2.Cells[rowIndex, 2].Value = row.Cells["MANL"].Value.ToString();
                            worksheet2.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONGNHAP"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGGIATRI"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = row.Cells["NGAYNHAP"].Value.ToString();
                        }
                        rowIndex++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();
                    worksheet2.Cells[worksheet2.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Dữ liệu phiếu nhập nguyên liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cbo_ThongKe.Text == "Phiếu Nhập Sản Phẩm")
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet mới cho hợp đồng
                    ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Phiếu Nhập Sản Phẩm");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Nhập Sản Phẩm");

                    // Xuất tiêu đề cho worksheet 1
                    worksheet1.Cells[1, 1].Value = "Thống Kê Phiếu Nhập Sản Phẩm";
                    worksheet1.Cells[1, 1].Style.Font.Bold = true;
                    worksheet1.Cells[1, 1].Style.Font.Size = 20;
                    worksheet1.Cells[1, 1, 1, 5].Merge = true;
                    worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 1
                    worksheet1.Cells[3, 1].Value = "Mã Phiếu Nhập";
                    worksheet1.Cells[3, 2].Value = "Mã Phân Xưởng";
                    worksheet1.Cells[3, 3].Value = "Mã Nhân Viên";
                    worksheet1.Cells[3, 4].Value = "Ngày Nhập";
                    worksheet1.Cells[3, 5].Value = "Tổng Tiền";


                    // Xuất dữ liệu từ grid_HD1
                    int rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TK.Rows)
                    {
                        if (/*row.Cells["MASP"].Value != null &&*/ row.Cells["MAPNHAPSP"].Value != null)
                        {
                            worksheet1.Cells[rowIndex, 1].Value = row.Cells["MAPNHAPSP"].Value.ToString();
                            worksheet1.Cells[rowIndex, 2].Value = row.Cells["MAPX"].Value.ToString();
                            worksheet1.Cells[rowIndex, 3].Value = row.Cells["MANV"].Value.ToString();
                            worksheet1.Cells[rowIndex, 4].Value = row.Cells["NGAYNHAP"].Value.ToString();
                            worksheet1.Cells[rowIndex, 5].Value = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                        }
                        rowIndex++;
                    }

                    // Xuất tiêu đề cho worksheet 2
                    worksheet2.Cells[1, 1].Value = "Thống Kê Chi Tiết Phiếu Nhập Sản Phẩm";
                    worksheet2.Cells[1, 1].Style.Font.Bold = true;
                    worksheet2.Cells[1, 1].Style.Font.Size = 20;
                    worksheet2.Cells[1, 1, 1, 4].Merge = true;
                    worksheet2.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 2
                    worksheet2.Cells[3, 1].Value = "Mã Sản Phẩm";
                    worksheet2.Cells[3, 2].Value = "Mã Phiếu Nhập";
                    worksheet2.Cells[3, 3].Value = "Số Lượng Nhập";
                    worksheet2.Cells[3, 4].Value = "Tổng Giá Trị";
                    worksheet2.Cells[3, 5].Value = "Ngày Nhập";

                    // Xuất dữ liệu từ grid_HD2
                    rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TKCT.Rows)
                    {
                        if (row.Cells["MASP"].Value != null && row.Cells["MAPNHAPSP"].Value != null)
                        {
                            worksheet2.Cells[rowIndex, 1].Value = row.Cells["MASP"].Value.ToString();
                            worksheet2.Cells[rowIndex, 2].Value = row.Cells["MAPNHAPSP"].Value.ToString();
                            worksheet2.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONGNHAP"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGGIATRI"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = row.Cells["NGAYNHAP"].Value.ToString();
                        }
                        rowIndex++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();
                    worksheet2.Cells[worksheet2.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Dữ liệu phiếu nhập sản phẩm đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cbo_ThongKe.Text == "Phiếu Xuất Nguyên Liệu")
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet mới cho hợp đồng
                    ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Phiếu Xuất Nguyên Liệu");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Xuất Nguyên Liệu");

                    // Xuất tiêu đề cho worksheet 1
                    worksheet1.Cells[1, 1].Value = "Thống Kê Phiếu Xuất Nguyên Liệu";
                    worksheet1.Cells[1, 1].Style.Font.Bold = true;
                    worksheet1.Cells[1, 1].Style.Font.Size = 20;
                    worksheet1.Cells[1, 1, 1, 5].Merge = true;
                    worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 1
                    worksheet1.Cells[3, 1].Value = "Mã Phiếu Xuất";
                    worksheet1.Cells[3, 2].Value = "Mã Phân Xưởng";
                    worksheet1.Cells[3, 3].Value = "Mã Nhân Viên";
                    worksheet1.Cells[3, 4].Value = "Ngày Xuất";
                    worksheet1.Cells[3, 5].Value = "Tổng Tiền";


                    // Xuất dữ liệu từ grid_HD1
                    int rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TK.Rows)
                    {
                        if (/*row.Cells["MASP"].Value != null &&*/ row.Cells["MAPXUATNL"].Value != null)
                        {
                            worksheet1.Cells[rowIndex, 1].Value = row.Cells["MAPXUATNL"].Value.ToString();
                            worksheet1.Cells[rowIndex, 2].Value = row.Cells["MAPX"].Value.ToString();
                            worksheet1.Cells[rowIndex, 3].Value = row.Cells["MANV"].Value.ToString();
                            worksheet1.Cells[rowIndex, 4].Value = row.Cells["NGAYXUAT"].Value.ToString();
                            worksheet1.Cells[rowIndex, 5].Value = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                        }
                        rowIndex++;
                    }

                    // Xuất tiêu đề cho worksheet 2
                    worksheet2.Cells[1, 1].Value = "Thống Kê Chi Tiết Phiếu Xuất Nguyên Liệu";
                    worksheet2.Cells[1, 1].Style.Font.Bold = true;
                    worksheet2.Cells[1, 1].Style.Font.Size = 20;
                    worksheet2.Cells[1, 1, 1, 4].Merge = true;
                    worksheet2.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 2
                    worksheet2.Cells[3, 1].Value = "Mã Nguyên Liệu";
                    worksheet2.Cells[3, 2].Value = "Mã Phiếu Xuất";
                    worksheet2.Cells[3, 3].Value = "Số Lượng Xuất";
                    worksheet2.Cells[3, 4].Value = "Tổng Giá Trị";

                    // Xuất dữ liệu từ grid_HD2
                    rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TKCT.Rows)
                    {
                        if (row.Cells["MANL"].Value != null && row.Cells["MAPXUATNL"].Value != null)
                        {
                            worksheet2.Cells[rowIndex, 1].Value = row.Cells["MANL"].Value.ToString();
                            worksheet2.Cells[rowIndex, 2].Value = row.Cells["MAPXUATNL"].Value.ToString();
                            worksheet2.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONGXUAT"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGGIATRI"].Value);
                        }
                        rowIndex++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();
                    worksheet2.Cells[worksheet2.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Dữ liệu phiếu xuất nguyên liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (cbo_ThongKe.Text == "Phiếu Xuất Sản Phẩm")
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet mới cho hợp đồng
                    ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets.Add("Phiếu Xuất Sản Phẩm");
                    ExcelWorksheet worksheet2 = excelPackage.Workbook.Worksheets.Add("Chi Tiết Phiếu Xuất Sản Phẩm");

                    // Xuất tiêu đề cho worksheet 1
                    worksheet1.Cells[1, 1].Value = "Thống Kê Phiếu Xuất Sản Phẩm";
                    worksheet1.Cells[1, 1].Style.Font.Bold = true;
                    worksheet1.Cells[1, 1].Style.Font.Size = 20;
                    worksheet1.Cells[1, 1, 1, 5].Merge = true;
                    worksheet1.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 1
                    worksheet1.Cells[3, 1].Value = "Mã Phiếu Xuất";
                    worksheet1.Cells[3, 2].Value = "Mã Nhân Viên";
                    worksheet1.Cells[3, 3].Value = "Mã Hợp Đồng";
                    worksheet1.Cells[3, 4].Value = "Ngày Xuất";
                    worksheet1.Cells[3, 5].Value = "Tổng Tiền";


                    // Xuất dữ liệu từ grid_HD1
                    int rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TK.Rows)
                    {
                        if (/*row.Cells["MASP"].Value != null &&*/ row.Cells["MAPXUATSP"].Value != null)
                        {
                            worksheet1.Cells[rowIndex, 1].Value = row.Cells["MAPXUATSP"].Value.ToString();
                            worksheet1.Cells[rowIndex, 2].Value = row.Cells["MANV"].Value.ToString();
                            worksheet1.Cells[rowIndex, 3].Value = row.Cells["MAHD"].Value.ToString();
                            worksheet1.Cells[rowIndex, 4].Value = row.Cells["NGAYXUAT"].Value.ToString();
                            worksheet1.Cells[rowIndex, 5].Value = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);
                        }
                        rowIndex++;
                    }

                    // Xuất tiêu đề cho worksheet 2
                    worksheet2.Cells[1, 1].Value = "Thống Kê Chi Tiết Phiếu Xuất Sản Phẩm";
                    worksheet2.Cells[1, 1].Style.Font.Bold = true;
                    worksheet2.Cells[1, 1].Style.Font.Size = 20;
                    worksheet2.Cells[1, 1, 1, 4].Merge = true;
                    worksheet2.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tiêu đề cột cho worksheet 2
                    worksheet2.Cells[3, 1].Value = "Mã Sản Phẩm";
                    worksheet2.Cells[3, 2].Value = "Mã Phiếu Xuất";
                    worksheet2.Cells[3, 3].Value = "Số Lượng Xuất";
                    worksheet2.Cells[3, 4].Value = "Tổng Giá Trị";

                    // Xuất dữ liệu từ grid_HD2
                    rowIndex = 4;
                    foreach (DataGridViewRow row in grid_TKCT.Rows)
                    {
                        if (row.Cells["MASP"].Value != null && row.Cells["MAPXUATSP"].Value != null)
                        {
                            worksheet2.Cells[rowIndex, 1].Value = row.Cells["MASP"].Value.ToString();
                            worksheet2.Cells[rowIndex, 2].Value = row.Cells["MAPXUATSP"].Value.ToString();
                            worksheet2.Cells[rowIndex, 3].Value = Convert.ToDecimal(row.Cells["SOLUONGXUAT"].Value);
                            worksheet2.Cells[rowIndex, 4].Value = Convert.ToDecimal(row.Cells["TONGGIATRI"].Value);
                        }
                        rowIndex++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet1.Cells[worksheet1.Dimension.Address].AutoFitColumns();
                    worksheet2.Cells[worksheet2.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Dữ liệu phiếu xuất sản phẩm đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.FileName = "Thống Kê " + cbo_ThongKe.Text + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }
    }
}
