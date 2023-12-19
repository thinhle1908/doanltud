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

namespace Doan_LTUD.UserControls
{
    public partial class UC_EditSinhVien : UserControl
    {
        private clsSinhVien sinhVien;
        BLL_SINHVIEN bLL_SINHVIEN = new BLL_SINHVIEN();
        BLL_NGANH bll_Nganh = new BLL_NGANH();

        public clsSinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        public UC_EditSinhVien()
        {
            InitializeComponent();
        }

        private void UC_AddSinhVien_Load(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = sinhVien.MASV;
            txtHo.Text = sinhVien.HO;
            txtTen.Text = sinhVien.TEN;

            cboGioiTinh.SelectedItem = sinhVien.GIOITINH;
            
            txtDanToc.Text = sinhVien.DANTOC;
            txtDiaChi.Text = sinhVien.DIACHI;
            txtQueQuan.Text = sinhVien.QUEQUAN;
            txtSoDienThoai.Text = sinhVien.SODIENTHOAI;
            txtEmail.Text = sinhVien.EMAIL;
            txtKhoaHoc.Text = sinhVien.KHOAHOC.ToString();
            dtpNgaySinh.Value = sinhVien.NGAYSINH;

            Dictionary<string, string> listNganhHoc = new Dictionary<string, string>();

            DataTable dt = bll_Nganh.getAllNganh();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listNganhHoc.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }

            cboChuyenNganh.DataSource = new BindingSource(listNganhHoc, null);
            cboChuyenNganh.DisplayMember = "Value";  
            cboChuyenNganh.ValueMember = "Key";
            cboChuyenNganh.SelectedValue = sinhVien.MANGANH;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien
            
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            UC_SinhVien uC = new UC_SinhVien();
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string sMaSinhVien = txtMaSinhVien.Text.Trim();
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
            if (sMaSinhVien == String.Empty)
            {
                errorProvider1.SetError(txtMaSinhVien, "Vui lòng thoát ra chọn lại không tìm thấy mã xin viên");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMaSinhVien, "");
            }
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
            //Kiểm tra rỗng 
            if (txtKhoaHoc.Text == String.Empty)
            {
                errorProvider1.SetError(txtKhoaHoc, "Vui lòng chọn chuyên ngành");
                return;
            }
            else
            {
                errorProvider1.SetError(txtKhoaHoc, "");
            }
            //Kiểm tra ngày sinh , sinh viên phải đủ 18 tuổi
            string namHienTai = DateTime.Now.Year.ToString();
            string namSinh = dtpNgaySinh.Value.Year.ToString();
            if (int.Parse(namHienTai) - int.Parse(namSinh) < 18)
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
            int khoaHoc = int.Parse(txtKhoaHoc.Text);
            if (bLL_SINHVIEN.editSinhVien(sMaSinhVien,sHo, sTen, sGioiTinh, dtpNgaySinh.Value.Date, sDanToc, sDiaChi, sQueQuan, sSDT, sEmail, scboNganh,khoaHoc) == 1)
            {
                MessageBox.Show("Sửa sinh viên thành công", "Thông báo");

                UC_SinhVien uC = new UC_SinhVien();
                this.Parent.Controls.Add(uC);
                this.Parent.Controls.Remove(this);

            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa sinh viên", "Thông báo");
            }

        }
    }
}
