using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DAL;
using System.Data;


namespace BLL
{
    public class NhapSanPham
    {
        DataAccess dataAccess = new DataAccess();   
        public DataTable LaySanPham() 
        {
            string query = "SELECT * FROM SAN_PHAM";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayPhieuNhapSP()
        {
            string query = "SELECT * FROM PHIEU_NHAP_SAN_PHAM";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPhieuNhapSP()
        {
            string query = "SELECT * FROM CHI_TIET_NHAP_SAN_PHAM";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPNDuaTrenMaPN(string maPN)
        {
            string query = "SELECT * FROM CHI_TIET_NHAP_SAN_PHAM WHERE MAPNHAPSP = @MAPNHAPSP";
            SqlParameter[] parameters = { new SqlParameter("@MAPNHAPSP", maPN) };
            return dataAccess.ExecuteQuery(query, parameters);
        }

        public List<string> LayDanhSachPX()
        {
            string query = "SELECT TENPX FROM PHAN_XUONG ";
           

            DataTable khuyenMaiTable = dataAccess.ExecuteQuery(query);

          
            List<string> dsMaKhuyenMai = new List<string>();
            foreach (DataRow row in khuyenMaiTable.Rows)
            {
                dsMaKhuyenMai.Add(row["TENPX"].ToString());
            }

            return dsMaKhuyenMai;
        }
        public string LayDVTinh(string masp)
        {
            string query = "SELECT DONVITINH FROM SAN_PHAM WHERE MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MASP",masp)
            };
            return dataAccess.ExecuteScalar(query, parameters).ToString();
        }
        public string LayMaPX(string tenpx)
        {
            string query = "SELECT MAPX FROM PHAN_XUONG WHERE TENPX = @tenpx";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@tenpx",tenpx)
            };
            return dataAccess.ExecuteScalar (query,parameters).ToString();
        }
        public int CheckMaSP(string masp)
        {
            string query = "SELECT COUNT(*) FROM SAN_PHAM WHERE MASP =@masp";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@masp",masp)
            };
            return (int)dataAccess.ExecuteScalar(query, parameters);
        }
        public string TaoMaPNSP()
        {
            string query = "SELECT TOP 1 MAPNHAPSP FROM PHIEU_NHAP_SAN_PHAM ORDER BY MAPNHAPSP DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(4));
                return "PNSP" + (lastNumber + 1).ToString("D2");
            }
            return "PNSP01";
        }
        public void ThemPNSP(string mapnhapsp,string mapx,string manv, DateTime ngaynhap)
        {
            ngaynhap = ngaynhap.Date;

            string query = "INSERT INTO PHIEU_NHAP_SAN_PHAM VALUES(@MAPNHAPSP,@MAPX,@MANV, @NGAYNHAP, NULL)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPNHAPSP",mapnhapsp),
                new SqlParameter("@MAPX",mapx),
                new SqlParameter("@MANV",manv),
                new SqlParameter("@NGAYNHAP",ngaynhap)
            };
            dataAccess.ExecuteNonQuery (query,parameters);
        }
        public void ThemCTPNSP(string masp, string mapnhapsp,decimal soluong,decimal tonggiatri, DateTime ngaynhap)
        {
            string query = "INSERT INTO CHI_TIET_NHAP_SAN_PHAM VALUES (@MASP,@MAPNHAPSP,@SOLUONG,@TONGGIATRI,@NGAYNHAP)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MASP", masp),
            new SqlParameter("@MAPNHAPSP", mapnhapsp),
            new SqlParameter("@SOLUONG", soluong),
            new SqlParameter("@TONGGIATRI", tonggiatri),
            new SqlParameter("@NGAYNHAP", ngaynhap)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        
        }
        public void ThemSP(string masp, string tensp, string donvitinh, decimal dongia, decimal soluong)
        {
            string query = "INSERT INTO SAN_PHAM VALUES (@MASP,@TENSP,@DONVITINH,@DONGIA,@SOLUONG)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MASP",masp),
                new SqlParameter("@TENSP",tensp),
                new SqlParameter("@DONVITINH",donvitinh),
                new SqlParameter("@DONGIA",dongia),
                new SqlParameter("@SOLUONG",soluong)
            };
            dataAccess.ExecuteNonQuery (query, parameters);
        }
        public void UpdateSP(string masp, decimal soluong, decimal dongia, string tensp) 
        {
            string query = "UPDATE SAN_PHAM SET SOLUONG = @SOLUONG, DONGIA = @DONGIA, TENSP = @TENSP WHERE MASP = @MASP";

           
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MASP", masp),
            new SqlParameter("@SOLUONG", soluong),
            new SqlParameter("@DONGIA", dongia),
            new SqlParameter("@TENSP", tensp)
            };

         
            dataAccess.ExecuteNonQuery(query, parameters);
        }

        public void UpdatePNSP(string mapnsp, decimal tongtien)
        {
            string query = "UPDATE PHIEU_NHAP_SAN_PHAM SET TONGTIEN = @TONGTIEN  WHERE MAPNHAPSP = @MAPNSP";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MAPNSP", mapnsp),
            new SqlParameter("@TONGTIEN", tongtien),

            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public decimal LaySoLuongSp(string masp)
        {
            string query = "SELECT SOLUONG FROM SAN_PHAM WHERE MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MASP", masp) // Đảm bảo biến được truyền vào đúng
            };

            object result = dataAccess.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
            {
                return 0; // Trả về 0 nếu không tìm thấy sản phẩm
            }

            return Convert.ToDecimal(result);
        }
        public void XoaPhieuNhap(string mapnhapsp) 
        {
            string query = "DELETE CHI_TIET_NHAP_SAN_PHAM WHERE MAPNHAPSP =@MAPPNSP\r\nDELETE PHIEU_NHAP_SAN_PHAM WHERE MAPNHAPSP =@MAPPNSP\r\n";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPPNSP",mapnhapsp)
            };
            dataAccess.ExecuteNonQuery (query, parameters);
        }
        public void UpdateCTPNSP(string masp, string mapnhapsp, decimal soluong, decimal tonggiatri, DateTime ngaynhap)
        {
            
            string query = "UPDATE CHI_TIET_NHAP_SAN_PHAM " +
                           "SET SOLUONGNHAP = @SOLUONG, TONGGIATRI = @TONGGIATRI, NGAYNHAP = @NGAYNHAP " +
                           "WHERE MASP = @MASP AND MAPNHAPSP = @MAPNHAPSP";

            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MASP", masp),                 
                new SqlParameter("@MAPNHAPSP", mapnhapsp),        
                new SqlParameter("@SOLUONG", soluong),           
                new SqlParameter("@TONGGIATRI", tonggiatri),      
                new SqlParameter("@NGAYNHAP", ngaynhap)           
            };

            
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public string LayDonGia(string masp)
        {
            string query = "SELECT DONGIA FROM SAN_PHAM WHERE MASP = @MASP";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter ("@MASP",masp)
            };
            return  dataAccess.ExecuteScalar (query, parameter).ToString();
        }
        public string LayTenSP(string masp)
        {
            string query = "SELECT TENSP FROM SAN_PHAM WHERE MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@MASP",masp)
            };
            return dataAccess.ExecuteScalar(query, parameters).ToString();
        }
        public void UpdateSLSP(string masp,decimal sl) 
        {
            string query = "UPDATE SAN_PHAM SET SOLUONG = @SOLUONG WHERE MASP = @MASP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@SOLUONG",sl),
                new SqlParameter ("@MASP",masp)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }

        public decimal LayTongTien(string mapnsp)
        {
            string query = "SELECT TONGTIEN FROM PHIEU_NHAP_SAN_PHAM WHERE MAPNHAPSP = @MAPNHAPSP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@MAPNHAPSP",mapnsp)
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
