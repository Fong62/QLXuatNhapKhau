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
    public partial class FormDanhMucSanPham : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        public FormDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void grid_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadSanPham()
        {
            DataTable dt = sanPhamBLL.LaySanPham();
            grid_SP.DataSource = dt;
        }

        private void DanhMucSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemSP.Text;

                if (!string.IsNullOrEmpty(search) && search == "Mã sản phẩm hoặc tên sản phẩm")
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = sanPhamBLL.TimKiemSanPham(search);
                    grid_SP.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txt_TimKiemSP != null && txt_TimKiemSP.Text == "Mã sản phẩm hoặc tên sản phẩm")
            {
                txt_TimKiemSP.Text = "";
                txt_TimKiemSP.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemSP != null && string.IsNullOrWhiteSpace(txt_TimKiemSP.Text))
            {
                txt_TimKiemSP.Text = "Mã sản phẩm hoặc tên sản phẩm";
                txt_TimKiemSP.ForeColor = Color.Gray;
            }
        }
    }
}
