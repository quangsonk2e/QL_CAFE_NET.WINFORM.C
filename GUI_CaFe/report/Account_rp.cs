using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Cafe;
using Microsoft.Reporting.WinForms;

namespace GUI_CaFe.report
{
    public partial class Account_rp : Form
    {
        public Account_rp()
        {
            InitializeComponent();
        }

        private void Account_rp_Load(object sender, EventArgs e)
        {
            ReportParameter rpt1 = new ReportParameter("ten1", "Tẻn");
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rpt1 });
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ten", "Lại Quang Sơn"));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", AccountDAO.Instance.getAccount()));
            this.reportViewer1.RefreshReport();
        }

        private void Account_rp_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
