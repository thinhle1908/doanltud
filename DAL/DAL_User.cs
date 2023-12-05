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
    }
}