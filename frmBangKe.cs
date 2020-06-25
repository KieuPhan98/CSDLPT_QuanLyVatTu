using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VT
{
    public partial class frmBangKe : Form
    {
        public frmBangKe()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Report.XtraReport_BangKe rpt_BangKe = new Report.XtraReport_BangKe(cmbLoaiPhieu.Text.Substring(0, 1), int.Parse(cmbThangBT.Text), int.Parse(cmbThangKT.Text));
            rpt_BangKe.lblTieuDe.Text = "BẢNG KÊ CHI TIẾT PHIẾU " + cmbLoaiPhieu.Text.ToUpper() + " THEO THÁNG " + cmbThangBT.Text + " ĐẾN THÁNG " + cmbThangKT.Text;
            ReportPrintTool print = new ReportPrintTool(rpt_BangKe);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
