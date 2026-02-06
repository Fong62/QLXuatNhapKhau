using QLXuatNhapKhau;
using QLXuatNhapKhau.GUI;
using QLXuatNhapKhauGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXuatNhapKhau
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            PhanQuyen();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDangNhap form = new FormDangNhap())
            {
                form.ShowDialog();
            }
            this.Close();
        }


        private void PhanQuyen()
        {
            helloToolStripMenuItem.Text = "Hello " + UserInfo.Username;
            chucVuToolStripMenuItem.Text = "Chức vụ: " + UserInfo.ChucVu;
            phongBanToolStripMenuItem.Text = "Phòng ban: " + UserInfo.PhongBan;


            nhậpNguyênLiệuToolStripMenuItem.Visible = false;
            xuấtNguyênLiệuToolStripMenuItem.Visible = false;
            nhậpSảnPhẩmToolStripMenuItem.Visible = false;
            xuấtSảnPhẩmToolStripMenuItem.Visible = false;
            btn_LapHopDong.Enabled = false;
            btn_ThongKe.Enabled = false;


            if (!string.IsNullOrEmpty(UserInfo.ManNV))
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngKýToolStripMenuItem.Enabled = false;
            }
            else
            {
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngKýToolStripMenuItem.Enabled = true;
            }

            if (UserInfo.ChucVu == "Nhân viên" || UserInfo.ChucVu == "Khách hàng" || UserInfo.ChucVu == "Quản lý")
            {
                if (UserInfo.PhongBan == "Phòng cung ứng")
                {
                    nhậpNguyênLiệuToolStripMenuItem.Visible = true;
                    xuấtNguyênLiệuToolStripMenuItem.Visible = true;
                    nhậpSảnPhẩmToolStripMenuItem.Visible = true;
                    xuấtSảnPhẩmToolStripMenuItem.Visible = true;
                    btn_LapHopDong.Enabled = false;
                    btn_ThongKe.Enabled = false;
                    đăngXuấtToolStripMenuItem.Enabled = true;
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    danhMụcKháchHàngToolStripMenuItem.Visible = true;
                    danhMụcHợpĐồngToolStripMenuItem.Visible = true;
                    danhMụcNhânViênToolStripMenuItem.Visible = true;
                    danhMụcNguyênLiệuToolStripMenuItem.Visible = true;
                }
                else if (UserInfo.PhongBan == "Phòng kinh doanh")
                {
                    btn_LapHopDong.Enabled = true;
                    btn_ThongKe.Enabled = false ;
                    đăngKýToolStripMenuItem.Enabled = true;
                    đăngXuấtToolStripMenuItem.Enabled = true;
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    danhMụcKháchHàngToolStripMenuItem.Visible = true;
                    danhMụcHợpĐồngToolStripMenuItem.Visible = true;
                    danhMụcNhânViênToolStripMenuItem.Visible = true;
                    danhMụcNguyênLiệuToolStripMenuItem.Visible = true;

                }
                else if (UserInfo.PhongBan == "Phòng kế toán")
                {
                    btn_ThongKe.Enabled = true;
                    đăngXuấtToolStripMenuItem.Enabled = true;
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    danhMụcKháchHàngToolStripMenuItem.Visible = true;
                    danhMụcHợpĐồngToolStripMenuItem.Visible = true;
                    danhMụcNhânViênToolStripMenuItem.Visible = true;
                    danhMụcNguyênLiệuToolStripMenuItem.Visible = true;
                    btn_LapHopDong.Enabled = false;
     
                }
                else if (UserInfo.PhongBan == "Trưởng phòng")
                {
                    nhậpNguyênLiệuToolStripMenuItem.Visible = true;
                    xuấtNguyênLiệuToolStripMenuItem.Visible = true;
                    nhậpSảnPhẩmToolStripMenuItem.Visible = true;
                    xuấtSảnPhẩmToolStripMenuItem.Visible = true;
                    btn_ThongKe.Enabled = true;
                    btn_LapHopDong.Enabled = true;
                    đăngKýToolStripMenuItem.Enabled = true;
                    đăngXuấtToolStripMenuItem.Enabled = true;
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    danhMụcKháchHàngToolStripMenuItem.Visible = true;
                    danhMụcHợpĐồngToolStripMenuItem.Visible = true;
                    danhMụcNhânViênToolStripMenuItem.Visible = true;
                    danhMụcNguyênLiệuToolStripMenuItem.Visible = true;
                }
                else
                {

                    đăngNhậpToolStripMenuItem.Enabled = false;
                    đăngKýToolStripMenuItem.Enabled = false;
                    đăngXuấtToolStripMenuItem.Enabled = true;
                    đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    danhMụcKháchHàngToolStripMenuItem.Visible = false;
                    danhMụcHợpĐồngToolStripMenuItem.Visible = true;
                    danhMụcNhânViênToolStripMenuItem.Visible = false;
                    danhMụcNguyênLiệuToolStripMenuItem.Visible = false;
                    btn_ThongKe .Enabled = false;
                    
                }
            }
            else
            {

                nhậpNguyênLiệuToolStripMenuItem.Visible = false;
                xuấtNguyênLiệuToolStripMenuItem.Visible = false;
                nhậpSảnPhẩmToolStripMenuItem.Visible = false;
                xuấtSảnPhẩmToolStripMenuItem.Visible = false;
                btn_ThongKe.Enabled = false;
                btn_LapHopDong.Enabled = false;
                đăngKýToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;
                danhMụcKháchHàngToolStripMenuItem.Visible = false;
                danhMụcHợpĐồngToolStripMenuItem.Visible= false;
                danhMụcNhânViênToolStripMenuItem.Visible = false;
                danhMụcNguyênLiệuToolStripMenuItem.Visible = false;


            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDangKy form = new FormDangKy())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void btn_LapHopDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormLapHopDong form = new FormLapHopDong())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDanhMucKhachHang form = new FormDanhMucKhachHang())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDanhMucNhanVien form = new FormDanhMucNhanVien())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void danhMụcNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDanhMucNguyenLieu form = new FormDanhMucNguyenLieu())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDanhMucSanPham form = new FormDanhMucSanPham())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void danhMụcHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDanhMucHopDong form = new FormDanhMucHopDong())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void nhậpSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PhieuNhapSanPham form = new PhieuNhapSanPham())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void nhậpNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PhieuNhapNguyenLieu form = new PhieuNhapNguyenLieu())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void xuấtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PhieuXuatSanPham form = new PhieuXuatSanPham())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void hồSơCủaTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MyProfile form = new MyProfile())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void xuấtNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PhieuXuatNguyenLieu form = new PhieuXuatNguyenLieu())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo.PhongBan = null;
            UserInfo.Username = null;
            UserInfo.ChucVu = null;
            UserInfo.ManNV = null;
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormThongKe form = new FormThongKe())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormDoiMk form = new FormDoiMk()) 
            {
                form.ShowDialog();
            }
            this.Show();
            
        }

        private void mainToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
