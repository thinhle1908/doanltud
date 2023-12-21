using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clssMonHoc
    {
        private string _MAMH;
        private string _TENMH;
        private string _NIENKHOA;
        private int _HOCKY;
        private int _SOTIEN;
        private string _MAKHOA;

        public clssMonHoc(string mAMH, string tENMH, string nIENKHOA, int hOCKY, int sOTIEN, string mAKHOA)
        {
            _MAMH = mAMH;
            _TENMH = tENMH;
            _NIENKHOA = nIENKHOA;
            _HOCKY = hOCKY;
            _SOTIEN = sOTIEN;
            _MAKHOA = mAKHOA;
        }

        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public string TENMH { get => _TENMH; set => _TENMH = value; }
        public string NIENKHOA { get => _NIENKHOA; set => _NIENKHOA = value; }
        public int HOCKY { get => _HOCKY; set => _HOCKY = value; }
        public int SOTIEN { get => _SOTIEN; set => _SOTIEN = value; }
        public string MAKHOA { get => _MAKHOA; set => _MAKHOA = value; }
    }
}
