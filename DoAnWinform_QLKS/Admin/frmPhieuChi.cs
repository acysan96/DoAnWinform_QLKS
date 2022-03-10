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
    public partial class frmPhieuChi : Form
    {
        public frmPhieuChi(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        PhieuChi_BUL phieuChi_BUL = new PhieuChi_BUL();
        HangHoa_BUL hangHoa_BUL = new HangHoa_BUL();
        User_BUL user_BUL = new User_BUL();
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmPhieuChi_Load(object sender, EventArgs e)
        {
            dtGVPhieuChi.DataSource = phieuChi_BUL.layToanBoPhieuChi();
            dtGVPhieuChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVPhieuChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < phieuChi_BUL.layToanBoPhieuChi().Rows.Count; i++)
            {
                cbTimPhieuChi.Items.Add(phieuChi_BUL.layToanBoPhieuChi().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < hangHoa_BUL.layToanBoHangHoa().Rows.Count; i++)
            {
                cbMaHH.Items.Add(hangHoa_BUL.layToanBoHangHoa().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < user_BUL.layToanBoUsers().Rows.Count; i++)
            {
                cbMaNV.Items.Add(user_BUL.layToanBoUsers().Rows[i].ItemArray[0]);
            }
            cbMaHH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmPhieuChi_FormClosing(object sender, FormClosingEventArgs e)
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
            txtMaPhieuChi.Enabled = true;
            txtMaPhieuChi.Clear();
            txtMaPhieuChi.Focus();
            cbMaHH.Text = null;
            cbMaNV.Text = null;
            txtTongGia.Clear();
            dtpNgayTao.Value = DateTime.Now;
            dtpNgayNhan.Value = DateTime.Now;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dtGVPhieuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaPhieuChi.Text = dtGVPhieuChi.Rows[i].Cells[0].Value.ToString();
                cbMaHH.Text = dtGVPhieuChi.Rows[i].Cells[1].Value.ToString();
                cbMaNV.Text = dtGVPhieuChi.Rows[i].Cells[2].Value.ToString();
                txtTongGia.Text = dtGVPhieuChi.Rows[i].Cells[3].Value.ToString();
                dtpNgayTao.Text = dtGVPhieuChi.Rows[i].Cells[4].Value.ToString();
                dtpNgayNhan.Text = dtGVPhieuChi.Rows[i].Cells[5].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaPhieuChi.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieuChi.Text.ToUpper();
            string maHH = cbMaHH.Text;
            string maNV = cbMaNV.Text;
            float tongGia;
            DateTime ngayTao = dtpNgayTao.Value;
            DateTime ngayNhan = dtpNgayNhan.Value;
            if (txtMaPhieuChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã phiếu chi");
            }
            else if (cbMaHH.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã hàng hóa");
            }
            else if (cbMaNV.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhân viên");
            }
            else if (txtTongGia.Text == string.Empty)
            {
                MessageBox.Show("Nhập tổng giá");
            }
            else
            {
                tongGia = float.Parse(txtTongGia.Text);
                PhieuChi_DTO phieuChi_DTO = new PhieuChi_DTO(maPhieu, maHH, maNV, tongGia, ngayTao, ngayNhan);
                if(phieuChi_BUL.themPhieuChi(phieuChi_DTO) > 0)
                {
                    MessageBox.Show("Thêm phiếu chi thành công");
                    dtGVPhieuChi.DataSource = phieuChi_BUL.layToanBoPhieuChi();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu chi thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieuChi.Text.ToUpper();
            string maHH = cbMaHH.Text;
            string maNV = cbMaNV.Text;
            float tongGia;
            DateTime ngayTao = dtpNgayTao.Value;
            DateTime ngayNhan = dtpNgayNhan.Value;
            if (txtMaPhieuChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã phiếu chi");
            }
            else if (cbMaHH.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã hàng hóa");
            }
            else if (cbMaNV.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhân viên");
            }
            else if (txtTongGia.Text == string.Empty)
            {
                MessageBox.Show("Nhập tổng giá");
            }
            else
            {
                tongGia = float.Parse(txtTongGia.Text);
                PhieuChi_DTO phieuChi_DTO = new PhieuChi_DTO(maPhieu, maHH, maNV, tongGia, ngayTao, ngayNhan);
                if (phieuChi_BUL.suaPhieuChi(phieuChi_DTO) > 0)
                {
                    MessageBox.Show("Sửa phiếu chi thành công");
                    dtGVPhieuChi.DataSource = phieuChi_BUL.layToanBoPhieuChi();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa phiếu chi thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaPhieuChi.Text.ToUpper();
            PhieuChi_DTO phieuChi_DTO = new PhieuChi_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu chi này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (phieuChi_BUL.xoaPhieuChi(phieuChi_DTO) > 0)
                {
                    MessageBox.Show("Xóa phiếu chi thành công");
                    dtGVPhieuChi.DataSource = phieuChi_BUL.layToanBoPhieuChi();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu chi thất bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVPhieuChi.DataSource = phieuChi_BUL.layToanBoPhieuChi();
            cbTimPhieuChi.Text = null;
            cbTimPhieuChi.Items.Clear();
            for (int i = 0; i < phieuChi_BUL.layToanBoPhieuChi().Rows.Count; i++)
            {
                cbTimPhieuChi.Items.Add(phieuChi_BUL.layToanBoPhieuChi().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimPhieuChi.Text.ToUpper();
            PhieuChi_DTO phieuChi_DTO = new PhieuChi_DTO(id);
            if (cbTimPhieuChi.Text != string.Empty)
            {
                if (phieuChi_BUL.layMotPhieuChi(phieuChi_DTO).Rows.Count > 0)
                {
                    dtGVPhieuChi.DataSource = phieuChi_BUL.layMotPhieuChi(phieuChi_DTO);
                }
                else
                {
                    MessageBox.Show("Mã phiếu chi không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã phiếu chi cần tìm");
            }
        }
    }
}
