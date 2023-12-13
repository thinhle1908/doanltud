using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;


namespace BLL
{
    public class BLL_SINHVIEN
    {
        DAL_SinhVien dal_sinhvien = new DAL_SinhVien();
        public DataTable getSinhVien()
        {
            DataTable dt = new DataTable();
            dt = dal_sinhvien.getAllSinhVien();
            return dt;
        }
        public DataTable searchSinhVien(string sKeyWord)
        {
            DataTable dt = new DataTable();
            dt = dal_sinhvien.searchSinhVien(sKeyWord);
            return dt;
        }
        public int deleteSinhVien(string MASV)
        {
            int iKetQua = 0;
            try
            {
                iKetQua = dal_sinhvien.deleteSinhVien( MASV);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            return iKetQua;
        }
        public int addSinhVien (clsSinhVien sinhVien)
        {
            return dal_sinhvien.addSinhVien(sinhVien);
        }
    }
}
