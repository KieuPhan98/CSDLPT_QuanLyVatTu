using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_VT.Report
{
    public partial class XtraReport_DDHchuacoPN : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DDHchuacoPN()
        {
            InitializeComponent();
            dataset_Report1.EnforceConstraints = false;
            this.sP_DonDatHangChuaCoPhieuNhapTableAdapter.Fill(dataset_Report1.SP_DonDatHangChuaCoPhieuNhap);
        }

    }
}
