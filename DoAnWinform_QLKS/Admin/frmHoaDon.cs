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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon(frmAdminMain_NhanVien frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        frmAdminMain_NhanVien _frm;
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            float doanhThu = 0;
            dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
            dtGVHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                cbTimHoaDon.Items.Add(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[0]);
            }
            btnXoa.Enabled = false;
            txtSoLuongHD.Text = Convert.ToString(dtGVHoaDon.Rows.Count - 1);
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                doanhThu += float.Parse(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[7].ToString());
            }
            txtDoanhThu.Text = Convert.ToString(doanhThu);
            txtSoLuongHD.Enabled = false;
            txtDoanhThu.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
            cbTimHoaDon.Text = null;
            cbTimHoaDon.Items.Clear();
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                cbTimHoaDon.Items.Add(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[0]);
            }
            float doanhThu = 0;
            txtSoLuongHD.Text = Convert.ToString(dtGVHoaDon.Rows.Count - 1);
            for (int i = 0; i < hoaDon_BUL.layToanBoHoaDon().Rows.Count; i++)
            {
                doanhThu += float.Parse(hoaDon_BUL.layToanBoHoaDon().Rows[i].ItemArray[7].ToString());
            }
            txtDoanhThu.Text = Convert.ToString(doanhThu);
        }

        private void dtGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dtGVHoaDon.Rows[0].Cells[0].Value.ToString();
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(id);
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (hoaDon_BUL.xoaHoaDon(hoaDon_DTO) > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại");
                }
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < dtGVHoaDon.Rows.Count; i++)
            //{
            //    dtGVHoaDon.Rows.RemoveAt(i);
            //}
            for(int  i = 0; i < dtGVHoaDon.Rows.Count - 1;)
            {
                string id = dtGVHoaDon.Rows[i].Cells[0].Value.ToString();
                HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(id);
                hoaDon_BUL.xoaHoaDon(hoaDon_DTO);
                i++;
            }
            //do
            //{
            //    int i = 0;
            //    string id = dtGVHoaDon.Rows[i].Cells[0].Value.ToString();
            //    HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(id);
            //    hoaDon_BUL.xoaHoaDon(hoaDon_DTO);
            //    i++;
            //}
            //while (dtGVHoaDon.Rows.Count > hoaDon_BUL.layToanBoHoaDon().Rows.Count);
            dtGVHoaDon.DataSource = hoaDon_BUL.layToanBoHoaDon();
            if (hoaDon_BUL.layToanBoHoaDon().Rows.Count == 0)
            {
                MessageBox.Show("Xóa toàn bộ hóa đơn thành công");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.frmInDanhSachHoaDon frm = new Report.frmInDanhSachHoaDon();
            frm.Show();
        }
    }
}
