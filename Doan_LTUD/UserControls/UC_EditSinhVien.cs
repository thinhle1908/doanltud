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
    public partial class UC_EditSinhVien : UserControl
    {
        private clsSinhVien sinhVien;

        public clsSinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        public UC_EditSinhVien()
        {
            InitializeComponent();
        }

        private void UC_AddSinhVien_Load(object sender, EventArgs e)
        {
            txtHo.Text = sinhVien.HO;
            txtTen.Text = sinhVien.TEN;

            cboGioiTinh.SelectedItem = sinhVien.GIOITINH;
            
            txtDanToc.Text = sinhVien.DANTOC;
            txtDiaChi.Text = sinhVien.DIACHI;
            txtQueQuan.Text = sinhVien.QUEQUAN;
            txtSoDienThoai.Text = sinhVien.SODIENTHOAI;
            txtEmail.Text = sinhVien.EMAIL;
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien
            
            
        }
    }
}
