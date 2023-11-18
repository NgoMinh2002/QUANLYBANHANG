using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class BCnhapxuat : Form
    {
        public BCnhapxuat()
        {
            InitializeComponent();
        }

        private void BCnhapxuat_Load(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "Select * from Nhap_xuat";

            DataTable tb = connect.query(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYBANHANG.Report1.rdlc";
            ReportDataSource report = new ReportDataSource();
            report.Name = "Baocao";
            report.Value = tb;
            reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
