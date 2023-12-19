using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNganh
    {
        private string _MANGANH;
        private string _TENNGANH;

        public clsNganh(string mANGANH, string tENNGANH)
        {
            MANGANH = mANGANH;
            TENNGANH = tENNGANH;
        }

        public string MANGANH { get => _MANGANH; set => _MANGANH = value; }
        public string TENNGANH { get => _TENNGANH; set => _TENNGANH = value; }
    }
}
