using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doan_LTUD.UserControls
{
    public partial class UC_AddSinhVien : UserControl
    {
        public UC_AddSinhVien()
        {
            InitializeComponent();
        }
        BLL_SINHVIEN bLL_SINHVIEN = new BLL_SINHVIEN();
        BLL_NGANH bll_Nganh = new BLL_NGANH();
        BLL_User  bll_User = new BLL_User();
        private void UC_AddSinhVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 0;


            Dictionary<string, string> listNganhHoc = new Dictionary<string, string>();

            DataTable dt = bll_Nganh.getAllNganh();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listNganhHoc.Add(dt.Rows[i][0].ToString(),dt.Rows[i][1].ToString());
            }

            cboChuyenNganh.DataSource = new BindingSource(listNganhHoc, null);
            cboChuyenNganh.DisplayMember = "Value";
            cboChuyenNganh.ValueMember = "Key";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_SinhVien uC = new UC_SinhVien();
            this.Parent.Controls.Add(uC);
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
            string scboNganh = ((KeyValuePair<string, string>)cboChuyenNganh.SelectedItem).Key;

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
            //Kiểm tra rỗng 
            if (scboNganh.Trim() == String.Empty)
            {
                errorProvider1.SetError(cboChuyenNganh, "Vui lòng chọn chuyên ngành");
                return;
            }
            else
            {
                errorProvider1.SetError(cboChuyenNganh, "");
            }
            //Kiểm tra ngày sinh , sinh viên phải đủ 18 tuổi
            string namHienTai = DateTime.Now.Year.ToString();
            string namSinh = dtpNgaySinh.Value.Year.ToString();
            if (int.Parse(namHienTai) - int.Parse(namSinh) <  18) 
            {
                errorProvider1.SetError(dtpNgaySinh, "Chọn ngày sinh của sinh viên trên 18 tuổi");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSoDienThoai, "");
            }


            //Kiểm tra số điện thoại, dữ liệu  là số
            if (Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^\d+$"))
            {
                errorProvider1.SetError(txtSoDienThoai, "");
                
            }
            else
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập dữ liệu là chữ số");
                return;
            }

            //Kiểm  tra email phải có định dạng email
            if (Regex.IsMatch(txtEmail.Text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errorProvider1.SetError(txtEmail, "");
                
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập đúng định dạng email");
                return;
            }

            //Tiến hành thêm dữ liệu vào bảng  sinh  viên nếu thành công  trả về mã sinh viên
            string maSV = bLL_SINHVIEN.addSinhVien(sHo, sTen, sGioiTinh, dtpNgaySinh.Value.Date, sDanToc, sDiaChi, sQueQuan, sSDT, sEmail, scboNganh);
            if (maSV != "0")
            {
                MessageBox.Show($"Thêm sinh viên thành công sinh viên mới có mã là {maSV}","Thông báo");
                bll_User.createUser(maSV, maSV);
                UC_SinhVien uC = new UC_SinhVien();
                this.Parent.Controls.Add(uC);
                this.Parent.Controls.Remove(this);

            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm sinh viên", "Thông báo");
            }

           

        }
    }
}
