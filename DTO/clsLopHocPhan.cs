using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLopHocPhan
    {
        private string _MAMH;
        private string _MALOP;
        private string _TENGIANGVIEN;
        private string _PHONGHOC;
        private DateTime _NGAYBATDAU; 
        private DateTime _NGAYKETTHUC;
	    private int _SOLUONGSINHVIEN ;

        public clsLopHocPhan(string mAMH, string mALOP, string tENGIANGVIEN, string pHONGHOC, DateTime nGAYBATDAU, DateTime nGAYKETTHUC, int sOLUONGSINHVIEN)
        {
            MAMH = mAMH;
            MALOP = mALOP;
            TENGIANGVIEN = tENGIANGVIEN;
            PHONGHOC = pHONGHOC;
            NGAYBATDAU = nGAYBATDAU;
            NGAYKETTHUC = nGAYKETTHUC;
            SOLUONGSINHVIEN = sOLUONGSINHVIEN;
        }

        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public string MALOP { get => _MALOP; set => _MALOP = value; }
        public string TENGIANGVIEN { get => _TENGIANGVIEN; set => _TENGIANGVIEN = value; }
        public string PHONGHOC { get => _PHONGHOC; set => _PHONGHOC = value; }
        public DateTime NGAYBATDAU { get => _NGAYBATDAU; set => _NGAYBATDAU = value; }
        public DateTime NGAYKETTHUC { get => _NGAYKETTHUC; set => _NGAYKETTHUC = value; }
        public int SOLUONGSINHVIEN { get => _SOLUONGSINHVIEN; set => _SOLUONGSINHVIEN = value; }
    }
}
