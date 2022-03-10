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
    public partial class frmDichVu : Form
    {
        public frmDichVu(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        DichVu_BUL dichVu_BUL = new DichVu_BUL();
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dtGVDichVu.DataSource = dichVu_BUL.layToanBoDichVu();
            dtGVDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < dichVu_BUL.layToanBoDichVu().Rows.Count; i++)
            {
                cbTimDichVu.Items.Add(dichVu_BUL.layToanBoDichVu().Rows[i].ItemArray[0]);
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dtGVDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaDV.Text = dtGVDichVu.Rows[i].Cells[0].Value.ToString();
                txtTenDV.Text = dtGVDichVu.Rows[i].Cells[1].Value.ToString();
                txtGiaDV.Text = dtGVDichVu.Rows[i].Cells[2].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaDV.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }

        public void clear()
        {
            txtMaDV.Enabled = true;
            txtMaDV.Clear();
            txtMaDV.Focus();
            txtTenDV.Clear();
            txtGiaDV.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDV = txtMaDV.Text.ToUpper();
            string tenDV = txtTenDV.Text;
            float giaDV;
            
            if(txtMaDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã dịch vụ");
            }
            else if(txtTenDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên dịch vụ");
            }
            else if(txtGiaDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập giá dịch vụ");
            }
            else
            {
                giaDV =  float.Parse(txtGiaDV.Text);
                DichVu_DTO dichVu_DTO = new DichVu_DTO(maDV, tenDV, giaDV);
                if(dichVu_BUL.themDichVu(dichVu_DTO) > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    dtGVDichVu.DataSource = dichVu_BUL.layToanBoDichVu();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDV = txtMaDV.Text.ToUpper();
            string tenDV = txtTenDV.Text;
            float giaDV;

            if (txtMaDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã dịch vụ");
            }
            else if (txtTenDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên dịch vụ");
            }
            else if (txtGiaDV.Text == string.Empty)
            {
                MessageBox.Show("Nhập giá dịch vụ");
            }
            else
            {
                giaDV = float.Parse(txtGiaDV.Text);
                DichVu_DTO dichVu_DTO = new DichVu_DTO(maDV, tenDV, giaDV);
                if (dichVu_BUL.suaDichVu(dichVu_DTO) > 0)
                {
                    MessageBox.Show("Sửa dịch vụ thành công");
                    dtGVDichVu.DataSource = dichVu_BUL.layToanBoDichVu();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa dịch vụ thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaDV.Text.ToUpper();
            DichVu_DTO dichVu_DTO = new DichVu_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dichVu_BUL.xoaDichVu(dichVu_DTO) > 0)
                {
                    MessageBox.Show("Xóa dịch vụ thành công");
                    dtGVDichVu.DataSource = dichVu_BUL.layToanBoDichVu();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thất bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimDichVu.Text.ToUpper();
            DichVu_DTO dichVu_DTO = new DichVu_DTO(id);
            if (cbTimDichVu.Text != string.Empty)
            {
                if (dichVu_BUL.layMotDichVu(dichVu_DTO).Rows.Count > 0)
                {
                    dtGVDichVu.DataSource = dichVu_BUL.layMotDichVu(dichVu_DTO);
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã dịch vụ cần tìm");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVDichVu.DataSource = dichVu_BUL.layToanBoDichVu();
            cbTimDichVu.Text = null;
            cbTimDichVu.Items.Clear();
            for (int i = 0; i < dichVu_BUL.layToanBoDichVu().Rows.Count; i++)
            {
                cbTimDichVu.Items.Add(dichVu_BUL.layToanBoDichVu().Rows[i].ItemArray[0]);
            }
        }
    }
}
