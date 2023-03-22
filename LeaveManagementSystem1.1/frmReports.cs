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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
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

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            query = "SELECT concat(`emp_fname`, ' ',`emp_lname`),`LEAVEAPPLIED`,`LEAVEDATE`,`LEAVEENDDATE`, `NODAYS` ,`REMAININGLEAVE`,  `DEFAULTLEAVE`  FROM `employee` e,`leave` l WHERE e.`EMPID`=l.`EMPID`"
                    + " AND e.EMPID='" + dtglist.CurrentRow.Cells[0].Value + "'"; 
            reports(query, "categ");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee` WHERE  " + field + " LIKE '%" + txtsearch.Text + "%' ";
            SQL.Load_DTG(query, dtglist);
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cboCategory.Text == "Id")
            {
                field = "EMPID";
            }
            else if (cboCategory.Text == "First Name")
            {
                field = "emp_fname";
            }

            else if (cboCategory.Text == "Last Name")
            {
                field = "emp_lname";
            } 
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            query = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee`  ";
            SQL.Load_DTG(query, dtglist);
            field = "EMPID";
        }
    }
}
