using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Doan_LTUD.UserControls
{
    public partial class UC_ChangePassword : UserControl
    {
        private string _username;
        BLL_User bLL_User = new BLL_User();

        public string Username { get => _username; set => _username = value; }

        public UC_ChangePassword(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void btnMatKhauCu_Click(object sender, EventArgs e)
        {
            setIcon(btnMatKhauCu, txtNhapMatKhauCu);
            
        }
        public void setIcon(Button btn,TextBox txt)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                btn.Image = Properties.Resources.eyefix3;

            }
            else
            {
                txt.PasswordChar = '*';
                btn.Image = Properties.Resources.noeye5;
            }
           

        }

        private void btnMatKhauMoi_Click(object sender, EventArgs e)
        {
            setIcon(btnMatKhauMoi, txtNhapMatKhauMoi);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            setIcon(btnXacNhan, txtXacNhanMatKhau);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNhapMatKhauCu.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtNhapMatKhauCu, "Vui lòng nhập mật khẩu cũ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNhapMatKhauCu, "");
            }
            //Kiểm tra rỗng 
            if (txtNhapMatKhauMoi.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtNhapMatKhauMoi, "Vui lòng nhập mật khẩu mới");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNhapMatKhauMoi, "");

            }
            //Kiểm tra rỗng 
            if (txtXacNhanMatKhau.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Vui lòng nhập xác nhận mật khẩu");
                return;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "");

            }
            //Kiểm tra nếu mật khẩu mới không giống xác nhận mật khẩu mới 
            if (txtNhapMatKhauMoi.Text.Trim() != txtXacNhanMatKhau.Text.Trim())
            {
                errorProvider1.SetError(txtNhapMatKhauMoi, "Mật khẩu mới không trùng với xác nhận mật khẩu");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNhapMatKhauMoi, "");

            }
            //Kiểm tra mật khẩu cũ có giống với database

            int iKetQua = bLL_User.changePassword(Username.Trim(),txtNhapMatKhauCu.Text.Trim(),txtXacNhanMatKhau.Text.Trim());
            if (iKetQua == 1)
            {
                MessageBox.Show($"Đổi mật khẩu thành công", "Thông báo");
                txtNhapMatKhauCu.Text = "";
                txtNhapMatKhauMoi.Text = "";
                txtXacNhanMatKhau.Text = "";
                label5.Visible = false;

            }
            else if(iKetQua == 2)
            {
                MessageBox.Show($"Đổi mật khẩu không thành công, mật khẩu cũ không chính xác", "Thông báo");
                txtNhapMatKhauCu.Text = "";
                txtNhapMatKhauMoi.Text = "";
                txtXacNhanMatKhau.Text = "";
                label5.Visible = true;
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình đổi mật khẩu", "Thông báo");
            }
        }
    }
}
