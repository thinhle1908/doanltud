using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_NGANH : connectDB
    {
        public DataTable getAllNganh()
        {
            DataTable dtNganh = new DataTable();
            SqlDataAdapter daNganh;
            string tenSP = "get_AllNganh";

            SqlCommand cmdSQL = new SqlCommand(tenSP, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;


            daNganh = new SqlDataAdapter(cmdSQL);
            daNganh.Fill(dtNganh);
            return dtNganh;

        }
    }
}
