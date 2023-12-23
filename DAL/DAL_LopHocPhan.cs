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
    public class DAL_LopHocPhan:connectDB
    {
        public DataTable getAllLop()
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_getAllLop";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public DataTable searchLopHocPhan(string sKeyWord)
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_searchLopHocPhan";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@TEN", sKeyWord);


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public int deleteLopHocPhan(string sMalop)
        {
            int iKetQua;
            string tenSP = "sp_deleteLopHocPhan";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MALOP", sMalop);

            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
        public int addLopHocPhan(clsLopHocPhan lopHocPhan)
        {
            string tenSP = "sp_addLopHocPhan";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MAMH",lopHocPhan.MAMH );
            cmdSQL.Parameters.AddWithValue("@MALOP", lopHocPhan.MALOP);
            cmdSQL.Parameters.AddWithValue("@TENGIANGVIEN", lopHocPhan.TENGIANGVIEN);
            cmdSQL.Parameters.AddWithValue("@PHONGHOC", lopHocPhan.PHONGHOC);
            cmdSQL.Parameters.AddWithValue("@NGAYBATDAU", lopHocPhan.NGAYBATDAU);
            cmdSQL.Parameters.AddWithValue("@NGAYKETTHUC", lopHocPhan.NGAYKETTHUC);
            cmdSQL.Parameters.AddWithValue("@SOLUONGSINHVIEN", lopHocPhan.SOLUONGSINHVIEN);



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
        public int editLop(clsLopHocPhan lopHocPhan)
        {
            string tenSP = "sp_editLopHocPhan";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MALOP", lopHocPhan.MALOP);
            cmdSQL.Parameters.AddWithValue("@TENGIANGVIEN", lopHocPhan.TENGIANGVIEN);
            cmdSQL.Parameters.AddWithValue("@PHONGHOC", lopHocPhan.PHONGHOC);
            cmdSQL.Parameters.AddWithValue("@NGAYBATDAU", lopHocPhan.NGAYBATDAU);
            cmdSQL.Parameters.AddWithValue("@NGAYKETTHUC", lopHocPhan.NGAYKETTHUC);
            cmdSQL.Parameters.AddWithValue("@SOLUONGSINHVIEN", lopHocPhan.SOLUONGSINHVIEN);



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
    }
}
