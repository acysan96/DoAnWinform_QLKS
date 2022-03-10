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
    public partial class frmPhong : Form
    {
        public frmPhong(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        Phong_BUL phong_BUL = new Phong_BUL();
        //FormClosingEventArgs q;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            dtGVPhong.DataSource = phong_BUL.layToanBoPhong();
            dtGVPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < phong_BUL.layToanBoPhong().Rows.Count; i++)
            {
                cbTimPhong.Items.Add(phong_BUL.layToanBoPhong().Rows[i].ItemArray[0]);
            }
            cbTinhTrang.Items.Add("Hired");
            cbTinhTrang.Items.Add("Ready");
            cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
            //frmPhong_FormClosing(sender, q);
        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                //this.Close();
                e.Cancel = true;
                //_frm.Show();
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
            txtSLGiuong.Clear();
            txtGia1Dem.Clear();
            cbTinhTrang.Text = null;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dtGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaPhong.Text = dtGVPhong.Rows[i].Cells[0].Value.ToString();
                txtSLGiuong.Text = dtGVPhong.Rows[i].Cells[1].Value.ToString();
                txtGia1Dem.Text = dtGVPhong.Rows[i].Cells[2].Value.ToString();
                cbTinhTrang.Text = dtGVPhong.Rows[i].Cells[3].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaPhong.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.ToUpper();
            int slGiuong;
            float gia1Dem;
            string tinhTrang = cbTinhTrang.Text;
            if (txtMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã phòng");
            }
            else if (txtSLGiuong.Text == string.Empty)
            {
                MessageBox.Show("Nhập số lượng giường");
            }
            else if (txtGia1Dem.Text == string.Empty)
            {
                MessageBox.Show("Nhập giá 1 đêm");
            }
            else if (cbTinhTrang.Text == string.Empty)
            {
                MessageBox.Show("Chọn tình trạng phòng");
            }
            else
            {
                slGiuong = int.Parse(txtSLGiuong.Text);
                gia1Dem = float.Parse(txtGia1Dem.Text);
                Phong_DTO phong_DTO = new Phong_DTO(maPhong, slGiuong, gia1Dem, tinhTrang);
                if(phong_BUL.themPhong(phong_DTO) > 0)
                {
                    MessageBox.Show("Thêm phòng thành công");
                    dtGVPhong.DataSource = phong_BUL.layToanBoPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.ToUpper();
            int slGiuong;
            float gia1Dem;
            string tinhTrang = cbTinhTrang.Text;
            if (txtMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã phòng");
            }
            else if (txtSLGiuong.Text == string.Empty)
            {
                MessageBox.Show("Nhập số lượng giường");
            }
            else if (txtGia1Dem.Text == string.Empty)
            {
                MessageBox.Show("Nhập giá 1 đêm");
            }
            else if (cbTinhTrang.Text == string.Empty)
            {
                MessageBox.Show("Chọn tình trạng phòng");
            }
            else
            {
                slGiuong = int.Parse(txtSLGiuong.Text);
                gia1Dem = float.Parse(txtGia1Dem.Text);
                Phong_DTO phong_DTO = new Phong_DTO(maPhong, slGiuong, gia1Dem, tinhTrang);
                if (phong_BUL.suaPhong(phong_DTO) > 0)
                {
                    MessageBox.Show("Sửa phòng thành công");
                    dtGVPhong.DataSource = phong_BUL.layToanBoPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa phòng thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaPhong.Text.ToUpper();
            Phong_DTO phong_DTO = new Phong_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (phong_BUL.xoaPhong(phong_DTO) > 0)
                {
                    MessageBox.Show("Xóa phòng thành công");
                    dtGVPhong.DataSource = phong_BUL.layToanBoPhong();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại");
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVPhong.DataSource = phong_BUL.layToanBoPhong();
            cbTimPhong.Text = null;
            cbTimPhong.Items.Clear();
            for (int i = 0; i < phong_BUL.layToanBoPhong().Rows.Count; i++)
            {
                cbTimPhong.Items.Add(phong_BUL.layToanBoPhong().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimPhong.Text.ToUpper();
            Phong_DTO phong_DTO = new Phong_DTO(id);
            if (cbTimPhong.Text != string.Empty)
            {
                if (phong_BUL.layMotPhong(phong_DTO).Rows.Count > 0)
                {
                    dtGVPhong.DataSource = phong_BUL.layMotPhong(phong_DTO);
                }
                else
                {
                    MessageBox.Show("Mã phòng không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã phòng cần tìm");
            }
        }
    }
}
