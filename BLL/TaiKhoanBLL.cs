using DAL;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        DataAccess dataAccess = new DataAccess();

        public string TaoMaTaiKhoanMoi()
        {
            string query = "SELECT TOP 1 MATK FROM TAI_KHOAN ORDER BY MATK DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(2));
                return "TK" + (lastNumber + 1).ToString("D2");
            }
            return "TK01";
        }
        public string LayLoaiTaiKhoan(string username, string password)
        {
            string query = "SELECT LOAITK FROM TAI_KHOAN WHERE TENDANGNHAP = @username AND MATKHAU = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public string LayMaKhachHang(string username)
        {
            string query = "SELECT MAKH FROM TAI_KHOAN WHERE TENDANGNHAP = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };
            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        public string LayMaNhanVien(string username)
        {
            string query = "SELECT MANV FROM TAI_KHOAN WHERE TENDANGNHAP = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };
            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        public string LayPhongBanNhanVien(string maNhanVien)
        {
            string query = "SELECT PHONGBAN FROM NHAN_VIEN WHERE MANV = @manhanvien";
            SqlParameter[] parameters = {
                new SqlParameter("@manhanvien", maNhanVien)
            };
            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public string LayChucVuNhanVien(string maNhanVien)
        {
            string query = "SELECT CHUCVU FROM NHAN_VIEN WHERE MANV = @manhanvien";
            SqlParameter[] parameters = {
                new SqlParameter("@manhanvien", maNhanVien)
            };
            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        public string LayTaiKhoanDuaTrenTen(string name)
        {
            string query = "SELECT COUNT(*) FROM TAI_KHOAN WHERE TENDANGNHAP= @name";
            SqlParameter[] parameters = { new SqlParameter("@name", name) };

            var result = dataAccess.ExecuteScalar(query, parameters);
            return result?.ToString();
        }


        public int ThemTaiKhoan(string mataikhoan, string makhachhang, string tendangnhap , string matkhau)
        {
            string query = "INSERT INTO TAI_KHOAN (MATK, MAKH, TENDANGNHAP, MATKHAU, LOAITK) VALUES(@mataikhoan ,@makhachhang ,@tendangnhap, @matkhau, 'KhachHang')";
            SqlParameter[] parameters =
            {
                new SqlParameter("@mataikhoan", mataikhoan),
                new SqlParameter("@makhachhang", makhachhang),
                new SqlParameter("@tendangnhap", tendangnhap),
                new SqlParameter("@matkhau", matkhau)
            };
            return dataAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
