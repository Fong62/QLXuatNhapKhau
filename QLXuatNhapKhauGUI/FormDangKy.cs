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
using System.Net;
using System.Net.Mail;
using System.IO.Pipes;
using DAL;
using BLL;
using QLXuatNhapKhau;


namespace QLXuatNhapKhau
{
    public partial class FormDangKy : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        

        public FormDangKy()
        {
            InitializeComponent();
        }

        private bool ValidateInput(string username, string birthdate, string address, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(birthdate) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void XulyChuyenForm()
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string textuser = txt_HoTen.Text;
                string textbirt = txt_SDT.Text;
                string textaddress = txt_DiaChi.Text;
                string textemail = txt_Email.Text;

                if (!ValidateInput(textuser, textbirt, textaddress, textemail))
                {
                    return;
                }

                string maKHMoi = khachHangBLL.TaoMaKhachHangMoi();
                string maTKMoi = taiKhoanBLL.TaoMaTaiKhoanMoi();

                int rowsaffected0 = khachHangBLL.ThemKhachHang(maKHMoi, textuser, textbirt, textaddress, textemail, UserInfo.ManNV);


                string fullName = textuser.Trim();
                string[] nameParts = fullName.Split(' ');

                string firstName = nameParts.Length > 0 ? nameParts[nameParts.Length - 1] : fullName;
                string firstNameUpper = firstName.ToUpper();

                int count = Convert.ToInt32(taiKhoanBLL.LayTaiKhoanDuaTrenTen(firstNameUpper));
                if (count > 0)
                {
                    Random rnd = new Random();
                    firstNameUpper = firstNameUpper + rnd.Next(0, 1000).ToString();
                }

                // Insert into TAI_KHOAN
                int rowsaffected1 = taiKhoanBLL.ThemTaiKhoan(maTKMoi, maKHMoi, firstNameUpper, maKHMoi);

                // Show success message if both operations are successful
                if (rowsaffected0 > 0 && rowsaffected1 > 0)
                {
                    MessageBox.Show($"Đăng ký thành công !\nTài khoản: {firstNameUpper}\nMật khẩu: {maKHMoi}\nHãy đổi mật khẩu ngay !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SendEmail.SendMail(textemail, firstNameUpper, maKHMoi);
                    XulyChuyenForm();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            XulyChuyenForm();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            hellolabel.Text = "Hello " + UserInfo.Username;
        }
    }
}
