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
    public partial class frmListofEmployee : Form
    {
        public frmListofEmployee()
        {
            InitializeComponent();
        }

        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;

        private void frmListofEmployee_Load(object sender, EventArgs e)
        {
            query = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" 
                + ", round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'ADDRESS'" 
                + ", `contact` AS 'CONTACT'  FROM `employee` WHERE `EMPID` LIKE '%" + txtempsearch.Text + "%'" 
                + " OR emp_fname LIKE '%" + txtempsearch.Text + "%' OR emp_lname LIKE '%" + txtempsearch.Text + "%'";
            SQL.Load_DTG(query, dtgemplist);
        }

        private void txtempsearch_TextChanged(object sender, EventArgs e)
        {
            frmListofEmployee_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmEmployee( dtgemplist.CurrentRow.Cells[0].Value.ToString(),"Edit Employee");
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM employee WHERE EMPID = '" + dtgemplist.CurrentRow.Cells[0].Value + "'";
            SQL.Execute_Query(query); 
            query = "DELETE FROM employee_workinfo WHERE EMPID = '" + dtgemplist.CurrentRow.Cells[0].Value + "'";
            SQL.Execute_Query(query);

            frmListofEmployee_Load(sender, e);
        }

        private void btnPrintStud_Click(object sender, EventArgs e)
        { 
            query = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type" +
                " FROM  `employee` e,  `employee_workinfo` w " +
                " WHERE e.EMPID = w.EMPID AND e.EMPID='" + dtgemplist.CurrentRow.Cells[0].Value + "'"; 
            Form frm = new frmPreview(query, "selectedemployee");
            frm.ShowDialog();



        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            query = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`";
            Form frm = new frmPreview(query, "allemployees");
            frm.ShowDialog();
        }
    }
}
