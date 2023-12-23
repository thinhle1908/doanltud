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
    public class DAL_SinhVien : connectDB
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
        public int deleteSinhVien(string sMaSinhVien)
        {
            int iKetQua;
            string tenSP = "sp_deletesinhvien";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MASV", sMaSinhVien);

            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
        public int resetIDTableSinhVien(int ID)
        {
            int iKetQua;
            string tenSP = "sp_resetID";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@ID", ID);


            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
        public int addSinhVien(clsSinhVien sinhVien)
        {
            string tenSP = "sp_addSinhVien";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MASV", sinhVien.MASV);
            cmdSQL.Parameters.AddWithValue("@HO", sinhVien.HO);
            cmdSQL.Parameters.AddWithValue("@TEN", sinhVien.TEN);
            cmdSQL.Parameters.AddWithValue("@GIOITINH", sinhVien.GIOITINH);
            cmdSQL.Parameters.AddWithValue("@NGAYSINH", sinhVien.NGAYSINH);
            cmdSQL.Parameters.AddWithValue("@DANTOC", sinhVien.DANTOC);
            cmdSQL.Parameters.AddWithValue("@DIACHI", sinhVien.DIACHI);
            cmdSQL.Parameters.AddWithValue("@QUEQUAN", sinhVien.QUEQUAN);
            cmdSQL.Parameters.AddWithValue("@SODIENTHOAI", sinhVien.SODIENTHOAI);
            cmdSQL.Parameters.AddWithValue("@EMAIL", sinhVien.EMAIL);
            cmdSQL.Parameters.AddWithValue("@KHOAHOC", sinhVien.KHOAHOC);
            cmdSQL.Parameters.AddWithValue("@MANGANH", sinhVien.MANGANH);


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
        public DataTable getLastIDSinhVien()
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_getLastIDSinhVien";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;


            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public int editSinhVien(clsSinhVien sinhVien)
        {
            string tenSP = "sp_editSinhVien";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@MASV", sinhVien.MASV);
            cmdSQL.Parameters.AddWithValue("@HO", sinhVien.HO);
            cmdSQL.Parameters.AddWithValue("@TEN", sinhVien.TEN);
            cmdSQL.Parameters.AddWithValue("@GIOITINH", sinhVien.GIOITINH);
            cmdSQL.Parameters.AddWithValue("@NGAYSINH", sinhVien.NGAYSINH);
            cmdSQL.Parameters.AddWithValue("@DANTOC", sinhVien.DANTOC);
            cmdSQL.Parameters.AddWithValue("@DIACHI", sinhVien.DIACHI);
            cmdSQL.Parameters.AddWithValue("@QUEQUAN", sinhVien.QUEQUAN);
            cmdSQL.Parameters.AddWithValue("@SODIENTHOAI", sinhVien.SODIENTHOAI);
            cmdSQL.Parameters.AddWithValue("@EMAIL", sinhVien.EMAIL);

            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {

                    result = 1;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                result = 0;
            }

            return result;
        }
    }
}
