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
    public partial class FormDanhMucKhachHang : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        public FormDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void LoadKhachHang()
        {
            DataTable dt = khachHangBLL.LayKhachHang();
            grid_KH.DataSource = dt;
        }

        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btn_TimKiemKH_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemKH.Text;

                if (!string.IsNullOrEmpty(search) && search == "Mã khách hàng hoặc tên khách hàng")
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = khachHangBLL.TimKiemKhachHang(search);
                    grid_KH.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiemKH_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiemKH != null && txt_TimKiemKH.Text == "Mã khách hàng hoặc tên khách hàng")
            {
                txt_TimKiemKH.Text = "";
                txt_TimKiemKH.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiemKH_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemKH != null && string.IsNullOrWhiteSpace(txt_TimKiemKH.Text))
            {
                txt_TimKiemKH.Text = "Mã khách hàng hoặc tên khách hàng";
                txt_TimKiemKH.ForeColor = Color.Gray;
            }
        }
    }
}
