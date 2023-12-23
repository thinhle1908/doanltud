using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Doan_LTUD.UserControls
{
    public partial class UC_AddLopHocPhan : UserControl
    {
        public UC_AddLopHocPhan()
        {
            InitializeComponent();
        }
        BLL_NGANH bll_Nganh = new BLL_NGANH();
        BLL_MonHoc bLL_MonHoc = new BLL_MonHoc();
        BLL_LopHocPhan bLL_LopHocPhan = new BLL_LopHocPhan();


        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_LopHocPhan uC = new UC_LopHocPhan();
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
        }

        private void UC_AddLopHocPhan_Load(object sender, EventArgs e)
        {

            cboSoTuanHoc.SelectedIndex = 0;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            dtpNgayKetThuc.Value = ngayBatDau.AddDays(int.Parse(cboSoTuanHoc.SelectedItem.ToString()) * 7);

            Dictionary<string, string> listNganhHoc = new Dictionary<string, string>();

            DataTable dt = bll_Nganh.getAllNganh();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listNganhHoc.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }

            cboChuyenNganh.DataSource = new BindingSource(listNganhHoc, null);
            cboChuyenNganh.DisplayMember = "Value";
            cboChuyenNganh.ValueMember = "Key";
        }

        private void cboChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scboNganh = ((KeyValuePair<string, string>)cboChuyenNganh.SelectedItem).Key;
            Dictionary<string, string> listMonHoc = new Dictionary<string, string>();

            DataTable dt = bLL_MonHoc.getMonHocByNganhHoc(scboNganh);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMonHoc.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }

            cboMonHoc.DataSource = new BindingSource(listMonHoc, null);
            cboMonHoc.DisplayMember = "Value";
            cboMonHoc.ValueMember = "Key";
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            dtpNgayKetThuc.Value = ngayBatDau.AddDays(int.Parse(cboSoTuanHoc.SelectedItem.ToString()) * 7);
        }

        private void cboSoTuanHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            dtpNgayKetThuc.Value = ngayBatDau.AddDays(int.Parse(cboSoTuanHoc.SelectedItem.ToString()) * 7);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string MALOP = txtMaLop.Text.Trim();
            string TENGIANGVIEN = txtTenGiangVien.Text.Trim();
            string scboMaMonHoc = ((KeyValuePair<string, string>)cboMonHoc.SelectedItem).Key;
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
            int iKetQua = bLL_LopHocPhan.addLop(scboMaMonHoc, MALOP, TENGIANGVIEN, sPhong,ngayBatDau,ngayKetThuc,soLuongSinhVien);
            if (iKetQua != 0)
            {
                MessageBox.Show($"Thêm lớp học phần thành công", "Thông báo");
                UC_LopHocPhan uC = new UC_LopHocPhan();
                this.Parent.Controls.Add(uC);
                this.Parent.Controls.Remove(this);

            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm lớp", "Thông báo");
            }
        }
    }
}
