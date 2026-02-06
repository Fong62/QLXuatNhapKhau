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
    public partial class FormDanhMucHopDong : Form
    {
        private HopDongBLL hopDongBLL = new HopDongBLL();
        public FormDanhMucHopDong()
        {
            InitializeComponent();
        }

        private void PhanQuyen()
        {
            if (UserInfo.ChucVu == "Khách hàng")
            {
                btn_TimKiemHD.Enabled = false;
                txt_TimKiemHD.Enabled=false;
                grid_HD.DataSource = hopDongBLL.LayHopDongMaKH(UserInfo.MaKH);
            }
            else
            {
                grid_HD.DataSource = hopDongBLL.LayHopDong();
            }
        }

        private void LoadHopDong()
        {
            DataTable dt = hopDongBLL.LayHopDong();
            grid_HD.DataSource = dt;
        }

        private void DanhMucHopDong_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            LoadHopDong();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemHD.Text;

                if (!string.IsNullOrEmpty(search) && search == "Mã hợp đồng hoặc mã khách hàng")
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = hopDongBLL.TimKiemHopDong(search);
                    grid_HD.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hợp đồng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiemHD != null && txt_TimKiemHD.Text == "Mã hợp đồng hoặc mã khách hàng")
            {
                txt_TimKiemHD.Text = "";
                txt_TimKiemHD.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemHD != null && string.IsNullOrWhiteSpace(txt_TimKiemHD.Text))
            {
                txt_TimKiemHD.Text = "Mã hợp đồng hoặc mã khách hàng";
                txt_TimKiemHD.ForeColor = Color.Gray;
            }
        }
    }
}
