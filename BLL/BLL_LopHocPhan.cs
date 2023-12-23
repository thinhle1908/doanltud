using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_LopHocPhan
    {
        DAL_LopHocPhan dal_LopHocPhan = new DAL_LopHocPhan();
        public DataTable getAllLop()
        {
            DataTable dt = new DataTable();
            dt = dal_LopHocPhan.getAllLop();
            return dt;
        }
        public DataTable searchLopHocPhan(string sKeyWord)
        {
            DataTable dt = new DataTable();
            dt = dal_LopHocPhan.searchLopHocPhan(sKeyWord);
            return dt;
        }
        public int deleteLopHocPhan(string MALOP)
        {
            int iKetQua = 0;
            try
            {
                iKetQua = dal_LopHocPhan.deleteLopHocPhan(MALOP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iKetQua;
        }
        public int addLop(string sMaMonHoc, string sMALOP,string sTENGIANGVIEN,string sPHONGHOC,DateTime ngayBatDau, DateTime ngayKetThuc,int soLuongSinhVien)
        {
            clsLopHocPhan clsLopHocPhan = new clsLopHocPhan(sMaMonHoc, sMALOP, sTENGIANGVIEN, sPHONGHOC, ngayBatDau, ngayKetThuc, soLuongSinhVien);
            return dal_LopHocPhan.addLopHocPhan(clsLopHocPhan);
            
            
        }
        public int editLop(string sMaMonHoc, string sMALOP, string sTENGIANGVIEN, string sPHONGHOC, DateTime ngayBatDau, DateTime ngayKetThuc, int soLuongSinhVien)
        {
            clsLopHocPhan clsLopHocPhan = new clsLopHocPhan(sMaMonHoc, sMALOP, sTENGIANGVIEN, sPHONGHOC, ngayBatDau, ngayKetThuc, soLuongSinhVien);
            return dal_LopHocPhan.editLop(clsLopHocPhan);


        }
    }
}
