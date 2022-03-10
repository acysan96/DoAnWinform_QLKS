using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BUL_QLKS;
using DTO_QLKS;

namespace DoAnWinform_QLKS.Admin
{
    public partial class frmAdminMain_NhanVien : Form
    {
        public frmAdminMain_NhanVien(frmLogin frmLogin)
        {
            InitializeComponent();
            _frm = frmLogin;
        }
        // Khai báo BUL
        User_BUL user_BUL = new User_BUL();
        // Khai báo form Login
        frmLogin _frm;
        // Form Load
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
            dtGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < user_BUL.layToanBoUsers().Rows.Count; i++)
            {
                cbTimNV.Items.Add(user_BUL.layToanBoUsers().Rows[i].ItemArray[0]);
            }
            cbPermission.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            đăngXuấtToolStripMenuItem.Image = imageList3.Images[0];
            qLHDToolStripMenuItem.Image = imageList3.Images[1];
            qLHàngHóaToolStripMenuItem.Image = imageList3.Images[2];
            qLKháchHàngToolStripMenuItem.Image = imageList3.Images[3];
            qLPhòngToolStripMenuItem.Image = imageList3.Images[4];
            qLLoạiPhòngToolStripMenuItem.Image = imageList3.Images[5];
            qLNhàCungCấpToolStripMenuItem.Image = imageList3.Images[6];
            qLDịchVụToolStripMenuItem.Image = imageList3.Images[7];
            qLPhiếuChiToolStripMenuItem.Image = imageList3.Images[8];
        }
        // Form Close
        private void frmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        // Click DataGridView
        private void dtGWNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaNV.Text = dtGVNhanVien.Rows[i].Cells[0].Value.ToString();
                if (dtGVNhanVien.Rows[i].Cells[1].Value.ToString().StartsWith("Admin"))
                {
                    cbPermission.SelectedIndex = 0;
                }
                else if (dtGVNhanVien.Rows[i].Cells[1].Value.ToString().StartsWith("Employee"))
                {
                    cbPermission.SelectedIndex = 1;
                }
                else
                {
                    cbPermission.SelectedIndex = 2;
                }
                txtFullName.Text = dtGVNhanVien.Rows[i].Cells[2].Value.ToString();
                if (dtGVNhanVien.Rows[i].Cells[3].Value.ToString() == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                dtpNgaySinh.Text = dtGVNhanVien.Rows[i].Cells[4].Value.ToString();
                txtDiaChi.Text = dtGVNhanVien.Rows[i].Cells[5].Value.ToString();
                txtSoDT.Text = dtGVNhanVien.Rows[i].Cells[6].Value.ToString();
                txtTaiKhoan.Text = dtGVNhanVien.Rows[i].Cells[7].Value.ToString();
                txtMatKhau.Text = dtGVNhanVien.Rows[i].Cells[8].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaNV.Enabled = false;
            }
        }
        // Button thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }
        // Hàm check gender
        public string gender()
        {
            if (rdNam.Checked == true)
            {
                return "Nam";
            }
            else
            {
                return "Nữ";
            }
        }
        // Hàm clear form
        public void clear()
        {
            txtMaNV.Enabled = true;
            txtMaNV.Clear();
            txtMaNV.Focus();
            cbPermission.Text = null;
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtFullName.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        // Hàm check permission
        public string permission()
        {
            if (cbPermission.SelectedIndex == 0)
            {
                return "Admin";
            }
            else if (cbPermission.SelectedIndex == 1)
            {
                return "Employee";
            }
            else
            {
                return "DoNotGrantPermission";
            }
        }
        // Hàm thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text.ToUpper();
            string fullName = txtFullName.Text;
            DateTime birthday = dtpNgaySinh.Value;
            string address = txtDiaChi.Text;
            string phone = txtSoDT.Text;
            string userName = txtTaiKhoan.Text;
            string password = maHoaMD5(txtMatKhau.Text);
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhân viên");
            }
            else if (permission() == string.Empty)
            {
                MessageBox.Show("Chọn phân quyền nhân viên");
            }
            else if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhân viên");
            }
            else if (gender() == string.Empty)
            {
                MessageBox.Show("Chọn giới tính");
            }
            else if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập địa chỉ");
            }
            else if (txtSoDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else
            {
                //for (int i = 0; i < user_BUL.layToanBoUsers().Rows.Count; ++i)
                //{
                //    if (user_BUL.layToanBoUsers().Rows[i].ItemArray[0].ToString().StartsWith(id))
                //    {
                //        MessageBox.Show("Mã nhân viên đã có trong danh sách");
                //        break;
                //    }
                //    else
                //    {
                if (permission() == "DoNotGrantPermission")
                {
                    userName = " ";
                    password = " ";
                }
                User_DTO user_DTO = new User_DTO(id, permission(), fullName, gender(), birthday, address, phone, userName, password);
                //for (int i = 0; i < dtGVNhanVien.Rows.Count; i++)
                //{
                //    if (dtGVNhanVien.Rows[i].Cells[0].Value.ToString().StartsWith(id))
                //    {
                //        MessageBox.Show("Mã nhân viên đã có trong danh sách");
                //        break;
                //    }
                //    else
                //    {
                //        if (user_BUL.themUser(user_DTO) > 0)
                //        {
                //            MessageBox.Show("Thêm nhân viên thành công");
                //            dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
                //            clear();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Thêm nhân viên thất bại");
                //        }
                //    }
                //}
                if (user_BUL.themUser(user_DTO) > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
                //    }
                //}
            }
        }
        // Hàm sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text.ToUpper();
            string fullName = txtFullName.Text;
            DateTime birthday = dtpNgaySinh.Value;
            string address = txtDiaChi.Text;
            string phone = txtSoDT.Text;
            string userName = txtTaiKhoan.Text;
            string password = maHoaMD5(txtMatKhau.Text);
            User_DTO user_DTO = new User_DTO(id, permission(), fullName, gender(), birthday, address, phone, userName, password);
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhân viên");
            }
            else if (permission() == string.Empty)
            {
                MessageBox.Show("Chọn phân quyền nhân viên");
            }
            else if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhân viên");
            }
            else if (gender() == string.Empty)
            {
                MessageBox.Show("Chọn giới tính");
            }
            else if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập địa chỉ");
            }
            else if (txtSoDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else if (txtTaiKhoan.Text == string.Empty)
            {
                userName = "null";
            }
            else if (txtMatKhau.Text == string.Empty)
            {
                password = "null";
            }
            else
            {
                if (user_BUL.suaUser(user_DTO) > 0)
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại");
                }
            }
        }
        // Hàm xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text.ToUpper();
            User_DTO user_DTO = new User_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (user_BUL.xoaUser(user_DTO) > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
        }
        // Hàm clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        // Hàm tìm kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimNV.Text.ToUpper();
            User_DTO user_DTO = new User_DTO(id);
            if (cbTimNV.Text != string.Empty)
            {
                if (user_BUL.layMotUser(user_DTO).Rows.Count > 0)
                {
                    dtGVNhanVien.DataSource = user_BUL.layMotUser(user_DTO);
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã nhân viên cần tìm");
            }
        }
        // Hàm load data
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVNhanVien.DataSource = user_BUL.layToanBoUsers();
            cbTimNV.Text = null;
            cbTimNV.Items.Clear();
            for (int i = 0; i < user_BUL.layToanBoUsers().Rows.Count; i++)
            {
                cbTimNV.Items.Add(user_BUL.layToanBoUsers().Rows[i].ItemArray[0]);
            }
        }

        private void qLHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon(this);
            frm.Show();
            this.Hide();
        }

        private void qLHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa(this);
            frm.Show();
            this.Hide();
        }

        private void qLKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang(this);
            frm.Show();
            this.Hide();
        }

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong(this);
            frm.Show();
            this.Hide();
        }

        private void qLLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frm = new frmLoaiPhong(this);
            frm.Show();
            this.Hide();
        }

        private void qLNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap(this);
            frm.Show();
            this.Hide();
        }

        private void qLDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu(this);
            frm.Show();
            this.Hide();
        }

        private void qLPhiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuChi frm = new frmPhieuChi(this);
            frm.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Hide();
        }

        private void cbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPermission.SelectedIndex == 0)
            {
                txtTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            if (cbPermission.SelectedIndex == 1)
            {
                txtTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            if (cbPermission.SelectedIndex == 2)
            {
                txtTaiKhoan.Enabled = false;
                txtMatKhau.Enabled = false;
            }
        }
        // Mã hóa MD5
        private string maHoaMD5(string chuoiMaHoa)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoiMaHoa);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            mang = md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;
        }
    }
}
