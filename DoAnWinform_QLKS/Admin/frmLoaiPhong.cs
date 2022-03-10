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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        LoaiPhong_BUL loaiPhong_BUL = new LoaiPhong_BUL();
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            dtGVLoaiPhong.DataSource = loaiPhong_BUL.layToanBoLoaiPhong();
            dtGVLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < loaiPhong_BUL.layToanBoLoaiPhong().Rows.Count; i++)
            {
                cbTimLoaiPhong.Items.Add(loaiPhong_BUL.layToanBoLoaiPhong().Rows[i].ItemArray[0]);
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dtGVLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaPhong.Text = dtGVLoaiPhong.Rows[i].Cells[0].Value.ToString();
                txtTenLoaiPhong.Text = dtGVLoaiPhong.Rows[i].Cells[1].Value.ToString();
                txtPhongDaThue.Text = dtGVLoaiPhong.Rows[i].Cells[2].Value.ToString();
                txtPhongConTrong.Text = dtGVLoaiPhong.Rows[i].Cells[3].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaPhong.Enabled = false;
            }
        }

        private void frmLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
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
            txtMaPhong.Enabled = true;
            txtMaPhong.Clear();
            txtMaPhong.Focus();
            txtTenLoaiPhong.Clear();
            txtPhongDaThue.Clear();
            txtPhongConTrong.Clear();
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
            string maPhong = txtMaPhong.Text.ToUpper();
            string tenLoai = txtTenLoaiPhong.Text;
            int phongDaThue;
            int phongTrong;
            if (txtMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã loại phòng");
            }
            else if (txtTenLoaiPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên loại phòng");
            }
            else if (txtPhongDaThue.Text == string.Empty)
            {
                MessageBox.Show("Nhập số phòng đã có khách thuê");
            }
            else if (txtPhongConTrong.Text == string.Empty)
            {
                MessageBox.Show("Nhập số phòng còn trống");
            }
            else
            {
                phongDaThue = int.Parse(txtPhongDaThue.Text);
                phongTrong = int.Parse(txtPhongConTrong.Text);
                LoaiPhong_DTO loaiPhong_DTO = new LoaiPhong_DTO(maPhong, tenLoai, phongDaThue, phongTrong);
                if(loaiPhong_BUL.themLoaiPhong(loaiPhong_DTO) > 0)
                {
                    MessageBox.Show("Thêm loại phòng thành công");
                    dtGVLoaiPhong.DataSource = loaiPhong_BUL.layToanBoLoaiPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm loại phòng thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.ToUpper();
            string tenLoai = txtTenLoaiPhong.Text;
            int phongDaThue;
            int phongTrong;
            if (txtMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã loại phòng");
            }
            else if (txtTenLoaiPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập tên loại phòng");
            }
            else if (txtPhongDaThue.Text == string.Empty)
            {
                MessageBox.Show("Nhập số phòng đã có khách thuê");
            }
            else if (txtPhongConTrong.Text == string.Empty)
            {
                MessageBox.Show("Nhập số phòng còn trống");
            }
            else
            {
                phongDaThue = int.Parse(txtPhongDaThue.Text);
                phongTrong = int.Parse(txtPhongConTrong.Text);
                LoaiPhong_DTO loaiPhong_DTO = new LoaiPhong_DTO(maPhong, tenLoai, phongDaThue, phongTrong);
                if (loaiPhong_BUL.suaLoaiPhong(loaiPhong_DTO) > 0)
                {
                    MessageBox.Show("Sửa loại phòng thành công");
                    dtGVLoaiPhong.DataSource = loaiPhong_BUL.layToanBoLoaiPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa loại phòng thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaPhong.Text.ToUpper();
            LoaiPhong_DTO loaiPhong_DTO = new LoaiPhong_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (loaiPhong_BUL.xoaLoaiPhong(loaiPhong_DTO) > 0)
                {
                    MessageBox.Show("Xóa loại phòng thành công");
                    dtGVLoaiPhong.DataSource = loaiPhong_BUL.layToanBoLoaiPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng thất bại");
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVLoaiPhong.DataSource = loaiPhong_BUL.layToanBoLoaiPhong();
            cbTimLoaiPhong.Text = null;
            cbTimLoaiPhong.Items.Clear();
            for (int i = 0; i < loaiPhong_BUL.layToanBoLoaiPhong().Rows.Count; i++)
            {
                cbTimLoaiPhong.Items.Add(loaiPhong_BUL.layToanBoLoaiPhong().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimLoaiPhong.Text.ToUpper();
            LoaiPhong_DTO loaiPhong_DTO = new LoaiPhong_DTO(id);
            if (cbTimLoaiPhong.Text != string.Empty)
            {
                if (loaiPhong_BUL.layMotLoaiPhong(loaiPhong_DTO).Rows.Count > 0)
                {
                    dtGVLoaiPhong.DataSource = loaiPhong_BUL.layMotLoaiPhong(loaiPhong_DTO);
                }
                else
                {
                    MessageBox.Show("Mã loại phòng không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã loại phòng cần tìm");
            }
        }
    }
}
