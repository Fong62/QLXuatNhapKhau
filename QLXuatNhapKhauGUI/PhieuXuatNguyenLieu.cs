using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QLXuatNhapKhau.GUI
{
    public partial class PhieuXuatNguyenLieu : Form
    {
        public PhieuXuatNguyenLieu()
        {
            InitializeComponent();
        }
        NhapSanPham nhapSanPham = new NhapSanPham();
        NhapNguyenLieu nhapNguyenLieu = new NhapNguyenLieu();
        XuatNLBLL xuatNLBLL = new XuatNLBLL();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();

        decimal tonggiatricu = 0;
        decimal soluongcu = 0;
        decimal tongTien = 0;

        string mapxnl;
        string maPX;
        DateTime ngayXuat;

        string maNL;

        private void PhieuXuatNguyenLieu_Load(object sender, EventArgs e)
        {
            List<string> dspx = nhapSanPham.LayDanhSachPX();
            comboPX.Items.Clear();
            foreach (string px in dspx)
            {
                comboPX.Items.Add(px);
            }
            grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
            grid_PX.DataSource = xuatNLBLL.LayCTPhieuXuatNL();

            textNV.Text = nhanVienBLL.LayTenNhanVien(UserInfo.ManNV);
            mapxnl = xuatNLBLL.TaoMaPXNLMoi();
            textMP.Text = mapxnl;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!decimal.TryParse(textSoLuong.Text, out decimal soluong) || soluong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(textDonGia.Text, out decimal dongia) || dongia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal tonggia = soluong * dongia;
                tongTien += tonggia;

                decimal soluonghienco = xuatNLBLL.SLNL(textMaNL.Text);

                decimal soluongmoi = soluonghienco - soluong;
                
                if (soluonghienco - soluong < 0)
                {
                    MessageBox.Show("Số lượng không đủ để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                xuatNLBLL.UpdatePXNL(mapxnl, tongTien);

                xuatNLBLL.TaoChiTietPX(textMaNL.Text, mapxnl, soluong, tonggia);

                xuatNLBLL.CapNhatSLNL(textMaNL.Text, soluongmoi);


                MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapNhat()
        {
            grid_NL.DataSource = nhapNguyenLieu.LayNguyenLieu();
            grid_PX.DataSource = xuatNLBLL.LayCTPhieuXuatNL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DataTable danhSachPXNL = xuatNLBLL.LayCTPXDuaTrenMaPX(textMP.Text);

            if (danhSachPXNL.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào trong phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Duyệt từng sản phẩm trong phiếu mượn và cộng lại số lượng
            foreach (DataRow row in danhSachPXNL.Rows)
            {
                string maNL = row["MANL"].ToString();
                decimal soluongcu = Convert.ToDecimal(row["SOLUONGXUAT"]);
                decimal soluonghienco = xuatNLBLL.SLNL(maNL);

                decimal soluongmoi = soluonghienco + soluongcu;
                xuatNLBLL.CapNhatSLNL(maNL, soluongmoi);
            }

            xuatNLBLL.XoaPhieu(textMP.Text);
            MessageBox.Show("Xóa phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhat();
        }

        private void grid_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textMP.Text = grid_PX.Rows[e.RowIndex].Cells["MAPXUATNL"].Value.ToString();
                textSoLuong.Text = grid_PX.Rows[e.RowIndex].Cells["SOLUONGXUAT"].Value.ToString();
                tonggiatricu = Convert.ToDecimal(grid_PX.Rows[e.RowIndex].Cells["TONGGIATRI"].Value.ToString());
                soluongcu = Convert.ToDecimal(grid_PX.Rows[e.RowIndex].Cells["SOLUONGXUAT"].Value.ToString());
                textMaNL.Text = grid_PX.Rows[e.RowIndex].Cells["MANL"].Value.ToString();
                textDonGia.Text = nhapNguyenLieu.LayDonGia(textMaNL.Text);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal soluong = Convert.ToDecimal(textSoLuong.Text);
            decimal soluonghienco = xuatNLBLL.SLNL(textMaNL.Text);
            decimal kq = soluonghienco + soluongcu - soluong;
            xuatNLBLL.CapNhatSLNL(textMaNL.Text, kq);


            decimal dongia = Convert.ToDecimal(textDonGia.Text);
            decimal tonggiatri = soluong * dongia;
            xuatNLBLL.CapNhatChiTietPX(textMaNL.Text, textMP.Text, soluong, tonggiatri);
            

            decimal tonggiatrimoi = xuatNLBLL.LayTongTien(mapxnl) - tonggiatricu + tonggiatri;
            nhapSanPham.UpdatePNSP(textMP.Text, tonggiatrimoi);
            tongTien = tonggiatrimoi;
            textTongGiaTri.Text = tongTien.ToString();

            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhat();
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
                maPX = nhapSanPham.LayMaPX(comboPX.Text);
                ngayXuat = dateTimeXuat.Value;

                xuatNLBLL.TaoPXNl(mapxnl, maPX, UserInfo.ManNV, ngayXuat);

                dateTimeXuat.Enabled = false;
                comboPX.Enabled = false;

                textMaNL.Enabled = true;
                textSoLuong.Enabled = true;
                textDonGia.Enabled = true;
                textTenNL.Enabled = true;
                textDonViTinh.Enabled = true;

                MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
