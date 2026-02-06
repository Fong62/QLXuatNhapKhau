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
    public class NguyenLieuBLL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable LayNguyenLieu()
        {
            string query = "Select * from NGUYEN_LIEU";

            return dataAccess.ExecuteQuery(query);
        }

        public DataTable TimKiemNguyenLieu(string search)
        {
            string query = "SELECT * FROM NGUYEN_LIEU WHERE MANL = @search OR TENNL LIKE N'%' + @search + '%' ";
            SqlParameter[] parameters = { new SqlParameter("@search", search) };

            return dataAccess.ExecuteQuery(query, parameters);
        }
    }
}
