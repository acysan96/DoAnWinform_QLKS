using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUL_QLKS;

namespace DoAnWinform_QLKS.Employee
{
    public partial class frmEmployeeMain : Form
    {
        public frmEmployeeMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frm = frmLogin;
        }
        frmLogin _frm;
        Phong_BUL phong_BUL = new Phong_BUL();
        public string maNV { get; set; }
        private void frmEmployeeMain_Load(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.Image = imageList3.Images[0];
            quảnLýKháchHàngToolStripMenuItem.Image = imageList3.Images[1];
            đặtPhòngToolStripMenuItem.Image = imageList3.Images[2];
            checkTinhTrangPhong(btnCNT1);
            checkTinhTrangPhong(btnCNT2);
            checkTinhTrangPhong(btnCNT3);
            checkTinhTrangPhong(btnCNT4);
            checkTinhTrangPhong(btnCNT5);
            checkTinhTrangPhong(btnCNT6);
            checkTinhTrangPhong(btnSUP1);
            checkTinhTrangPhong(btnSUP2);
            checkTinhTrangPhong(btnSUP3);
            checkTinhTrangPhong(btnSUP4);
            checkTinhTrangPhong(btnSUP5);
            checkTinhTrangPhong(btnSUP6);
            checkTinhTrangPhong(btnDLX1);
            checkTinhTrangPhong(btnDLX2);
            checkTinhTrangPhong(btnDLX3);
            checkTinhTrangPhong(btnDLX4);
            checkTinhTrangPhong(btnDLX5);
            checkTinhTrangPhong(btnDLX6);
            checkTinhTrangPhong(btnSTD1);
            checkTinhTrangPhong(btnSTD2);
            checkTinhTrangPhong(btnSTD3);
            checkTinhTrangPhong(btnSTD4);
            checkTinhTrangPhong(btnSTD5);
            checkTinhTrangPhong(btnSTD6);
            checkTinhTrangPhong(btnSUT1);
            checkTinhTrangPhong(btnSUT2);
            checkTinhTrangPhong(btnSUT3);
            checkTinhTrangPhong(btnSUT4);
            checkTinhTrangPhong(btnSUT5);
            checkTinhTrangPhong(btnSUT6);
            
        }

        private void checkTinhTrangPhong(Button btn)
        {
            for (int i = 0; i < phong_BUL.layToanBoPhong().Rows.Count; i++)
            {
                if (phong_BUL.layToanBoPhong().Rows[i].ItemArray[3].ToString() == "Hired" && phong_BUL.layToanBoPhong().Rows[i].ItemArray[0].ToString().StartsWith(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
            }
        }

        private void checkKhachHang(Button btn)
        {
            if(btn.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng này đã có khách đặt, vui lòng chọn phòng khác !");
            }
            else
            {
                DialogResult r = MessageBox.Show("Có đăng ký khách hàng mới không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    frmKhachHang frm = new frmKhachHang(this);
                    frm.Show();
                    this.Hide();
                }
                else if (r == DialogResult.No)
                {
                    frmDatPhong frm = new frmDatPhong(this);
                    frm.maPhong = btn.Text;
                    frm.maNV = maNV;
                    frm.Show();
                    this.Hide();
                }
            } 
        }

        private void btnSTD1_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD1);
        }

        private void btnSTD2_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD2);
        }

        private void btnSTD3_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD3);
        }

        private void btnSTD4_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD4);
        }

        private void btnSTD5_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD5);
        }

        private void btnSTD6_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSTD6);
        }

        private void btnSUP1_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP1);
        }

        private void btnSUP2_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP2);
        }

        private void btnSUP3_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP3);
        }

        private void btnSUP4_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP4);
        }

        private void btnSUP5_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP5);
        }

        private void btnSUP6_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUP6);
        }

        private void btnDLX1_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX1);
        }

        private void btnDLX2_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX2);
        }

        private void btnDLX3_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX3);
        }

        private void btnDLX4_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX4);
        }

        private void btnDLX5_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX5);
        }

        private void btnDLX6_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnDLX6);
        }

        private void btnSUT1_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT1);
        }

        private void btnSUT2_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT2);
        }

        private void btnSUT3_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT3);
        }

        private void btnSUT4_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT4);
        }

        private void btnSUT5_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT5);
        }

        private void btnSUT6_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnSUT6);
        }

        private void btnCNT1_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT1);
        }

        private void btnCNT2_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT2);
        }

        private void btnCNT3_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT3);
        }

        private void btnCNT4_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT4);
        }

        private void btnCNT5_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT5);
        }

        private void btnCNT6_Click(object sender, EventArgs e)
        {
            checkKhachHang(btnCNT6);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Hide();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong(this);
            frm.Text = null;
            frm.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang(this);
            frm.Show();
            this.Hide();
        }
    }
}
