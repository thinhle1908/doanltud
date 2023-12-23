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
    public partial class UC_LopHocPhan : UserControl
    {
        public UC_LopHocPhan()
        {
            InitializeComponent();
        }
        BLL_LopHocPhan bllLopHocPhan = new BLL_LopHocPhan();

        private void btnThem_Click(object sender, EventArgs e)
        {
            UC_AddLopHocPhan uC = new UC_AddLopHocPhan();
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien


            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
        }

        private void UC_LopHocPhan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllLopHocPhan.getAllLop();
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Mã môn";
            dataGridView1.Columns[2].HeaderText = "Mã lớp";
            dataGridView1.Columns[3].HeaderText = "Tên giảng viên";
            dataGridView1.Columns[4].HeaderText = "Phòng";
            dataGridView1.Columns[5].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[6].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[7].HeaderText = "Số lượng sinh viên ";

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllLopHocPhan.searchLopHocPhan(txtTimKiem.Text);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());


            if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học trên bảng để xóa", "Thông báo");
                return;
            }

            string MALOP = dataGridView1.Rows[iDong].Cells["MALOP"].Value.ToString().Trim();

            DialogResult r = MessageBox.Show($"Bạn có muốn xóa lớp học có mã là {MALOP} này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                if (bllLopHocPhan.deleteLopHocPhan(dataGridView1.Rows[iDong].Cells["MALOP"].Value.ToString()) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa lớp học vui lòng kiểm tra lại dữ liệu");
                }
                else
                {
                    MessageBox.Show("Xóa lớp học thành công");
                }

                dataGridView1.DataSource = bllLopHocPhan.getAllLop();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int iDong = int.Parse(dataGridView1.SelectedRows[0].Index.ToString());
            if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.Rows[iDong].Cells[0].Value == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học phần trên bảng để để sửa", "Thông báo");
                return;
            }
            string MAMH = dataGridView1.Rows[iDong].Cells["MAMH"].Value.ToString();
            string MALOP = dataGridView1.Rows[iDong].Cells["MALOP"].Value.ToString();
            string TENGIANGVIEN = dataGridView1.Rows[iDong].Cells["TENGIANGVIEN"].Value.ToString();
            string PHONGHOC = dataGridView1.Rows[iDong].Cells["PHONGHOC"].Value.ToString();
            DateTime NGAYBATDAU = DateTime.Parse(dataGridView1.Rows[iDong].Cells["NGAYBATDAU"].Value.ToString());
            DateTime NGAYKETTHUC = DateTime.Parse(dataGridView1.Rows[iDong].Cells["NGAYKETTHUC"].Value.ToString());
            int SOLUONGSINHVIEN = int.Parse(dataGridView1.Rows[iDong].Cells["SOLUONGSINHVIEN"].Value.ToString());

            UC_EditLopHocPhan uC = new UC_EditLopHocPhan();
            clsLopHocPhan lopHocPhan = new clsLopHocPhan(MAMH,MALOP,TENGIANGVIEN,PHONGHOC,NGAYBATDAU,NGAYKETTHUC,SOLUONGSINHVIEN);
            uC.ClsLopHocPhan = lopHocPhan;
            this.Parent.Controls.Add(uC);
            this.Parent.Controls.Remove(this);
        }

        
    }
}
