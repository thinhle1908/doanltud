using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Doan_LTUD;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lbThongBao.Visible = false;
            txtMatKhau.PasswordChar = '*';
            txtTenDangNhap.Focus();
        }
        BLL_User bll_user = new BLL_User();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string sTenDangNhap = txtTenDangNhap.Text;
            string sMatKhau = txtMatKhau.Text;

            //Kiểm tra rỗng
            if(sTenDangNhap.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập");
                return;
            }
            if(sMatKhau.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
                return;
            }
            //Check login
            clsUser user = new clsUser(sTenDangNhap, sMatKhau);
            if (bll_user.login(user) == 1)
            {
                MessageBox.Show("Đăng nhập thành công tài khoản admin");
                lbThongBao.Visible = false;
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                this.Visible = false;
                frmAdmin frmadmin = new frmAdmin();
                //Truyền id của user qua form frmadmin
                frmadmin.User_id = user;
                frmadmin.Show();
                //Hàm FormClosed khi tắt frmAdmin lệnh này sẽ được gọi
                frmadmin.FormClosed += new FormClosedEventHandler(MyFrom_FormClose);

            }
            else if (bll_user.login(user) == 2)
            {
                MessageBox.Show("Đăng nhập thành công tài khoản sinh viên");
                lbThongBao.Visible = false;
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
                this.Visible = false;
                frmUser frmUser = new frmUser();
                //Truyền id của user qua form frmadmin
                frmUser.User_id = user;
                frmUser.Show();
                //Hàm FormClosed khi tắt frmAdmin lệnh này sẽ được gọi
                frmUser.FormClosed += new FormClosedEventHandler(MyFrom_FormClose);
            }
            else if(bll_user.login(user) == 3)
            {
                MessageBox.Show("Đăng nhập không thành công");
                lbThongBao.Visible = true;
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bạn có thê liên hệ quản trị viên để có thể lấy lại mật khẩu","Thông báo");
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnDangNhap;
            
        }
        //Formclosed
        public void MyFrom_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;

        }
    }
}
