using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_NGANH
    {
        DAL_NGANH dal_Nganh = new DAL_NGANH();
        public DataTable getAllNganh()
        {
            DataTable dt = new DataTable();
            dt = dal_Nganh.getAllNganh();
            return dt;
        }
    }
}
