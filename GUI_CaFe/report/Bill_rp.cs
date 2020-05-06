using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Cafe;

namespace GUI_CaFe.report
{
    public partial class Bill_rp : Form
    {
        public Bill_rp()
        {
            InitializeComponent();
        }
        DateTime dateStart, endStart;
        public Bill_rp(DateTime dateStart, DateTime endStart)
        {
            this.dateStart = dateStart;
            this.endStart = endStart;
            InitializeComponent();
        }
        private void Bill_rp_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("startDate", this.dateStart.ToString("dd/MM/yyyy")));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("endDate", this.endStart.ToString("dd/MM/yyyy")));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", BillInfoDao.Instance.getBillByDate(this.dateStart, this.endStart)));
            this.reportViewer1.RefreshReport();
        }

        private void Bill_rp_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
