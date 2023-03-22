using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem1._1
{
    public partial class frmPreview : Form
    {
        public frmPreview(string sql,string rptname)
        {
            InitializeComponent();

            reports(sql, rptname);
        }
        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query, field;
        int maxrow;

        private void reports(string sql, string rptname)
        {
            try
            {
                SQL.loadReports(sql);
                string reportname, strReportPath;

                reportname = rptname;
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                strReportPath = Application.StartupPath + "\\reports\\" + reportname + ".rpt";
                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(SQL.dt);

                crystalReportViewer1.ReportSource = reportdoc;
                crystalReportViewer1.ShowRefreshButton = false;
                crystalReportViewer1.ShowCloseButton = false;
                crystalReportViewer1.ShowGroupTreeButton = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " No crytal reports installed.");
            }


        }
        private void frmPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
