using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        DataAccess dataAccess = new DataAccess();

        public string TaoMaKhachHangMoi()
        {
            string query = "SELECT TOP 1 MAKH FROM KHACH_HANG ORDER BY MAKH DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(2));
                return "KH" + (lastNumber + 1).ToString("D2");
            }
            return "KH01";
        }

        public DataTable LayKhachHang()
        {
            string query = "Select * from KHACH_HANG";

            return dataAccess.ExecuteQuery(query);
        }

        public DataTable TimKiemKhachHang(string search)
        {
            string query = "SELECT * FROM KHACH_HANG WHERE MAKH = @search OR HOTENKH LIKE N'%' + @search + '%' ";
            SqlParameter[] parameters = { new SqlParameter("@search", search) };

            return dataAccess.ExecuteQuery(query, parameters);
        }

        public SqlDataReader DocKhachHang(string makhachhang)
        {
            string query = "SELECT * FROM KHACH_HANG WHERE MAKH = @makhachhang";
            SqlParameter[] parameters = { new SqlParameter("@makhachhang", makhachhang) };

            return dataAccess.ExecuteReader(query, parameters);
        }

        public string LayHoTenKhachHang(string makhachhang)
        {
            string query = @"Select HOTENKH from KHACH_HANG Where MAKH = @makhachhang";
            SqlParameter[] parameters = { (new SqlParameter("@makhachhang", makhachhang)) };

            return dataAccess.ExecuteScalar(query, parameters)?.ToString();
        }

        public int ThemKhachHang(string makhachhang, string hoten, string sdt, string diachi, string textemail, string manhanvien)
        {
            string query = "INSERT INTO KHACH_HANG VALUES (@makhachhang, @hoten, @sdt, @diachi, @email, @manhanvien)";
            SqlParameter[] parameters =
            {   
                new SqlParameter("@makhachhang", makhachhang),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@email", textemail),
                new SqlParameter("@manhanvien", manhanvien)
            };
            return dataAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
