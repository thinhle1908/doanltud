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
    public class DAL_User : connectDB
    {
        public DataTable login(clsUser clsUser)
        {
            DataTable dtUser = new DataTable();
            SqlDataAdapter daUser;
            string tenSP = "sp_login";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@username", clsUser.Username);
            cmdSQL.Parameters.AddWithValue("@password", clsUser.Password);

            daUser = new SqlDataAdapter(cmdSQL);
            daUser.Fill(dtUser);
            return dtUser;

        }
        public int createUser(clsUser clsUser)
        {
            string tenSP = "sp_createUser";
            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@username", clsUser.Username);
            cmdSQL.Parameters.AddWithValue("@password", clsUser.Password);
            cmdSQL.Parameters.AddWithValue("@isAdmin", "2");


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
        public int deleteUser(string sMaSinhVien)
        {
            int iKetQua;
            string tenSP = "sp_deleteUser";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@username", sMaSinhVien);

            iKetQua = cmdSQL.ExecuteNonQuery();
            return iKetQua;
        }
        public int changePassword(clsUser user)
        {
            string tenSP = "sp_changepassword";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@username", user.Username);
            cmdSQL.Parameters.AddWithValue("@password", user.Password);

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