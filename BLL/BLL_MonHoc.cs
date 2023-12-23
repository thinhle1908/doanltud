using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;


namespace BLL
{
    public class BLL_MonHoc
    {
        DAL_MonHoc dal_monhoc = new DAL_MonHoc();
        public DataTable getMonHoc()
        {
            DataTable dt = new DataTable();
            dt = dal_monhoc.getAllMonHoc();
            return dt;
        }
        public DataTable searchMonHoc(string sKeyWord)
        {
            DataTable dt = new DataTable();
            dt = dal_monhoc.searchMonhoc(sKeyWord);
            return dt;
        }
        public int deleteMonHoc(string MAMH)
        {
            int iKetQua = 0;
            try
            {
                iKetQua = dal_monhoc.deleteMonHoc(MAMH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iKetQua;
        }
        public int addMonHoc(clssMonHoc monHoc)
        {
            return dal_monhoc.addMonHoc(monHoc);
        }
        public DataTable getMonHocByNganhHoc(string sMaNganh)
        {
            DataTable dt = new DataTable();
            dt = dal_monhoc.getMonHocByNganhHoc(sMaNganh);
            return dt;
        }
    }
}
