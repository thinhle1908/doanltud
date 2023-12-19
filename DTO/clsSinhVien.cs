using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSinhVien
    {
      private string _MASV;
      private string _HO;
      private string _TEN;
      private string _GIOITINH;
      private DateTime _NGAYSINH;
	  private string _DANTOC;
	  private string _DIACHI;
      private string _QUEQUAN;
	  private string _SODIENTHOAI;
	  private string _EMAIL;
	  private int _KHOAHOC;
      private string _MANGANH;

        public clsSinhVien(string mASV, string hO, string tEN, string gIOITINH, DateTime nGAYSINH, string dANTOC, string dIACHI, string qUEQUAN, string sODIENTHOAI, string eMAIL, int kHOAHOC, string mANGANH)
        {
            _MASV = mASV;
            _HO = hO;
            _TEN = tEN;
            _GIOITINH = gIOITINH;
            _NGAYSINH = nGAYSINH;
            _DANTOC = dANTOC;
            _DIACHI = dIACHI;
            _QUEQUAN = qUEQUAN;
            _SODIENTHOAI = sODIENTHOAI;
            _EMAIL = eMAIL;
            _KHOAHOC = kHOAHOC;
            _MANGANH = mANGANH;
        }

        public string MASV { get => _MASV; set => _MASV = value; }
        public string HO { get => _HO; set => _HO = value; }
        public string TEN { get => _TEN; set => _TEN = value; }
        public string GIOITINH { get => _GIOITINH; set => _GIOITINH = value; }
        public DateTime NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DANTOC { get => _DANTOC; set => _DANTOC = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string QUEQUAN { get => _QUEQUAN; set => _QUEQUAN = value; }
        public string SODIENTHOAI { get => _SODIENTHOAI; set => _SODIENTHOAI = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public int KHOAHOC { get => _KHOAHOC; set => _KHOAHOC = value; }
        public string MANGANH { get => _MANGANH; set => _MANGANH = value; }
    }
}
