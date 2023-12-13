using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_LTUD.UserControls
{
    public partial class UC_AddSinhVien : UserControl
    {
        public UC_AddSinhVien()
        {
            InitializeComponent();
        }
        BLL_SINHVIEN bLL_SINHVIEN = new BLL_SINHVIEN();
        private void UC_AddSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string sHo = txtHo.Text.Trim();
            string sTen = txtTen.Text.Trim();
            string sGioiTinh = cboGioiTinh.Text.Trim();
            string sDanToc = txtDanToc.Text.Trim();
            string sDiaChi = txtDiaChi.Text.Trim();
            string sQueQuan = txtQueQuan.Text.Trim();
            string sEmail = txtEmail.Text.Trim();
            string sSDT = txtSoDienThoai.Text.Trim();

            //Kiểm tra rỗng
            if (sHo == String.Empty)
            {
                errorProvider1.SetError(txtHo, "Vui lòng nhập tên đăng nhập");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHo, "");
            }
            //Kiểm tra rỗng họ sinh viên
            if (sTen.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập tên sinh viên");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHo, "");

            }
            //Kiểm tra rỗng giơi tính 
            if (sGioiTinh.Trim() == String.Empty)
            {
                errorProvider1.SetError(cboGioiTinh, "Vui lòng nhập giới tính của sinh viên");
                return;
            }
            else
            {
                errorProvider1.SetError(cboGioiTinh, "");
            }
            //Kiểm tra rỗng dân tộc
            if (sDanToc.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtDanToc, "Vui lòng nhập dân tộc");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDanToc, "");
            }
            //Kiểm tra rỗng 
            if (sDiaChi.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDiaChi, "");
            }
            //Kiểm tra rỗng 
            if (sQueQuan.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtQueQuan, "Vui lòng nhập quê quán");
                return;
            }
            else
            {
                errorProvider1.SetError(txtQueQuan, "");
            }
            //Kiểm tra rỗng 
            if (sEmail.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
            //Kiểm tra rỗng 
            if (sSDT.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSoDienThoai, "");
            }
            DataTable dt = bLL_SINHVIEN.getSinhVien();
            string sMaSinhVien = (dt.Rows.Count+1).ToString();
            MessageBox.Show(sMaSinhVien);
            //clsSinhVien sinhVien = new clsSinhVien(s)

        }
    }
}
