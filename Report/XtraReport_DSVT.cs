using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_VT.Report
{
    public partial class XtraReport_DSVT : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSVT()
        {
            InitializeComponent();

            dataset_Report1.EnforceConstraints = false;
            this.sp_danhsachvattuTableAdapter.Fill(dataset_Report1.sp_danhsachvattu);
        }

    }
}
