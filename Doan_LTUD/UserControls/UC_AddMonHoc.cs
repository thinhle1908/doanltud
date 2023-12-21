using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Doan_LTUD.UserControls
{
    public partial class UC_AddMonHoc : UserControl
    {
        public UC_AddMonHoc()
        {
            InitializeComponent();
        }
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string sMaMH = txtMaMH.Text.Trim();
            string sTenMH= txtTenMH.Text.Trim();
            string sNienKhoa = txtNienkhoa.Text.Trim();
            string sHocKy = txtHocKy.Text.Trim();
            string sSoTien = txtSoTien.Text.Trim();
            string sMaKhoa = txtMaKhoa.Text.Trim();
       

            if (sMaMH == String.Empty)
            {
                errorProvider1.SetError(txtMaMH, "Vui lòng nhập mã môn học");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMaMH, "");
            }
   
            if (sTenMH.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtTenMH, "Vui lòng nhập tên môn học");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTenMH, "");

            }
    
            if (sNienKhoa.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtNienkhoa, "Vui lòng nhập niên khóa");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNienkhoa, "");
            }
         
            if (sHocKy.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtHocKy, "Vui lòng nhập Học kỳ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHocKy, "");
            }
         
            if (sSoTien.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtSoTien, "Vui lòng nhập số tiền");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSoTien, "");
            }
   
            if (sMaKhoa.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtMaKhoa, "Vui lòng nhập Mã Khoa");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMaKhoa, "");
            }
     
            DataTable dt = bll_MonHoc.getMonHoc();
            string sMaMonHoc = (dt.Rows.Count + 1).ToString();
            MessageBox.Show(sMaMonHoc);
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
