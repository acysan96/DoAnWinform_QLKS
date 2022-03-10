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

namespace DoAnWinform_QLKS.Admin
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dtGVKhachHang.DataSource = khachHang_BUL.layToanBoKhachHang();
            dtGVKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < khachHang_BUL.layToanBoKhachHang().Rows.Count; i++)
            {
                cbTimKH.Items.Add(khachHang_BUL.layToanBoKhachHang().Rows[i].ItemArray[0]);
            }
            cbXepHang.Items.Add("Bạc");
            cbXepHang.Items.Add("Vàng");
            cbXepHang.Items.Add("Bạch Kim");
            cbXepHang.Items.Add("Kim Cương");
            cbXepHang.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dtGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaKH.Text = dtGVKhachHang.Rows[i].Cells[0].Value.ToString();
                txtHoTenKH.Text = dtGVKhachHang.Rows[i].Cells[1].Value.ToString();
                cbXepHang.Text = dtGVKhachHang.Rows[i].Cells[2].Value.ToString();
                txtSDT.Text = dtGVKhachHang.Rows[i].Cells[3].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaKH.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }

        public void clear()
        {
            txtMaKH.Enabled = true;
            txtMaKH.Clear();
            txtMaKH.Focus();
            txtHoTenKH.Clear();
            cbXepHang.Text = null;
            txtSDT.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.ToUpper();
            string tenKH = txtHoTenKH.Text;
            string rank = cbXepHang.Text;
            string sdt = txtSDT.Text;
            if (txtMaKH.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã khách hàng");
            }
            else if (txtHoTenKH.Text == string.Empty)
            {
                MessageBox.Show("Nhập họ tên khách hàng");
            }
            else if (cbXepHang.Text == string.Empty)
            {
                MessageBox.Show("Chọn xếp hạng");
            }
            else if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else
            {
                KhachHang_DTO khachHang_DTO = new KhachHang_DTO(maKH, tenKH, rank, sdt);
                if(khachHang_BUL.themKhachHang(khachHang_DTO) > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    dtGVKhachHang.DataSource = khachHang_BUL.layToanBoKhachHang();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.ToUpper();
            string tenKH = txtHoTenKH.Text;
            string rank = cbXepHang.Text;
            string sdt = txtSDT.Text;
            if (txtMaKH.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã khách hàng");
            }
            else if (txtHoTenKH.Text == string.Empty)
            {
                MessageBox.Show("Nhập họ tên khách hàng");
            }
            else if (cbXepHang.Text == string.Empty)
            {
                MessageBox.Show("Chọn xếp hạng");
            }
            else if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else
            {
                KhachHang_DTO khachHang_DTO = new KhachHang_DTO(maKH, tenKH, rank, sdt);
                if (khachHang_BUL.suaKhachHang(khachHang_DTO) > 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công");
                    dtGVKhachHang.DataSource = khachHang_BUL.layToanBoKhachHang();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaKH.Text.ToUpper();
            KhachHang_DTO khachHang_DTO = new KhachHang_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (khachHang_BUL.xoaKhachHang(khachHang_DTO) > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    dtGVKhachHang.DataSource = khachHang_BUL.layToanBoKhachHang();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVKhachHang.DataSource = khachHang_BUL.layToanBoKhachHang();
            cbTimKH.Text = null;
            cbTimKH.Items.Clear();
            for (int i = 0; i < khachHang_BUL.layToanBoKhachHang().Rows.Count; i++)
            {
                cbTimKH.Items.Add(khachHang_BUL.layToanBoKhachHang().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimKH.Text.ToUpper();
            KhachHang_DTO khachHang_DTO = new KhachHang_DTO(id);
            if (cbTimKH.Text != string.Empty)
            {
                if (khachHang_BUL.layMotKhachHang(khachHang_DTO).Rows.Count > 0)
                {
                    dtGVKhachHang.DataSource = khachHang_BUL.layMotKhachHang(khachHang_DTO);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã khách hàng cần tìm");
            }
        }
    }
}
