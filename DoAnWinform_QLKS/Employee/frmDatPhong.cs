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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong(frmEmployeeMain frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmEmployeeMain _frm;
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();
        Phong_BUL phong_BUL = new Phong_BUL();
        User_BUL user_BUL = new User_BUL();
        public string maPhong { get; set; }
        public string maNV { get; set; }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
            dtGVHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                cbTimHoaDon.Items.Add(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < khachHang_BUL.layToanBoKhachHang().Rows.Count; i++)
            {
                cbMaKH.Items.Add(khachHang_BUL.layToanBoKhachHang().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < phong_BUL.layToanBoPhong().Rows.Count; i++)
            {
                cbMaPhong.Items.Add(phong_BUL.layToanBoPhong().Rows[i].ItemArray[0]);
            }
            for (int i = 0; i < user_BUL.layToanBoUsers().Rows.Count; i++)
            {
                cbMaNV.Items.Add(user_BUL.layToanBoUsers().Rows[i].ItemArray[0]);
            }
            cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPayment.Items.Add("Zalo Pay");
            cbPayment.Items.Add("Credit Card");
            cbPayment.Items.Add("Momo");
            cbPayment.Items.Add("Tài khoản ngân hàng");
            cbPayment.Items.Add("Tiền mặt");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTinhTien.Enabled = false;
            if(maPhong != null)
            {
                for (int i = 0; i < cbMaPhong.Items.Count; i++)
                {
                    if (cbMaPhong.Items[i].ToString().StartsWith(maPhong))
                    {
                        cbMaPhong.SelectedIndex = i;
                    }
                }
            }
            else if(maPhong == null)
            {
                cbMaPhong.Text = null;
            }
            //
            if (maNV != null)
            {
                for (int i = 0; i < cbMaNV.Items.Count; i++)
                {
                    if (cbMaNV.Items[i].ToString().StartsWith(maNV.ToUpper()))
                    {
                        cbMaNV.SelectedIndex = i;
                    }
                }
            }
            else if (maNV == null)
            {
                cbMaNV.Text = null;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmDatPhong_FormClosing(object sender, FormClosingEventArgs e)
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
            txtMaHD.Enabled = true;
            txtMaHD.Clear();
            txtMaHD.Focus();
            cbMaNV.Text = null;
            cbMaKH.Text = null;
            cbPayment.Text = null;
            cbMaPhong.Text = null;
            txtTongTien.Clear();
            dtpNgayDatPhong.Value = DateTime.Now;
            dtpNgayTraPhong.Value = DateTime.Now;
            btnDatPhong.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTinhTien.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.ToUpper();
            string maNV = cbMaNV.Text;
            string maKH = cbMaKH.Text;
            string payment = cbPayment.Text;
            string maPhong = cbMaPhong.Text;
            float tongTien;
            DateTime ngayDatPhong = dtpNgayDatPhong.Value;
            DateTime ngayTraPhong = dtpNgayTraPhong.Value;
            if (txtMaHD.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã hóa đơn");
            }
            else if (cbMaNV.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhân viên ghi hóa đơn");
            }
            else if (cbMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã phòng cần đặt");
            }
            else if (cbMaKH.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã khách hàng");
            }
            else if (dtpNgayTraPhong.Value < dtpNgayDatPhong.Value)
            {
                MessageBox.Show("Chọn ngày trả phòng");
            }
            else if (cbPayment.Text == string.Empty)
            {
                MessageBox.Show("Chọn phương thức thanh toán");
            }
            else if (txtTongTien.Text == string.Empty)
            {
                MessageBox.Show("Nhập tổng giá hóa đơn");
            }
            else
            {
                tongTien = float.Parse(txtTongTien.Text);
                HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(maHD, maNV, maPhong, maKH, ngayDatPhong, ngayTraPhong, payment, tongTien);
                if (hoaDon_BUL.themHoaDon(hoaDon_DTO) > 0)
                {
                    MessageBox.Show("Đặt phòng thành công");
                    dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
                    clear();
                }
                else
                {
                    MessageBox.Show("Đặt phòng thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.ToUpper();
            string maNV = cbMaNV.Text;
            string maKH = cbMaKH.Text;
            string payment = cbPayment.Text;
            string maPhong = cbMaPhong.Text;
            float tongTien;
            DateTime ngayDatPhong = dtpNgayDatPhong.Value;
            DateTime ngayTraPhong = dtpNgayTraPhong.Value;
            if (txtMaHD.Text == string.Empty)
            {
                MessageBox.Show("Nhập mã hóa đơn");
            }
            else if (cbMaNV.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhân viên ghi hóa đơn");
            }
            else if (cbMaPhong.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã phòng cần đặt");
            }
            else if (cbMaKH.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã khách hàng");
            }
            else if (dtpNgayTraPhong.Value < dtpNgayDatPhong.Value)
            {
                MessageBox.Show("Chọn ngày trả phòng");
            }
            else if (cbPayment.Text == string.Empty)
            {
                MessageBox.Show("Chọn phương thức thanh toán");
            }
            else if (txtTongTien.Text == string.Empty)
            {
                MessageBox.Show("Nhập tổng giá hóa đơn");
            }
            else
            {
                tongTien = float.Parse(txtTongTien.Text);
                HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(maHD, maNV, maPhong, maKH, ngayDatPhong, ngayTraPhong, payment, tongTien);
                if (hoaDon_BUL.suaHoaDon(hoaDon_DTO) > 0)
                {
                    MessageBox.Show("Sửa hóa đơn thành công");
                    dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
                    clear();
                }
                else
                {
                    MessageBox.Show("Sửa hóa đơn thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaHD.Text.ToUpper();
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (hoaDon_BUL.xoaHoaDon(hoaDon_DTO) > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
                    clear();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại");
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
            cbTimHoaDon.Text = null;
            cbTimHoaDon.Items.Clear();
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                cbTimHoaDon.Items.Add(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[0]);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = cbTimHoaDon.Text.ToUpper();
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(id);
            if (cbTimHoaDon.Text != string.Empty)
            {
                if (hoaDon_BUL.layMotHoaDon(hoaDon_DTO).Rows.Count > 0)
                {
                    dtGVHoaDon.DataSource = hoaDon_BUL.layMotHoaDon(hoaDon_DTO);
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn không có trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhập hoặc chọn mã hóa đơn cần tìm");
            }
        }

        private void dtGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaHD.Text = dtGVHoaDon.Rows[i].Cells[0].Value.ToString();
                cbMaNV.Text = dtGVHoaDon.Rows[i].Cells[1].Value.ToString();
                cbMaPhong.Text = dtGVHoaDon.Rows[i].Cells[2].Value.ToString();
                cbMaKH.Text = dtGVHoaDon.Rows[i].Cells[3].Value.ToString();
                dtpNgayDatPhong.Text = dtGVHoaDon.Rows[i].Cells[4].Value.ToString();
                dtpNgayTraPhong.Text = dtGVHoaDon.Rows[i].Cells[5].Value.ToString();
                cbPayment.Text = dtGVHoaDon.Rows[i].Cells[6].Value.ToString();
                txtTongTien.Text = dtGVHoaDon.Rows[i].Cells[7].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDatPhong.Enabled = false;
                btnTinhTien.Enabled = true;
                txtMaHD.Enabled = false;
            }
        }

        private string autoMaHD()
        {
            System.Random rd = new System.Random();
            string id;
            id = "HD" + "0" + rd.Next(minValue: 1, maxValue: 99999);
            return id;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = autoMaHD();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tổng hóa đơn của quý khách là: " + txtTongTien.Text + " VND. Thanh toán ?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Report.frmInHoaDon frm = new Report.frmInHoaDon();
                frm.text = txtMaHD.Text;
                frm.Show();
            }
        }
    }
}
