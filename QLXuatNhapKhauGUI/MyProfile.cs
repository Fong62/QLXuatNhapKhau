using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QLXuatNhapKhau.GUI
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }
        HoSoCuaToiBLL hoSoCuaToi = new HoSoCuaToiBLL();
        private void MyProfile_Load(object sender, EventArgs e)
        {
            LoadAnh();
            XuLy();
        }
        private void XuLy()
        {
            if (UserInfo.ChucVu == "Nhân viên") {
                try
                {
                    SqlDataReader reader = hoSoCuaToi.DocNV(UserInfo.ManNV);


                    if (reader.Read())
                    {
                        textHoTen.Text = reader["HOTEN"].ToString();
                        textDiaChi.Text = reader["DIACHI"].ToString();
                        textSDT.Text = reader["SDT"].ToString();
                        textChucVu.Text = reader["CHUCVU"].ToString();
                        textPhongBan.Text = reader["PHONGBAN"].ToString();
                        textEmail.Text = reader["EMAIL"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (UserInfo.ChucVu == "Khách hàng")
            {
                try
                {
                    SqlDataReader reader = hoSoCuaToi.DocKh(UserInfo.ManNV);


                    if (reader.Read())
                    {
                        textHoTen.Text = reader["HOTENKH"].ToString();
                        textDiaChi.Text = reader["DIACHI"].ToString();
                        textSDT.Text = reader["SDT"].ToString();
                        textChucVu.Text = "Không có";
                        textPhongBan.Text = "Không có";
                        textEmail.Text = reader["EMAIL"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
        private void LoadAnh()
        {
            string file = "";
            if (UserInfo.ChucVu == "KhachHang")
            {
                file = "KhachHang";
            }
            else file = "NhanVien";
            try
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", file, UserInfo.ManNV.Trim() + ".jpg");
                string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", file, "No_Image.jpg");

                if (File.Exists(imagePath))
                {

                    pictureNhanVien.Image = Image.FromFile(imagePath);
                }
                else if (File.Exists(defaultImagePath))
                {

                    pictureNhanVien.Image = Image.FromFile(defaultImagePath);
                }
                else
                {

                    MessageBox.Show("Không tìm thấy hình ảnh mặc định!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureNhanVien.Image = null;
                }


                pictureNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi tải ảnh nhân viên: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
