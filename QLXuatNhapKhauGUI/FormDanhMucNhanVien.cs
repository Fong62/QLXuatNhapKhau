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
    public partial class FormDanhMucNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public FormDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void LoadNhanVien()
        {
            DataTable dt = nhanVienBLL.LayNhanVien();
            grid_NV.DataSource = dt;
        }
        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemNV.Text;
                string phongban = cbo_PhongBanNV.Text;

                if (!string.IsNullOrEmpty(search) && string.IsNullOrEmpty(phongban) && search == "Mã nhân viên hoặc tên nhân viên")
                {
                    MessageBox.Show("Vui lòng nhập thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = nhanVienBLL.TimKiemNhanVien(search, phongban);
                    grid_NV.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiemNV_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiemNV != null && txt_TimKiemNV.Text == "Mã nhân viên hoặc tên nhân viên")
            {
                txt_TimKiemNV.Text = "";
                txt_TimKiemNV.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiemNV_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemNV != null && string.IsNullOrWhiteSpace(txt_TimKiemNV.Text))
            {
                txt_TimKiemNV.Text = "Mã nhân viên hoặc tên nhân viên";
                txt_TimKiemNV.ForeColor = Color.Gray;
            }
        }
    }
}
