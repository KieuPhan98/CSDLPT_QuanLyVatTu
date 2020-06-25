using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_VT.Report
{
    public partial class XtraReport_BangKe : DevExpress.XtraReports.UI.XtraReport
    {
        private string connstr;

        public XtraReport_BangKe(string connstr)
        {
            this.connstr = connstr;
        }
        public XtraReport_BangKe(string LOAI, int THANGBD, int THANGKT)
        {
            InitializeComponent();
            dataset_Report1.EnforceConstraints = false;
            this.sp_BangKeTableAdapter.Fill(dataset_Report1.sp_BangKe, LOAI, THANGBD, THANGKT);
        }

    }
}
