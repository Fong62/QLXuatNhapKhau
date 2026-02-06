using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {
        DataAccess dataAccess = new DataAccess();

        public string TaoMaHopDongMoi()
        {
            string query = "SELECT TOP 1 MAHD FROM HOP_DONG ORDER BY MAHD DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(2));
                return "HD" + (lastNumber + 1).ToString("D2");
            }
            return "HD01";
        }

        public int ThemHopDong(string maHD, string maNV, string maKH, DateTime thoiGianGiao, string noiGiao, string phuongThucThanhToan, decimal triGia)
        {
            string query = "Insert into HOP_DONG Values (@maHD, @maNV, @maKH, GetDate(), @thoiGianGiao, @noiGiao, @phuongThucThanhToan, @triGia, N'Chưa giao')";

            SqlParameter[] parameters =
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@maKH", maKH),
                new SqlParameter("@thoiGianGiao", thoiGianGiao),
                new SqlParameter("@noiGiao", noiGiao),
                new SqlParameter("@phuongThucThanhToan", phuongThucThanhToan),
                new SqlParameter("@triGia", triGia)
            };

            return dataAccess.ExecuteNonQuery(query, parameters);
        }

        public int ThemChiTietHopDong(string maHD, string maSP, decimal soLuong, decimal tongTien)
        {
            string query = "Insert into CHI_TIET_HOP_DONG Values (@maHD, @maSP, @soLuong, @tongTien)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@maSP", maSP),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter("@tongTien", tongTien)
            };

            return dataAccess.ExecuteNonQuery(query, parameters);
        }

        public DataTable LayHopDong()
        {
            string query = "Select * from HOP_DONG";

            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayHopDongMaKH(string maKH)
        {
            string query = "Select * from HOP_DONG WHERE MAKH = @MAKH";
            SqlParameter[] parameters = { new SqlParameter("@MAKH", maKH) };

            return dataAccess.ExecuteQuery(query, parameters);
        }

        public DataTable TimKiemHopDong(string search)
        {
            string query = "SELECT * FROM HOP_DONG WHERE MAHD = @search OR MAKH = @search";
            SqlParameter[] parameters = { new SqlParameter("@search", search) };

            return dataAccess.ExecuteQuery(query, parameters);
        }

        public DataTable LayChiTietHopDong()
        {
            string query = "Select * from CHI_TIET_HOP_DONG";

            return dataAccess.ExecuteQuery(query);
        }
    }
}
