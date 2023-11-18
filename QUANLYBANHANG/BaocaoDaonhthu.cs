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
    public partial class BaocaoDaonhthu : Form
    {
        public BaocaoDaonhthu()
        {
            InitializeComponent();
        }

        private void BaocaoDaonhthu_Load(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select * from baocaoDT";

            DataTable tb = connect.query(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYBANHANG.CaoBaoDT.rdlc";
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
    }
}
