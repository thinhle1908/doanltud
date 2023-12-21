namespace Doan_LTUD.UserControls
{
    partial class UC_EditMonHoccs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNienkhoa = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(296, 380);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(172, 45);
            this.btnTroVe.TabIndex = 27;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Magenta;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(97, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(172, 45);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(543, 303);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(344, 22);
            this.txtSoTien.TabIndex = 25;
            // 
            // txtNienkhoa
            // 
            this.txtNienkhoa.Location = new System.Drawing.Point(97, 303);
            this.txtNienkhoa.Name = "txtNienkhoa";
            this.txtNienkhoa.Size = new System.Drawing.Size(344, 22);
            this.txtNienkhoa.TabIndex = 24;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(543, 210);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(344, 22);
            this.txtHocKy.TabIndex = 23;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(543, 121);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(344, 22);
            this.txtMaKhoa.TabIndex = 22;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(97, 210);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(344, 22);
            this.txtTenMH.TabIndex = 21;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(97, 121);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(344, 22);
            this.txtMaMH.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Khoa:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số Tiền:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Học Kỳ:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Niên Khóa:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Môn Học:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Môn Học:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_EditMonHoccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtNienkhoa);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_EditMonHoccs";
            this.Size = new System.Drawing.Size(1639, 950);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtNienkhoa;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
