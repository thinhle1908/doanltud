using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_SinhVien:connectDB
    {
        public DataTable getAllSinhVien()
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_getallsinhvien";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public DataTable searchSinhVien(string sKeyWord)
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_searchsinhvien";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@TEN", sKeyWord);


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public int deleteSinhVien (string sMaSinhVien)
        {
            int iKetQua;
            string tenSP = "sp_deletesinhvien";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MASV", sMaSinhVien);

            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
    }
}
