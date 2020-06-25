using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_VT.Report
{
    public partial class XtraReport_DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DanhSachNhanVien()
        {
            InitializeComponent();
            this.sp_report_DanhSachNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            dataset_Report1.EnforceConstraints = false;
            this.sp_report_DanhSachNhanVienTableAdapter.Fill(dataset_Report1.sp_report_DanhSachNhanVien );
        }

    }
}
