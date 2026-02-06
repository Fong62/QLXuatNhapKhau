using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class XuatNLBLL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable LayPhieuXuatNL()
        {
            string query = "SELECT * FROM PHIEU_XUAT_NGUYEN_LIEU";
            return dataAccess.ExecuteQuery(query);
        }
        public DataTable LayCTPhieuXuatNL()
        {
            string query = "SELECT * FROM CHI_TIET_XUAT_NGUYEN_LIEU";
            return dataAccess.ExecuteQuery(query);
        }
        public string TaoMaPXNLMoi()
        {
            string query = "SELECT TOP 1 MAPXUATNL FROM PHIEU_XUAT_NGUYEN_LIEU ORDER BY MAPXUATNL DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(4));
                return "PXNL" + (lastNumber + 1).ToString("D2");
            }
            return "PXNL01";
        }
        public void TaoPXNl(string mapxuatnl, string mapx, string manv,DateTime ngayxuat)
        {
            string query = "INSERT INTO PHIEU_XUAT_NGUYEN_LIEU VALUES (@mapxuatnl,@mapx,@manv,@ngayxuat, NULL);";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@mapxuatnl",mapxuatnl),
                new SqlParameter("@mapx",mapx),
                new SqlParameter("@manv",manv),
                new SqlParameter("@ngayxuat", ngayxuat)
            };
            dataAccess.ExecuteNonQuery(query, parameter);

        }
        public void TaoChiTietPX(string manl,string mapxuatnl,decimal soluong,decimal TongSo) 
        {
            string query = "INSERT INTO CHI_TIET_XUAT_NGUYEN_LIEU VALUES (@manl,@mapxuatnl,@soluong,@tongso)";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@mapxuatnl",mapxuatnl),
                new SqlParameter("@manl",manl),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@tongso",TongSo)
            };
            dataAccess.ExecuteNonQuery(query, parameter);

        }
        public void UpdatePXNL(string mapxnl, decimal tongtien)
        {
            string query = "UPDATE PHIEU_XUAT_NGUYEN_LIEU SET TONGTIEN = @TONGTIEN  WHERE MAPXUATNL = @MAPXNL";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MAPXNL", mapxnl),
            new SqlParameter("@TONGTIEN", tongtien),

            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void CapNhatSLNL(string manl, decimal soluong) 
        {
            string query = "UPDATE NGUYEN_LIEU SET SOLUONG = @SOLUONG WHERE MANL = @MANL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manl",manl),
                new SqlParameter("@soluong",soluong)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public decimal SLNL(string manl) 
        {
            string query = "SELECT SOLUONG FROM NGUYEN_LIEU WHERE MANL = @MANL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MANL",manl)
            };
            return (decimal)dataAccess.ExecuteScalar(query, parameters);
        }
        public void XoaPhieu(string map)
        {
            string query = "delete CHI_TIET_XUAT_NGUYEN_LIEU where MAPXUATNL = @MAPXUATNL\r\ndelete PHIEU_XUAT_NGUYEN_LIEU where MAPXUATNL = @MAPXUATNL\r\n";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPXUATNL",map)
            };
            dataAccess.ExecuteNonQuery (query, parameters);
        }
        public void CapNhatChiTietPX(string manl, string mapxuatnl, decimal soluong, decimal tongso)
        {
            string query = @"
                UPDATE CHI_TIET_XUAT_NGUYEN_LIEU
                SET SOLUONGXUAT = @soluong, TONGGIATRI = @tongso
                WHERE MANL = @manl AND MAPXUATNL = @mapxuatnl";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manl", manl),
                new SqlParameter("@mapxuatnl", mapxuatnl),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@tongso", tongso)
            };

            dataAccess.ExecuteNonQuery(query, parameters);
        }

        public DataTable LayCTPXDuaTrenMaPX(string maPX)
        {
            string query = "SELECT * FROM CHI_TIET_XUAT_NGUYEN_LIEU WHERE MAPXUATNL = @MAPXUATNL";
            SqlParameter[] parameters = { new SqlParameter("@MAPXUATNL", maPX) };
            return dataAccess.ExecuteQuery(query, parameters);
        }

        public decimal LayTongTien(string mapnnl)
        {
            string query = "SELECT TONGTIEN FROM PHIEU_XUAT_NGUYEN_LIEU WHERE MAPXUATNL = @MAPXUATNL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@MAPXUATNL",mapnnl)
            };
            object result = dataAccess.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToDecimal(result);
        }
    }
}
