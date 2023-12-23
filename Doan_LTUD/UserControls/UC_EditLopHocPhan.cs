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
    public partial class UC_EditLopHocPhan : UserControl
    {
        private clsLopHocPhan clsLopHocPhan;
        BLL_LopHocPhan bLL_LopHocPhan = new BLL_LopHocPhan();

        public UC_EditLopHocPhan()
        {
            InitializeComponent();
        }

        public clsLopHocPhan ClsLopHocPhan { get => clsLopHocPhan; set => clsLopHocPhan = value; }

        private void UC_EditLopHocPhan_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.Text = clsLopHocPhan.MAMH;
            txtMaLop.Text = clsLopHocPhan.MALOP;
            txtTenGiangVien.Text = clsLopHocPhan.TENGIANGVIEN;
            txtPhongHoc.Text = clsLopHocPhan.PHONGHOC;
            dtpNgayBatDau.Value = clsLopHocPhan.NGAYBATDAU.Date;
            dtpNgayKetThuc.Value = clsLopHocPhan.NGAYKETTHUC.Date;
            nudsoluong.Value = clsLopHocPhan.SOLUONGSINHVIEN;

            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            for (int i = 10; i <= 15;i++)
            {
                if(ngayBatDau.AddDays(i*7).Date==ngayKetThuc.Date)
                {
                    cboSoTuanHoc.SelectedItem = i.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_LopHocPhan uC = new UC_LopHocPhan();
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string MALOP = txtMaLop.Text.Trim();
            string TENGIANGVIEN = txtTenGiangVien.Text.Trim();
            string scboMaMonHoc = txtMaMonHoc.Text.Trim();
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            int soLuongSinhVien = Convert.ToInt32(nudsoluong.Value);
            string sPhong = txtPhongHoc.Text.Trim();

            //Kiểm tra rỗng
            if (MALOP == String.Empty)
            {
                errorProvider1.SetError(txtMaLop, "Vui lòng nhập tên mã lớp học");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMaLop, "");
            }
            //Kiểm tra rỗng 
            if (TENGIANGVIEN == String.Empty)
            {
                errorProvider1.SetError(txtTenGiangVien, "Vui lòng nhập tên lớp học");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTenGiangVien, "");

            }
            //Kiểm tra rỗng 
            if (sPhong == String.Empty)
            {
                errorProvider1.SetError(txtPhongHoc, "Vui lòng nhập phòng học");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhongHoc, "");

            }
            //Kiểm tra rỗng 
            if (soLuongSinhVien < 30)
            {
                errorProvider1.SetError(nudsoluong, "Vui lòng nhập số lượng sinh viên lớn hơn 30");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhongHoc, "");

            }
            int iKetQua = bLL_LopHocPhan.editLop(scboMaMonHoc, MALOP, TENGIANGVIEN, sPhong, ngayBatDau, ngayKetThuc, soLuongSinhVien);
            if (iKetQua != 0)
            {
                MessageBox.Show($"Sửa lớp học phần thành công", "Thông báo");
                UC_LopHocPhan uC = new UC_LopHocPhan();
                this.Parent.Controls.Add(uC);
                this.Parent.Controls.Remove(this);

            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình sửa lớp", "Thông báo");
            }
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (cboSoTuanHoc.SelectedItem != null)
            {
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                dtpNgayKetThuc.Value = ngayBatDau.AddDays(int.Parse(cboSoTuanHoc.SelectedItem.ToString()) * 7).Date;
            }
            
        }

        private void cboSoTuanHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSoTuanHoc.SelectedItem != null)
            {
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                dtpNgayKetThuc.Value = ngayBatDau.AddDays(int.Parse(cboSoTuanHoc.SelectedItem.ToString()) * 7).Date;
            }
        }
    }
}
