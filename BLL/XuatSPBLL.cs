using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Azure.Core.Pipeline;

namespace BLL
{
    public class XuatSPBLL
    {
        DataAccess dataAccess = new DataAccess();
        public string TaoMaPXSPMoi()
        {
            string query = "SELECT TOP 1 MAPXUATSP FROM PHIEU_XUAT_SAN_PHAM ORDER BY MAPXUATSP DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(4));
                return "PXSP" + (lastNumber + 1).ToString("D2");
            }
            return "PXSP01";
        }
        public List<string> LayDanhSachMaHD(string makh)
        {
            string query = "SELECT MAHD FROM HOP_DONG WHERE MAKH = @MAKH; ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAKH",makh)
            };

            DataTable dsmahd = dataAccess.ExecuteQuery(query, parameters);


            List<string> dsMAHD = new List<string>();
            foreach (DataRow row in dsmahd.Rows)
            {
                dsMAHD.Add(row["MAHD"].ToString());
            }

            return dsMAHD;
        }

        public DataTable LayPhieuXuatSP()
        {
            string query = "SELECT * FROM PHIEU_XUAT_SAN_PHAM";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPhieuXuatSP()
        {
            string query = "SELECT * FROM CHI_TIET_XUAT_SAN_PHAM";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPXDuaTrenMaPX(string maPX)
        {
            string query = "SELECT * FROM CHI_TIET_XUAT_SAN_PHAM WHERE MAPXUATSP = @MAPXUATSP";
            SqlParameter[] parameters = { new SqlParameter("@MAPXUATSP", maPX) };
            return dataAccess.ExecuteQuery(query, parameters);
        }

        public List<string> LayDanhSachMaSP(string mahd)
        {
            string query = "SELECT MASP \r\nFROM CHI_TIET_HOP_DONG \r\nWHERE MAHD = @MAHD \r\nAND MASP NOT IN (\r\n    SELECT CTX.MASP \r\n    FROM CHI_TIET_XUAT_SAN_PHAM CTX\r\n    JOIN PHIEU_XUAT_SAN_PHAM PX ON CTX.MAPXUATSP = PX.MAPXUATSP\r\n    WHERE PX.MAHD = @MAHD) ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAHD",mahd)
            };

            DataTable dsmasp = dataAccess.ExecuteQuery(query, parameters);


            List<string> dsMASP = new List<string>();
            foreach (DataRow row in dsmasp.Rows)
            {
                dsMASP.Add(row["MASP"].ToString());
            }

            return dsMASP;
        }
        public decimal LaySoLuongSPHD(string mahd, string masp)
        {
            string query = "SELECT SOLUONG FROM CHI_TIET_HOP_DONG WHERE MAHD = @MAHD AND MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@MAHD",mahd),
                new SqlParameter("@MASP",masp)
           };
            return (decimal)dataAccess.ExecuteScalar(query, parameters);
        }
        public string NoiGiao(string mahd)
        {
            string query = "SELECT NOIGIAO FROM HOP_DONG WHERE MAHD = @MAHD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAHD",mahd)
            };
            return dataAccess.ExecuteScalar(query, parameters).ToString();
        }
        public DateTime LayNgayGiao(string mahd)
        {
            string query = "SELECT THOIGIANGIAO FROM HOP_DONG WHERE MAHD = @MAHD";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@MAHD",mahd)
           };
            return (DateTime)dataAccess.ExecuteScalar(query, parameters);
        }
        public decimal LayTongTien(string mahd, string masp)
        {
            string query = "SELECT TONGTIEN FROM CHI_TIET_HOP_DONG WHERE MAHD = @MAHD AND MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@MAHD",mahd),
                new SqlParameter("@MASP",masp)
           };
            return (decimal)dataAccess.ExecuteScalar(query, parameters);
        }
        public void ThemPXSP(string mapxsp, string manv, string mahd)
        {
            string query = "INSERT INTO PHIEU_XUAT_SAN_PHAM VALUES (@MAPXUATSP,@MANV,@MAHD,GETDATE(), NULL)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAHD",mahd),
                new SqlParameter("@MAPXUATSP",mapxsp),
                new SqlParameter("@MANV",manv)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void ThemChiTietPXSP(string masp, string mapxsp, decimal soluong, decimal tonggiatri)
        {
            string query = "INSERT INTO CHI_TIET_XUAT_SAN_PHAM VALUES (@MASP,@MAPXUATSP,@SOLUONG,@TONGGIATRI) ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MASP",masp),
                new SqlParameter("@MAPXUATSP",mapxsp),
                new SqlParameter("@SOLUONG",soluong),
                new SqlParameter("@TONGGIATRI",tonggiatri)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public decimal SUMSLXuatCUNG1HD(string mahd)
        {
            string query = @"SELECT 
                         ISNULL(SUM(CTX.SOLUONGXUAT), 0) AS SOLUONG 
                     FROM 
                         PHIEU_XUAT_SAN_PHAM PX
                     LEFT JOIN 
                         CHI_TIET_XUAT_SAN_PHAM CTX 
                     ON 
                         PX.MAPXUATSP = CTX.MAPXUATSP
                     WHERE 
                         PX.MAHD = @MAHD
                     GROUP BY 
                         PX.MAHD;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAHD", mahd)
            };

            object result = dataAccess.ExecuteScalar(query, parameters);
            return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
        }
        public decimal DemSLCanXuat1HD(string mahd) 
        {
            string query = "SELECT SUM(SOLUONG) AS SOLUONGXUAT FROM CHI_TIET_HOP_DONG WHERE MAHD =@MAHD GROUP BY MAHD;";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@MAHD",mahd)
           };
            return (decimal)dataAccess.ExecuteScalar(query, parameters);
        }
        public void CapNhatHopDong(string mahd) 
        {
            string query = "UPDATE HOP_DONG SET TINHTRANGHD =N'Đã giao' WHERE MAHD =@MAHD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAHD",mahd)
            };
            dataAccess.ExecuteNonQuery (query, parameters);
            
        } 
        public string LayMaHD(string mpxsp)
        {
            string query = "SELECT MAHD FROM PHIEU_XUAT_SAN_PHAM WHERE MAPXUATSP = @MAPXUATSP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPXUATSP",mpxsp)
            };
            return dataAccess.ExecuteScalar (query, parameters).ToString();
        }

        public void UpdatePXSP(string mapxsp, decimal tongtien)
        {
            string query = "UPDATE PHIEU_XUAT_SAN_PHAM SET TONGTIEN = @TONGTIEN  WHERE MAPXUATSP = @MAPXSP";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MAPXSP", mapxsp),
            new SqlParameter("@TONGTIEN", tongtien),

            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void XoaPXSP(string mapxsp)
        {
            string query = "delete CHI_TIET_XUAT_SAN_PHAM where MAPXUATSP = @MAPXUATSP\r\ndelete PHIEU_XUAT_SAN_PHAM where MAPXUATSP = @MAPXUATSP";
            SqlParameter[] parameters = new SqlParameter[]
           {
               
                new SqlParameter("@MAPXUATSP",mapxsp),
                
           };   
            dataAccess.ExecuteNonQuery (query, parameters);
        }
    }
}
