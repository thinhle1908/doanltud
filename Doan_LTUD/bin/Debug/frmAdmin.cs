using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan_LTUD.UserControls;
using DTO;

namespace Doan_LTUD
{
    public partial class frmAdmin : Form
    {
        private clsUser user_id;

        public clsUser User_id { get => user_id; set => user_id = value; }

        public frmAdmin()
        {
            InitializeComponent();
            
            
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            if(user_id.Username.Length > 0)
            {
                label3.Text = "Tài khoản : " + user_id.Username;
                label4.Text = "Vai trò : Admin";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không ?","Đăng xuất" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
               this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {

            //userControl.Dock = DockStyle.Fill;
            //Xóa user frm đang hiển thị trên màn hình
            panelContainer.Controls.Clear();
            //Hiển thị frm vừa mới click
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_SinhVien uc = new UC_SinhVien();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_MonHoc uc = new UC_MonHoc();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_LopHocPhan uc = new UC_LopHocPhan();
            addUserControl(uc);
        }
    }
}
