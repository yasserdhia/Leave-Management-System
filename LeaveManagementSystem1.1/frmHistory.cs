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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;

        private void txtapprovesearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Start of Date Leave',`LEAVEENDDATE` as 'End of Date Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons'   FROM `employee` e,`leave` l  WHERE e.`EMPID`=l.`EMPID` " +
                    " AND (e.`EMPID` LIKE '%" + txtapprovesearch.Text + "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" + txtapprovesearch.Text + "%')";
            SQL.Load_DTG(query, dtgapprovedlist);
            
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            txtapprovesearch_TextChanged(sender, e);
        }
    }
}
