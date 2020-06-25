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
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbCN.SelectedValue.ToString();

            if (cmbCN.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", string.Empty, MessageBoxButtons.OK);
            else
            {
                //LoadTable();
            }
        }

        private void frmDSNV_Load(object sender, EventArgs e)
        {
            cmbCN.DataSource = Program.bds_dspm.DataSource;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            //cmbCN.SelectedIndex = -1;
            cmbCN.SelectedIndex = Program.mChinhanh;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {

            Report.XtraReport_DanhSachNhanVien XtraReport_DanhSachNhanVien = new Report.XtraReport_DanhSachNhanVien();
            ReportPrintTool report = new ReportPrintTool(XtraReport_DanhSachNhanVien);
            report.ShowPreviewDialog();

        }
    }
}

