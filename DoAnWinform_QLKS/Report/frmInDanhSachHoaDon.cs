using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL_QLKS;

namespace DoAnWinform_QLKS.Report
{
    public partial class frmInDanhSachHoaDon : Form
    {
        public frmInDanhSachHoaDon()
        {
            InitializeComponent();
        }
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        DataTable dataTable = new DataTable();
        private void frmInDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dataTable = hoaDon_BUL.inDanhSachHoaDon();
            rptDanhSachHoaDon rpt = new rptDanhSachHoaDon();
            rpt.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
