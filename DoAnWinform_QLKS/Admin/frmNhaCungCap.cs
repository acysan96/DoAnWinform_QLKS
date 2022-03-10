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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        NhaCungCap_BUL nhaCungCap_BUL = new NhaCungCap_BUL();
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layToanBoNhaCungCap();
            dtGVNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < nhaCungCap_BUL.layToanBoNhaCungCap().Rows.Count; i++)
            {
                cbTimNhaCungCap.Items.Add(nhaCungCap_BUL.layToanBoNhaCungCap().Rows[i].ItemArray[0]);
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }

        public void clear()
        {
            txtMaNhaCungCap.Enabled = true;
            txtMaNhaCungCap.Clear();
            txtMaNhaCungCap.Focus();
            txtTenNhaCungCap.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dtGVNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaNhaCungCap.Text = dtGVNhaCungCap.Rows[i].Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = dtGVNhaCungCap.Rows[i].Cells[1].Value.ToString();
                txtSDT.Text = dtGVNhaCungCap.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dtGVNhaCungCap.Rows[i].Cells[3].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaNhaCungCap.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNhaCungCap.Text.ToUpper();
            string tenNCC = txtTenNhaCungCap.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            if (txtMaNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhà cung cấp");
            }
            else if (txtTenNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhà cung cấp");
            }
            else if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập địa chỉ");
            }
            else
            {
                NhaCungCap_DTO nhaCungCap_DTO = new NhaCungCap_DTO(maNCC, tenNCC, sdt, diaChi);
                if(nhaCungCap_BUL.themNhaCungCap(nhaCungCap_DTO) > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layToanBoNhaCungCap();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNhaCungCap.Text.ToUpper();
            string tenNCC = txtTenNhaCungCap.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            if (txtMaNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã nhà cung cấp");
            }
            else if (txtTenNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên nhà cung cấp");
            }
            else if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Nhập số điện thoại");
            }
            else if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập địa chỉ");
            }
            else
            {
                NhaCungCap_DTO nhaCungCap_DTO = new NhaCungCap_DTO(maNCC, tenNCC, sdt, diaChi);
                if (nhaCungCap_BUL.suaNhaCungCap(nhaCungCap_DTO) > 0)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                    dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layToanBoNhaCungCap();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa nhà cung cấp thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaNhaCungCap.Text.ToUpper();
            NhaCungCap_DTO nhaCungCap_DTO = new NhaCungCap_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (nhaCungCap_BUL.xoaNhaCungCap(nhaCungCap_DTO) > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layToanBoNhaCungCap();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layToanBoNhaCungCap();
            cbTimNhaCungCap.Text = null;
            cbTimNhaCungCap.Items.Clear();
            for (int i = 0; i < nhaCungCap_BUL.layToanBoNhaCungCap().Rows.Count; i++)
            {
                cbTimNhaCungCap.Items.Add(nhaCungCap_BUL.layToanBoNhaCungCap().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimNhaCungCap.Text.ToUpper();
            NhaCungCap_DTO nhaCungCap_DTO = new NhaCungCap_DTO(id);
            if (cbTimNhaCungCap.Text != string.Empty)
            {
                if (nhaCungCap_BUL.layMotNhaCungCap(nhaCungCap_DTO).Rows.Count > 0)
                {
                    dtGVNhaCungCap.DataSource = nhaCungCap_BUL.layMotNhaCungCap(nhaCungCap_DTO);
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã nhà cung cấp cần tìm");
            }
        }
    }
}
