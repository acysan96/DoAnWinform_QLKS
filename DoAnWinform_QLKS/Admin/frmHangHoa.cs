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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        HangHoa_BUL hangHoa_BUL = new HangHoa_BUL();
        NhaCungCap_BUL nhaCungCap_BUL = new NhaCungCap_BUL();
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dtGVHangHoa.DataSource = hangHoa_BUL.layToanBoHangHoa();
            dtGVHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < hangHoa_BUL.layToanBoHangHoa().Rows.Count; i++)
            {
                cbTimHH.Items.Add(hangHoa_BUL.layToanBoHangHoa().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < nhaCungCap_BUL.layToanBoNhaCungCap().Rows.Count; i++)
            {
                cbMaNCC.Items.Add(nhaCungCap_BUL.layToanBoNhaCungCap().Rows[i].ItemArray[0]);
            }
            cbDonViTinh.Items.Add("VND");
            cbDonViTinh.Items.Add("USD");
            cbMaNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dtGVHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaHH.Text = dtGVHangHoa.Rows[i].Cells[0].Value.ToString();
                cbMaNCC.Text = dtGVHangHoa.Rows[i].Cells[1].Value.ToString();
                txtTenHH.Text = dtGVHangHoa.Rows[i].Cells[2].Value.ToString();
                txtLoaiHangHoa.Text = dtGVHangHoa.Rows[i].Cells[3].Value.ToString();
                txtDonGia.Text = dtGVHangHoa.Rows[i].Cells[4].Value.ToString();
                if(dtGVHangHoa.Rows[i].Cells[5].Value.ToString().StartsWith("VND"))
                {
                    cbDonViTinh.SelectedIndex = 0;
                }
                else
                {
                    cbDonViTinh.SelectedIndex = 1;
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaHH.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }

        public void clear()
        {
            txtMaHH.Enabled = true;
            txtMaHH.Clear();
            txtMaHH.Focus();
            cbMaNCC.Text = null;
            txtTenHH.Clear();
            txtLoaiHangHoa.Clear();
            txtDonGia.Clear();
            cbDonViTinh.Text = null;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHH = txtMaHH.Text.ToUpper();
            string maNCC = cbMaNCC.Text;
            string tenHH = txtTenHH.Text;
            string loaiHH = txtLoaiHangHoa.Text;
            float donGia;
            string donViTinh = cbDonViTinh.Text;
            if(txtMaHH.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã hàng hóa");
            }
            else if (cbMaNCC.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhà cung cấp");
            }
            else if (txtTenHH.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên hàng hóa");
            }
            else if (txtLoaiHangHoa.Text == string.Empty)
            {
                MessageBox.Show("Nhập loại hàng hóa");
            }
            else if (txtDonGia.Text == string.Empty)
            {
                MessageBox.Show("Nhập đơn giá");
            }
            else if (cbDonViTinh.Text == string.Empty)
            {
                MessageBox.Show("Chọn đơn vị tính");
            }
            else
            {
                donGia = float.Parse(txtDonGia.Text);
                HangHoa_DTO hangHoa_DTO = new HangHoa_DTO(maHH, maNCC, tenHH, loaiHH, donGia, donViTinh);
                if(hangHoa_BUL.themHangHoa(hangHoa_DTO) > 0)
                {
                    MessageBox.Show("Thêm hàng hóa thành công");
                    dtGVHangHoa.DataSource = hangHoa_BUL.layToanBoHangHoa();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm hàng hóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHH = txtMaHH.Text.ToUpper();
            string maNCC = cbMaNCC.Text;
            string tenHH = txtTenHH.Text;
            string loaiHH = txtLoaiHangHoa.Text;
            float donGia;
            string donViTinh = cbDonViTinh.Text;
            if (txtMaHH.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã hàng hóa");
            }
            else if (cbMaNCC.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhà cung cấp");
            }
            else if (txtTenHH.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên hàng hóa");
            }
            else if (txtLoaiHangHoa.Text == string.Empty)
            {
                MessageBox.Show("Nhập loại hàng hóa");
            }
            else if (txtDonGia.Text == string.Empty)
            {
                MessageBox.Show("Nhập đơn giá");
            }
            else if (cbDonViTinh.Text == string.Empty)
            {
                MessageBox.Show("Chọn đơn vị tính");
            }
            else
            {
                donGia = float.Parse(txtDonGia.Text);
                HangHoa_DTO hangHoa_DTO = new HangHoa_DTO(maHH, maNCC, tenHH, loaiHH, donGia, donViTinh);
                if (hangHoa_BUL.suaHangHoa(hangHoa_DTO) > 0)
                {
                    MessageBox.Show("Sửa hàng hóa thành công");
                    dtGVHangHoa.DataSource = hangHoa_BUL.layToanBoHangHoa();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa hàng hóa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaHH.Text.ToUpper();
            HangHoa_DTO hangHoa_DTO = new HangHoa_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (hangHoa_BUL.xoaHangHoa(hangHoa_DTO) > 0)
                {
                    MessageBox.Show("Xóa hàng hóa thành công");
                    dtGVHangHoa.DataSource = hangHoa_BUL.layToanBoHangHoa();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa hàng hóa thất bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVHangHoa.DataSource = hangHoa_BUL.layToanBoHangHoa();
            cbTimHH.Text = null;
            cbTimHH.Items.Clear();
            for (int i = 0; i < hangHoa_BUL.layToanBoHangHoa().Rows.Count; i++)
            {
                cbTimHH.Items.Add(hangHoa_BUL.layToanBoHangHoa().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimHH.Text.ToUpper();
            HangHoa_DTO hangHoa_DTO = new HangHoa_DTO(id);
            if (cbTimHH.Text != string.Empty)
            {
                if (hangHoa_BUL.layMotHangHoa(hangHoa_DTO).Rows.Count > 0)
                {
                    dtGVHangHoa.DataSource = hangHoa_BUL.layMotHangHoa(hangHoa_DTO);
                }
                else
                {
                    MessageBox.Show("Mã hàng hóa không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã hàng hóa cần tìm");
            }
        }
    }
}
