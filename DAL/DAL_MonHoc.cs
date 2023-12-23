using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_MonHoc:connectDB
    {
        public DataTable getAllMonHoc()
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_getallMonHoc";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public DataTable searchMonhoc(string sKeyWord)
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_searchMonHoc";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@TENMH", sKeyWord);


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public int deleteMonHoc(string sMaMonHoc)
        {
            int iKetQua;
            string tenSP = "sp_deleteMonHoc";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MAMH", sMaMonHoc);

            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
        public int addMonHoc(clssMonHoc monHoc)
        {
            string tenSP = "sp_addMonHoc";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MAMH", monHoc.MAMH);
            cmdSQL.Parameters.AddWithValue("@TENMH", monHoc.TENMH);
            cmdSQL.Parameters.AddWithValue("@NIENKHOA", monHoc.NIENKHOA);
            cmdSQL.Parameters.AddWithValue("@HOCKY", monHoc.HOCKY);
            cmdSQL.Parameters.AddWithValue("@SOTIEN", monHoc.SOTIEN);
            cmdSQL.Parameters.AddWithValue("@MAKHOA", monHoc.MAKHOA);
         


            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }

            }
            catch
            {
                result = 0;
            }

            return result;
        }
        public DataTable getMonHocByNganhHoc(string sMaNganh)
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_getallMonHocByNganh";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MANGANH", sMaNganh);


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;
        }
    }
}
