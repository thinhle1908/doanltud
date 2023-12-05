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
    public partial class UC_AddSinhVien : UserControl
    {
        public UC_AddSinhVien()
        {
            InitializeComponent();
        }

        private void UC_AddSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //Ẩn UC_SinhVien để hiển thị ra UC_AddSinhVien
            
            
        }
    }
}
