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
    public partial class FormDanhMucNguyenLieu : Form
    {
        private NguyenLieuBLL nguyenLieuBLL = new NguyenLieuBLL();
        public FormDanhMucNguyenLieu()
        {
            InitializeComponent();
        }

        private void LoadNguyenLieu()
        {
            DataTable dt = nguyenLieuBLL.LayNguyenLieu();
            grid_NL.DataSource = dt;
        }

        private void FormDanhMucNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        private void btn_TimKiemNL_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txt_TimKiemNL.Text;

                if (!string.IsNullOrEmpty(search) && search == "Mã nguyên liệu hoặc tên nguyên liệu")
                {
                    MessageBox.Show("Vui lòng nhập thông tin nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dt = nguyenLieuBLL.TimKiemNguyenLieu(search);
                    grid_NL.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nguyên liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimKiemNL_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiemNL != null && txt_TimKiemNL.Text == "Mã nguyên liệu hoặc tên nguyên liệu")
            {
                txt_TimKiemNL.Text = "";
                txt_TimKiemNL.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiemNL_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiemNL != null && string.IsNullOrWhiteSpace(txt_TimKiemNL.Text))
            {
                txt_TimKiemNL.Text = "Mã nguyên liệu hoặc tên nguyên liệu";
                txt_TimKiemNL.ForeColor = Color.Gray;
            }
        }
    }
}
