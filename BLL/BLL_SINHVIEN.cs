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
        public int deleteSinhVien(int id,string MASV)
        {
            int iKetQua = 0;
            try
            {
                DataTable lastID = dal_sinhvien.getLastIDSinhVien();
                iKetQua = dal_sinhvien.deleteSinhVien(MASV);
                if (id == int.Parse(lastID.Rows[0]["id"].ToString())) 
                {
                    dal_sinhvien.resetIDTableSinhVien(id - 1);
                }
                
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            return iKetQua;
        }
        public string addSinhVien(string HO,string TEN,string GIOITINH,DateTime NGAYSINH,string DANTOC,string DIACHI,string QUEQUAN,string SODIENTHOAI,
         string EMAIL,string MANGANH)
        {
            string MASV = "211";

            int KHOAHOC = int.Parse(DateTime.Today.Year.ToString().Substring(2,2));
           
            //Lấy id cuối cùng của bảng sinh viên
            DataTable dt = dal_sinhvien.getLastIDSinhVien();
          
            //Lấy id của sinh viên cuối cùng +1 ra mã sinh viên mới
            int id = int.Parse(dt.Rows[0]["id"].ToString());
            id += 1;
          
            //Xử lý mã sinh viên
            MASV = String.Concat(KHOAHOC, MASV, MANGANH.Substring(0,2), id.ToString("0000")).Trim();

            clsSinhVien sinhVien = new clsSinhVien(MASV, HO, TEN, GIOITINH, NGAYSINH, DANTOC, DIACHI, QUEQUAN, SODIENTHOAI, EMAIL, KHOAHOC, MANGANH);
            if (dal_sinhvien.addSinhVien(sinhVien) == 1)
            {
                return MASV;
            }
            else
            {
                return "0";
            }
        }
        public int editSinhVien(string MASV,string HO, string TEN, string GIOITINH, DateTime NGAYSINH, string DANTOC, string DIACHI, string QUEQUAN, string SODIENTHOAI,
         string EMAIL, string MANGANH, int KHOAHOC)
        {

            clsSinhVien sinhVien = new clsSinhVien(MASV, HO, TEN, GIOITINH, NGAYSINH, DANTOC, DIACHI, QUEQUAN, SODIENTHOAI, EMAIL, KHOAHOC, MANGANH);
            return dal_sinhvien.editSinhVien(sinhVien);
        }
    }
}
