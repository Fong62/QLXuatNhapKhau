using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXuatNhapKhau 
{
    public partial class FormLapHopDong : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private HopDongBLL hopDongBLL = new HopDongBLL();
        DataTable hopDong;
        public FormLapHopDong()
        {
            InitializeComponent();
        }

        private void LoadSanPham()
        {
            DataTable dt = sanPhamBLL.LaySanPham();
            grid_SP.DataSource = dt;
        }


        private void grid_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTG()
        {
            dtp_NgayGiao.Format = DateTimePickerFormat.Custom;
            dtp_NgayGiao.CustomFormat = "yyyy-MM-dd";


        }

        private void FormLapHopDong_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadTG();
        }

        private void btn_TimKiemSP_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemSP.Text;

                DataTable dt = sanPhamBLL.TimKiemSanPham(search);

                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    grid_SP.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm sản phẩm:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TongGiaTri = 0;

                if (grid_SP.CurrentRow == null || grid_SP.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = grid_SP.CurrentRow.Index;
                string maSP = grid_SP.Rows[i].Cells[0].Value.ToString();
                string tenSP = grid_SP.Rows[i].Cells["TENSP"].Value.ToString();
                string donViTinh = grid_SP.Rows[i].Cells["DONVITINH"].Value.ToString();
                decimal donGia = Convert.ToDecimal(grid_SP.Rows[i].Cells["DONGIA"].Value);
                string soLuong = txt_SoLuong.Text;

                if (string.IsNullOrEmpty(soLuong))
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (grid_HD.DataSource == null)
                {
                    hopDong = new DataTable();
                    hopDong.Columns.Add("MASP", typeof(string));
                    hopDong.Columns.Add("TENSP", typeof(string));
                    hopDong.Columns.Add("DONVITINH", typeof(string));
                    hopDong.Columns.Add("DONGIA", typeof(decimal));
                    hopDong.Columns.Add("SOLUONG", typeof(decimal));
                    hopDong.Columns.Add("TONGTIEN", typeof(decimal));
                    grid_HD.DataSource = hopDong;
                }
                else
                {
                    hopDong = (DataTable)grid_HD.DataSource;
                }

                foreach (DataRow row in hopDong.Rows)
                {
                    if (row["MASP"].ToString() == maSP)
                    {
                        MessageBox.Show("Sản phẩm này đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal soluong = Convert.ToDecimal(soLuong);
                decimal tongTien = donGia * soluong;
                hopDong.Rows.Add(maSP, tenSP, donViTinh, donGia, soluong, tongTien);

                foreach (DataRow row in hopDong.Rows)
                {
                    TongGiaTri += Convert.ToDecimal(row["TONGTIEN"]);
                }

                txt_TongTien.Text = TongGiaTri.ToString();

                MessageBox.Show("Đã thêm sản phẩm vào danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_HD.CurrentRow == null || grid_HD.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable hopDong = grid_HD.DataSource as DataTable;

                if (hopDong == null)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = grid_HD.CurrentRow.Index;
                hopDong.Rows.RemoveAt(i);

                MessageBox.Show("Đã xóa sản phẩm khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_TimKiemKH_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txt_MaKH.Text;
                string hoTenKH = khachHangBLL.LayHoTenKhachHang(maKH);
                txt_HoTenKH.Text = hoTenKH;
                txt_HoTenKH.Enabled = false;
                txt_NoiGiao.Enabled = true;
                cbo_PhuongThucThanhToan.Enabled = true;
                dtp_NgayGiao.Enabled = true;
                txt_ThoiGianGiao.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LapHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = hopDongBLL.TaoMaHopDongMoi();
                string maKH = txt_MaKH.Text;
                string thoigian = txt_ThoiGianGiao.Text;
                string ngaygiao = dtp_NgayGiao.Text;
                string noigiao = txt_NoiGiao.Text;
                string phuongthucthanhtoan = cbo_PhuongThucThanhToan.Text;
                string tongTien = txt_TongTien.Text;

                decimal tongtienHD = Convert.ToDecimal(tongTien);

                string thoiGianGiao = ngaygiao + " " + thoigian;
                DateTime thoigianGiao = Convert.ToDateTime(thoiGianGiao);


                int resultThemHopDong = hopDongBLL.ThemHopDong(maHD, UserInfo.ManNV, maKH, thoigianGiao, noigiao, phuongthucthanhtoan, tongtienHD);

                foreach (DataGridViewRow row in grid_HD.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới không có dữ liệu

                    string maSP = row.Cells["MASP"].Value.ToString();
                    decimal soLuong = Convert.ToDecimal(row.Cells["SOLUONG"].Value);
                    decimal tongtienSP = Convert.ToDecimal(row.Cells["TONGTIEN"].Value);

                    int resultThemCTHopDong = hopDongBLL.ThemChiTietHopDong(maHD, maSP, soLuong, tongtienSP);
                }

                if (resultThemHopDong > 0)
                {
                    MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiemSP_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiemSP != null && txt_TimKiemSP.Text == "Mã sản phẩm hoặc tên sản phẩm")
            {
                txt_TimKiemSP.Text = "";
                txt_TimKiemSP.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiemSP_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemSP != null && string.IsNullOrWhiteSpace(txt_TimKiemSP.Text))
            {
                txt_TimKiemSP.Text = "Mã sản phẩm hoặc tên sản phẩm";
                txt_TimKiemSP.ForeColor = Color.Gray;
            }

        }

        private void txt_ThoiGianGiao_Enter(object sender, EventArgs e)
        {
            if (txt_ThoiGianGiao != null && txt_ThoiGianGiao.Text == "12:00")
            {
                txt_ThoiGianGiao.Text = "";
                txt_ThoiGianGiao.ForeColor = Color.Black;
            }
        }

        private void txt_ThoiGianGiao_Leave(object sender, EventArgs e)
        {
            if (txt_ThoiGianGiao != null && string.IsNullOrWhiteSpace(txt_ThoiGianGiao.Text))
            {
                txt_ThoiGianGiao.Text = "12:00"; // Hiển thị lại placeholder nếu trống
                txt_ThoiGianGiao.ForeColor = Color.Gray; // Màu chữ mờ
            }
        }
    }
}
