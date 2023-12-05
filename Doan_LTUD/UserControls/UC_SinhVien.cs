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
    public partial class UC_SinhVien : UserControl
    {
        public UC_SinhVien()
        {
            InitializeComponent();
        }

        BLL_SINHVIEN bllSinhVien = new BLL_SINHVIEN();
        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bllSinhVien.getSinhVien();

            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ";
            dataGridView1.Columns[2].HeaderText = "Tên";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].HeaderText = "Dân tộc";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
            dataGridView1.Columns[6].HeaderText = "Quê quán";
            dataGridView1.Columns[7].HeaderText = "Số điện thoại";
            dataGridView1.Columns[8].HeaderText = "Email";
            dataGridView1.Columns[9].HeaderText = "Khóa học";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllSinhVien.searchSinhVien(txtTimKiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int  iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
          

            if (dataGridView1.SelectedRows.Count < 1  || dataGridView1.Rows[iDong].Cells[0].Value == null )
            {
                MessageBox.Show("Vui lòng chọn sinh viên trên bảng để xóa", "Thông báo");
                return;
            }

            string masv = dataGridView1.Rows[iDong].Cells[0].Value.ToString();
            string hoten = dataGridView1.Rows[iDong].Cells[1].Value.ToString()+" "+ dataGridView1.Rows[iDong].Cells[2].Value.ToString();
            DialogResult r = MessageBox.Show($"Bạn có muốn xóa sinh viên {hoten}\ncó mã là {masv}này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                if (bllSinhVien.deleteSinhVien(dataGridView1.Rows[iDong].Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa sinh viên vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
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
            uC.BringToFront();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            


            int iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());


            if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trên bảng để để sửa", "Thông báo");
                return;
            }
            string masv = dataGridView1.Rows[iDong].Cells[0].Value.ToString();
            string ho = dataGridView1.Rows[iDong].Cells[1].Value.ToString();
            string ten =  dataGridView1.Rows[iDong].Cells[2].Value.ToString();
            string gioitinh = dataGridView1.Rows[iDong].Cells[3].Value.ToString();
            string dantoc = dataGridView1.Rows[iDong].Cells[4].Value.ToString();
            string diachi = dataGridView1.Rows[iDong].Cells[5].Value.ToString();
            string quequan = dataGridView1.Rows[iDong].Cells[6].Value.ToString();
            string sodienthoai = dataGridView1.Rows[iDong].Cells[7].Value.ToString();
            string email = dataGridView1.Rows[iDong].Cells[8].Value.ToString();
            int khoahoc = int.Parse(dataGridView1.Rows[iDong].Cells[9].Value.ToString());
            UC_EditSinhVien uC = new UC_EditSinhVien();
            clsSinhVien sinhvien = new clsSinhVien(masv,ho,ten,gioitinh,dantoc,diachi,quequan,sodienthoai,email,khoahoc);
            //Ẩn UC_EditSinhVien để hiển thị ra UC_EditSinhVien
           uC.SinhVien = sinhvien;
            this.Parent.Controls.Add(uC);
            uC.BringToFront();
        }
    }
}
