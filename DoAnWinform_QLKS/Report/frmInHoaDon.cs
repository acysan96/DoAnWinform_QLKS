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
using DTO_QLKS;
using CrystalDecisions.Shared;
namespace DoAnWinform_QLKS.Report
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        DataTable dataTable = new DataTable();
        public string text { get; set; }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(text);
            dataTable = hoaDon_BUL.inHoaDon(hoaDon_DTO);
            rptHoaDon rpt = new rptHoaDon();
            rpt.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
