using DAL;
using System;
using System.Collections.Generic;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BLL
{
    public class SanPhamBLL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable LaySanPham()
        {
            string query = "Select * from SAN_PHAM";

            return dataAccess.ExecuteQuery(query);
        }

        public DataTable LaySanPhamMaSanPham(string maSP)
        {
            string query = "Select * from SAN_PHAM Where MASP = @maSP";
            SqlParameter[] parameters = { new SqlParameter("@maSP", maSP) };

            return dataAccess.ExecuteQuery(query, parameters);
        }

        public DataTable TimKiemSanPham(string search)
        {
            string query = "SELECT * FROM SAN_PHAM WHERE MASP = @search OR TENSP LIKE N'%' + @search + '%' ";
            SqlParameter[] parameters = { new SqlParameter("@search", search) };
            
            return dataAccess.ExecuteQuery(query, parameters);
        }
    }
}
