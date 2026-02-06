using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;
namespace BLL
{
    public class HoSoCuaToiBLL
    {
        DataAccess dataAccess = new DataAccess();
        public SqlDataReader DocNV(string maNV)
        {
            string query = "SELECT * FROM NHAN_VIEN WHERE MANV = @maNV";
            SqlParameter[] parameters =
            {
            new SqlParameter("@maNV", maNV)
            };

            return dataAccess.ExecuteReader(query, parameters);
        }
        public SqlDataReader DocKh(string makh)
        {
            string query = "SELECT * FROM KHACH_HANG WHERE MAKH = @makh";
            SqlParameter[] parameters =
            {
            new SqlParameter("@makh", makh)
            };
            return dataAccess.ExecuteReader(query,parameters);

        }

    }
}
