using BLL;
using Doan_LTUD.report;
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
    public partial class UC_SinhVien : UserControl
    {
        public UC_SinhVien()
        {
            InitializeComponent();
        }

        BLL_SINHVIEN bllSinhVien = new BLL_SINHVIEN();
        BLL_User bLL_User = new BLL_User();
        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bllSinhVien.getSinhVien();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[2].HeaderText = "Họ";
            dataGridView1.Columns[3].HeaderText = "Tên";
            dataGridView1.Columns[4].HeaderText = "Giới tính";
            dataGridView1.Columns[5].HeaderText = "Ngày sinh";
            dataGridView1.Columns[6].HeaderText = "Dân tộc";
            dataGridView1.Columns[7].HeaderText = "Địa chỉ";
            dataGridView1.Columns[8].HeaderText = "Quê quán";
            dataGridView1.Columns[9].HeaderText = "Số điện thoại";
            dataGridView1.Columns[10].HeaderText = "Email";
            dataGridView1.Columns[11].HeaderText = "Khóa học";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].HeaderText = "Chuyên ngành";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInDanhSach frmInDanhSach = new frmInDanhSach();
            frmInDanhSach.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllSinhVien.searchSinhVien(txtTimKiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int  iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
          

            if (dataGridView1.SelectedRows.Count < 1  || dataGridView1.Rows[iDong].Cells["MASV"].Value == null )
            {
                MessageBox.Show("Vui lòng chọn sinh viên trên bảng để xóa", "Thông báo");
                return;
            }

            string masv = dataGridView1.Rows[iDong].Cells["MASV"].Value.ToString();
            string hoten = dataGridView1.Rows[iDong].Cells["HO"].Value.ToString()+" "+ dataGridView1.Rows[iDong].Cells["TEN"].Value.ToString();
            int id = int.Parse(dataGridView1.Rows[iDong].Cells["id"].Value.ToString());
            DialogResult r = MessageBox.Show($"Bạn có muốn xóa sinh viên {hoten}\ncó mã là {masv}này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                if (bllSinhVien.deleteSinhVien(id,dataGridView1.Rows[iDong].Cells["MASV"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa sinh viên vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
                    bLL_User.deleteUser(masv);
                    MessageBox.Show("Xóa sinh viên thành công");
                }

                dataGridView1.DataSource = bllSinhVien.getSinhVien();
            }
              
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UC_AddSinhVien uC = new UC_AddSinhVien();
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien

            
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            


            int iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());


            if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trên bảng để để sửa", "Thông báo");
                return;
            }
            string masv = dataGridView1.Rows[iDong].Cells["MASV"].Value.ToString();
            string ho = dataGridView1.Rows[iDong].Cells["HO"].Value.ToString();
            string ten =  dataGridView1.Rows[iDong].Cells["TEN"].Value.ToString();
            string gioitinh = dataGridView1.Rows[iDong].Cells["GIOITINH"].Value.ToString();
            DateTime ngaySinh = DateTime.Parse(dataGridView1.Rows[iDong].Cells["NGAYSINH"].Value.ToString());
            string dantoc = dataGridView1.Rows[iDong].Cells["DANTOC"].Value.ToString();
            string diachi = dataGridView1.Rows[iDong].Cells["DIACHI"].Value.ToString();
            string quequan = dataGridView1.Rows[iDong].Cells["QUEQUAN"].Value.ToString();
            string sodienthoai = dataGridView1.Rows[iDong].Cells["SODIENTHOAI"].Value.ToString();
            string email = dataGridView1.Rows[iDong].Cells["EMAIL"].Value.ToString();
            int khoahoc = int.Parse(dataGridView1.Rows[iDong].Cells["KHOAHOC"].Value.ToString());
            string manganh = dataGridView1.Rows[iDong].Cells["MANGANH"].Value.ToString();
            UC_EditSinhVien uC = new UC_EditSinhVien();
            clsSinhVien sinhvien = new clsSinhVien(masv,ho,ten,gioitinh,ngaySinh,dantoc,diachi,quequan,sodienthoai,email,khoahoc, manganh);
            //Ẩn UC_EditSinhVien để hiển thị ra UC_EditSinhVien
            uC.SinhVien = sinhvien;
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
            uC.BringToFront();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
