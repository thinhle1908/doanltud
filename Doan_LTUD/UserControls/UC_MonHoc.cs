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
    public partial class UC_MonHoc : UserControl
    {
        public UC_MonHoc()
        {
            InitializeComponent();
        }
        BLL_MonHoc bllMonHoc = new BLL_MonHoc();
   

        private void UC_MonHoc_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bllMonHoc.getMonHoc();
            dataGridView2.Columns[0].HeaderText = "Mã Môn Học";
            dataGridView2.Columns[1].HeaderText = "Tên Môn Học";
            dataGridView2.Columns[2].HeaderText = "Niên Khóa";
            dataGridView2.Columns[3].HeaderText = "Học Kỳ";
            dataGridView2.Columns[4].HeaderText = "Số Tiền";
            dataGridView2.Columns[5].HeaderText = "Mã Khoa";
            dataGridView2.Columns[5].HeaderText = "Mã Ngành";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bllMonHoc.searchMonHoc(txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UC_AddMonHoc uc = new UC_AddMonHoc();
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien

            Parent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Lưu ý muốn sử dụng hàm này phải thêm một dữ liệu môn học mới nếu không khi xóa môn học trong lớp học phàn sẽ bị lỗi
            int iDong = int.Parse(dataGridView2.SelectedRows[0].Index.ToString());


            if (dataGridView2.SelectedRows.Count < 1 || dataGridView2.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn môn học trên bảng để xóa", "Thông báo");
                return;
            }

            string maMH = dataGridView2.Rows[iDong].Cells[0].Value.ToString();
            string tenMH = dataGridView2.Rows[iDong].Cells[1].Value.ToString() + " " + dataGridView2.Rows[iDong].Cells[2].Value.ToString();
            DialogResult r = MessageBox.Show($"Bạn có muốn xóa môn học {tenMH}\ncó mã là {maMH}này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                if (bllMonHoc.deleteMonHoc(dataGridView2.Rows[iDong].Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa môn học vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
                    MessageBox.Show("Xóa môn học thành công");
                }

                dataGridView2.DataSource = bllMonHoc.getMonHoc();
            }
            */
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int iDong = int.Parse(dataGridView2.SelectedRows[0].Index.ToString());


            if (dataGridView2.SelectedRows.Count < 1 || dataGridView2.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn môn học trên bảng để để sửa", "Thông báo");
                return;
            }
            string maMH = dataGridView2.Rows[iDong].Cells[0].Value.ToString();
            string tenMH = dataGridView2.Rows[iDong].Cells[1].Value.ToString();
            string nienKhoa = dataGridView2.Rows[iDong].Cells[2].Value.ToString();
            string hocKy = dataGridView2.Rows[iDong].Cells[3].Value.ToString();
            string soTien = dataGridView2.Rows[iDong].Cells[4].Value.ToString();
            string maKhoa = dataGridView2.Rows[iDong].Cells[5].Value.ToString();
    
            UC_EditMonHoccs uC = new UC_EditMonHoccs();
          
            this.Parent.Controls.Add(uC);
            uC.BringToFront();
        }
    }
}
