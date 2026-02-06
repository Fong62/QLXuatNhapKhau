using DAL;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable LayNhanVien()
        {
            string query = "Select * from NHAN_VIEN";

            return dataAccess.ExecuteQuery(query);
        }

        public string LayTenNhanVien(string manv)
        {
            string query = "SELECT HOTEN FROM NHAN_VIEN WHERE MANV = @manv";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@manv",manv)
            };
            return dataAccess.ExecuteScalar(query, parameters).ToString();
        }

        public DataTable TimKiemNhanVien(string search, string phongban)
        {
            string query = "SELECT * FROM NHAN_VIEN WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();


            if (!string.IsNullOrEmpty(search) && string.IsNullOrEmpty(phongban))
            {
                query += " AND (MANV = @search OR HOTEN LIKE N'%' + @search + '%')";
                parameters.Add(new SqlParameter("@search", search));
            }

            else if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(phongban) && search == "Mã nhân viên hoặc tên nhân viên")
            {
                query += " AND PHONGBAN = @phongban";
                parameters.Add(new SqlParameter("@phongban", phongban));
            }

            else if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(phongban))
            {
                query += " AND (MANV = @search OR HOTEN LIKE N'%' + @search + '%') AND PHONGBAN = @phongban";
                parameters.Add(new SqlParameter("@search", search));
                parameters.Add(new SqlParameter("@phongban", phongban));
            }

            return dataAccess.ExecuteQuery(query, parameters.ToArray());
        }
    }
}
