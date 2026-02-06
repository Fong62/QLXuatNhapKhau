using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;
using System.Data;
using Azure.Core.Pipeline;

namespace BLL
{
    public class NhapNguyenLieu
    {
        DataAccess dataAccess = new DataAccess();
        public List<string> LayDanhSachNCC()
        {
            string query = "SELECT TENNCC FROM NHA_CUNG_CAP ";


            DataTable khuyenMaiTable = dataAccess.ExecuteQuery(query);


            List<string> dsTenNCC = new List<string>();
            foreach (DataRow row in khuyenMaiTable.Rows)
            {
                dsTenNCC.Add(row["TENNCC"].ToString());
            }

            return dsTenNCC;
        }
        public DataTable LayNguyenLieu()
        {
            string query = "SELECT * FROM NGUYEN_LIEU";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayPhieuNhapNL()
        {
            string query = "SELECT * FROM PHIEU_NHAP_NGUYEN_LIEU";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPhieuNhapNL()
        {
            string query = @"SELECT * From CHI_TIET_NHAP_NGUYEN_LIEU";
            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LayCTPNDuaTrenMaPN(string maPN)
        {
            string query = "SELECT * FROM CHI_TIET_NHAP_NGUYEN_LIEU WHERE MAPNHAPNL = @MAPNHAPNL";
            SqlParameter[] parameters = { new SqlParameter("@MAPNHAPNL", maPN) };
            return dataAccess.ExecuteQuery(query, parameters);
        }

        public string LayTenNl(string manl)
        {
            string query = "SELECT TENNL FROM NGUYEN_LIEU WHERE MANL = @manl";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manl",manl)
            };
            object result = dataAccess.ExecuteScalar(query, parameters);
            return result != null ? result.ToString() : string.Empty;
        }

        public string LayMaNCC(string tenncc)
        {
            string query = "SELECT MANCC FROM NHA_CUNG_CAP WHERE TENNCC = @tenncc";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@tenncc",tenncc)
            };
            return dataAccess.ExecuteScalar(query, parameters).ToString();
        }
        public int CheckMaNL(string manl)
        {
            string query = "SELECT COUNT(*) FROM NGUYEN_LIEU WHERE MANL =@manl";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manl",manl)
            };
            return (int)dataAccess.ExecuteScalar(query, parameters);
        }
        public string TaoMaPNNL()
        {
            string query = "SELECT TOP 1 MAPNHAPNL FROM PHIEU_NHAP_NGUYEN_LIEU ORDER BY MAPNHAPNL DESC";
            object result = dataAccess.ExecuteScalar(query);

            if (result != null)
            {
                string lastCode = result.ToString();
                int lastNumber = int.Parse(lastCode.Substring(4));
                return "PNNL" + (lastNumber + 1).ToString("D2");
            }
            return "PNNL01";
        }
        public void ThemPNNL(string mapnhapnl, string mancc, string manv, DateTime ngaymua)
        {
            ngaymua = ngaymua.Date;

            string query = "INSERT INTO PHIEU_NHAP_NGUYEN_LIEU VALUES(@MAPNHAPNL,@MANCC,@MANV,@NGAYMUA, 0)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPNHAPNL",mapnhapnl),
                new SqlParameter("@MANCC",mancc),
                new SqlParameter("@MANV",manv),
                new SqlParameter("@NGAYMUA",ngaymua),
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void ThemCTPNNL(string manl, string mapnhapnl, decimal soluong, decimal tonggiatri, DateTime ngaynhap)
        {
            string query = "INSERT INTO CHI_TIET_NHAP_NGUYEN_LIEU VALUES (@MAPNHAPNL,@MANL,@SOLUONG,@TONGGIATRI,@NGAYNHAP)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MANL", manl),
            new SqlParameter("@MAPNHAPNL", mapnhapnl),
            new SqlParameter("@SOLUONG", soluong),
            new SqlParameter("@TONGGIATRI", tonggiatri),
            new SqlParameter("@NGAYNHAP", ngaynhap)
            };
            dataAccess.ExecuteNonQuery(query, parameters);

        }
        public void ThemNL(string manl, string tennl, string donvitinh, decimal dongia, decimal soluong)
        {
            string query = "INSERT INTO NGUYEN_LIEU VALUES (@MANL,@TENNL,@DONVITINH,@DONGIA,@SOLUONG)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MANL",manl),
                new SqlParameter("@TENNL",tennl),
                new SqlParameter("@DONVITINH",donvitinh),
                new SqlParameter("@DONGIA",dongia),
                new SqlParameter("@SOLUONG",soluong)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void UpdateNL(string manl, decimal soluong, decimal dongia, string tennl)
        {
            string query = "UPDATE NGUYEN_LIEU SET SOLUONG = @SOLUONG, DONGIA = @DONGIA, TENNL = @TENNL  WHERE MANL = @MANL";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MANL", manl),
            new SqlParameter("@SOLUONG", soluong),
            new SqlParameter("@DONGIA", dongia),
            new SqlParameter("@TENNL", tennl),

            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }

        public void UpdatePNNL(string mapnnl, decimal tongtien)
        {
            string query = "UPDATE PHIEU_NHAP_NGUYEN_LIEU SET TONGTIEN = @TONGTIEN  WHERE MAPNHAPNL = @MAPNNL";


            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MAPNNL", mapnnl),
            new SqlParameter("@TONGTIEN", tongtien),

            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public decimal LaySoLuongNL(string manl)
        {
            string query = "SELECT SOLUONG FROM NGUYEN_LIEU WHERE MANL = @MANL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MANL", manl)
            };

            object result = dataAccess.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToDecimal(result);
        }
        public void XoaPhieuNL(string mapnhapnl)
        {
            string query = @"DELETE CHI_TIET_NHAP_NGUYEN_LIEU WHERE MAPNHAPNL = @MAPPNNL
                             DELETE PHIEU_NHAP_NGUYEN_LIEU WHERE MAPNHAPNL = @MAPPNNL";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAPPNNL",mapnhapnl)
            };
            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public void UpdateCTPNNL(string manl, string mapnhapnl, decimal soluong, decimal tonggiatri, DateTime ngaynhap)
        {

            string query = "UPDATE CHI_TIET_NHAP_NGUYEN_LIEU " +
                           "SET SOLUONGNHAP = @SOLUONG, TONGGIATRI = @TONGGIATRI, NGAYNHAP = @NGAYNHAP " +
                           "WHERE MANL = @MANL AND MAPNHAPNL = @MAPNHAPNL";


            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MANL", manl),
                new SqlParameter("@MAPNHAPNL", mapnhapnl),
                new SqlParameter("@SOLUONG", soluong),
                new SqlParameter("@TONGGIATRI", tonggiatri),
                new SqlParameter("@NGAYNHAP", ngaynhap)
            };


            dataAccess.ExecuteNonQuery(query, parameters);
        }
        public string LayDonGia(string manl)
        {
            string query = "SELECT DONGIA FROM NGUYEN_LIEU WHERE MANL = @MANL";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter ("@MANL",manl)
            };
            return dataAccess.ExecuteScalar(query, parameter).ToString();
        }

        public decimal LayTongTien(string mapnnl)
        {
            string query = "SELECT TONGTIEN FROM PHIEU_NHAP_NGUYEN_LIEU WHERE MAPNHAPNL = @MAPNHAPNL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@MAPNHAPNL",mapnnl)
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
