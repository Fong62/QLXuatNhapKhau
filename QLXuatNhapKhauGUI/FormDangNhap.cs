using BLL;
using QLXuatNhapKhau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLXuatNhapKhau
{
    public partial class FormDangNhap : Form
    {   
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void XulyChuyenForm()
        {
            this.Hide();
            using (FormMain form =  new FormMain())
            {
                form.ShowDialog();
            }
            this.Close();
        }
        private bool ValidateInput(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            return true;
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            XulyChuyenForm();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textuser = textBox1.Text;
            string textpassword = textBox2.Text;

            ValidateInput(textuser, textpassword);

            string loaitk = taiKhoanBLL.LayLoaiTaiKhoan(textuser, textpassword);

            if (loaitk != null)
            {

                UserInfo.Username = textuser;

                if (loaitk.ToString() == "KhachHang")
                {
                    UserInfo.ChucVu = "Khách hàng";

                    string maKH = taiKhoanBLL.LayMaKhachHang(textuser);

                    if (maKH != null)
                    {
                        UserInfo.MaKH = maKH.ToString();
                        DialogResult result1 = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result1 == DialogResult.OK)
                        {
                            XulyChuyenForm();
                        }
                    }

                }
                else if (loaitk.ToString() == "NhanVien")
                {

                    string manhanvien = taiKhoanBLL.LayMaNhanVien(textuser);
                    UserInfo.ManNV = manhanvien.ToString();

                    if (manhanvien != null)
                    {

                        string chucvu = taiKhoanBLL.LayChucVuNhanVien(manhanvien);
                        string phongBan = taiKhoanBLL.LayPhongBanNhanVien(manhanvien);

                        if (chucvu != null && phongBan != null)
                        {
                            UserInfo.ChucVu = chucvu.ToString();
                            UserInfo.PhongBan = phongBan.ToString();
                            DialogResult result1 = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (result1 == DialogResult.OK)
                            {
                                XulyChuyenForm();
                            }
                        }
                    }
                }
                else if (loaitk.ToString() == "QuanLy")
                {

                    string manhanvien = taiKhoanBLL.LayMaNhanVien(textuser);
                    UserInfo.ManNV = manhanvien.ToString();

                    if (manhanvien != null)
                    {

                        string chucvu = taiKhoanBLL.LayChucVuNhanVien(manhanvien);
                        string phongBan = taiKhoanBLL.LayPhongBanNhanVien(manhanvien);

                        if (chucvu != null && phongBan != null)
                        {
                            UserInfo.ChucVu = chucvu.ToString();
                            UserInfo.PhongBan = phongBan.ToString();
                            DialogResult result1 = MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (result1 == DialogResult.OK)
                            {
                                XulyChuyenForm();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
